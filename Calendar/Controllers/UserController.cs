﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

using Calendar.Data;
using Calendar.Data.Entities;
using Calendar.Data.Enums;
using Calendar.Models;
using Calendar.Services;

namespace Calendar.Controllers
{
    public class UserController : Controller
    {
        private readonly IStringLocalizer<UserController> _localizer;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _db;
        private readonly ILogger _logger;

        public UserController(
            IStringLocalizer<UserController> localizer,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            ApplicationDbContext db,
            ILogger<UserController> logger)
        {
            _localizer = localizer;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _db = db;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<ApplicationUser> users = await _db.Users.Include(u => u.UserRoles).ThenInclude(r => r.Role).ToListAsync();
            users.ForEach(u =>
            {
                u.IsAdmin = u.UserRoles.Any(r => ((r.User == u) && (r.Role.Name.Equals("Admin", StringComparison.InvariantCultureIgnoreCase))));
                u.IsStylist = u.UserRoles.Any(r => ((r.User == u) && (r.Role.Name.Equals("Stylist", StringComparison.InvariantCultureIgnoreCase))));
            });

            return View(users);
        }

        public async Task<ActionResult> Detail(Guid id)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            ApplicationUser user = await _db.Users.Include(u => u.UserRoles).ThenInclude(r => r.Role).FirstOrDefaultAsync(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            user.IsAdmin = user.UserRoles.Any(r => ((r.User == user) && (r.Role.Name.Equals("Admin", StringComparison.InvariantCultureIgnoreCase))));
            user.IsStylist = user.UserRoles.Any(r => ((r.User == user) && (r.Role.Name.Equals("Stylist", StringComparison.InvariantCultureIgnoreCase))));

            return View(user);
        }

        // GET: Employee/Create
        public async Task<IActionResult> AddOrEdit(Guid? id = null)
        {
            if (!id.HasValue)
                return View(new ApplicationUser());
            else
            {
                ApplicationUser user = await _db.Users.Include(u => u.UserRoles).ThenInclude(r => r.Role).FirstOrDefaultAsync(c => c.Id == id.Value);
                user.IsAdmin = user.UserRoles.Any(r => ((r.User == user) && (r.Role.Name.Equals("Admin", StringComparison.InvariantCultureIgnoreCase))));
                user.IsStylist = user.UserRoles.Any(r => ((r.User == user) && (r.Role.Name.Equals("Stylist", StringComparison.InvariantCultureIgnoreCase))));

                return View(user);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,FirstName,LastName,Email,PhoneNumber,UserName,PasswordHash,DefaultColor,IsAdmin,IsStylist")] ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                ApplicationRole adminRole = _db.Roles.FirstOrDefault(r => r.Name.Equals("Admin", StringComparison.InvariantCultureIgnoreCase));
                ApplicationRole stylistRole = _db.Roles.FirstOrDefault(r => r.Name.Equals("Stylist", StringComparison.InvariantCultureIgnoreCase));

                if (user.Id == Guid.Empty)
                {
                    user.Created = DateTime.Now;
                    user.Status = UserStatus.Created;

                    if (user.IsAdmin)
                    {
                        user.UserRoles.Add(new ApplicationUserRole() { User = user, Role = adminRole, Added = DateTime.Now });
                    }
                    if (user.IsStylist)
                    {
                        user.UserRoles.Add(new ApplicationUserRole() { User = user, Role = stylistRole, Added = DateTime.Now });
                    }

                    _db.Add(user);
                }
                else
                {
                    bool currentlyIsAdmin = _db.Users.Include(u => u.UserRoles).Any(u => ((user == u) && u.UserRoles.Any(r => ((r.User == u) && (r.Role == adminRole)))));
                    bool currentlyIsStylist = _db.Users.Include(u => u.UserRoles).Any(u => ((user == u) && u.UserRoles.Any(r => ((r.User == u) && (r.Role == stylistRole)))));

                    if (currentlyIsAdmin && !user.IsAdmin)
                    {
                        ApplicationUserRole adminUserRole = _db.UserRoles.FirstOrDefault(ur => (ur.User == user) && (ur.Role == adminRole));
                        if (adminUserRole != null)
                        {
                            user.UserRoles.Remove(adminUserRole);
                        }
                    }
                    if (!currentlyIsAdmin && user.IsAdmin)
                    {
                        user.UserRoles.Add(new ApplicationUserRole() { User = user, Role = adminRole, Added = DateTime.Now });
                    }

                    if (currentlyIsStylist && !user.IsStylist)
                    {
                        ApplicationUserRole stylistUserRole = _db.UserRoles.FirstOrDefault(ur => (ur.User == user) && (ur.Role == stylistRole));
                        if (stylistUserRole != null)
                        {
                            user.UserRoles.Remove(stylistUserRole);
                        }
                    }
                    if (!currentlyIsStylist && user.IsStylist)
                    {
                        user.UserRoles.Add(new ApplicationUserRole() { User = user, Role = stylistRole, Added = DateTime.Now });
                    }

                    user.Status = UserStatus.Modified;

                    _db.Update(user);
                }

                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            var user = await _db.Users.FindAsync(id);
            _db.Users.Remove(user);

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
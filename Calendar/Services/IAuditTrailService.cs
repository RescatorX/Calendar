using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Calendar.Data;
using Calendar.Data.Entities;
using Calendar.Models;

namespace Calendar.Services
{
    public interface IAuditTrailService
    {
        Task<AuditTrail> CreateAuditTrailAsync(ApplicationDbContext db, ApplicationUser user, string title, string operation, string detail = null);
    }
}

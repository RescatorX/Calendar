using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Calendar.Data;
using Calendar.Data.Entities;
using Calendar.Models;

namespace Calendar.Services
{
    public class AuditTrailService : IAuditTrailService
    {
        public async Task<AuditTrail> CreateAuditTrailAsync(ApplicationDbContext db, ApplicationUser user, string title, string operation, string detail = null)
        {
            AuditTrail at = new AuditTrail() { Id = Guid.NewGuid(), User = user, Title = title, Operation = operation, Detail = detail, Created = DateTime.Now };
            db.AuditTrails.Add(at);
            await db.SaveChangesAsync();

            return at;
        }
    }
}

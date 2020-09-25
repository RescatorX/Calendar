using System.Collections.Generic;
using System.Threading.Tasks;

using Calendar.Models;

namespace Calendar.Services
{
    public interface IUserService
    {
        Task<ApplicationUser> GetAllowedUser(string userName);

        Task<List<ApplicationUserRole>> GetUserRoles(string userId);
    }
}

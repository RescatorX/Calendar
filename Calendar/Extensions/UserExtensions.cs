using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Calendar.Models;

namespace Calendar.Extensions
{
    public static class UserExtensions
    {
        public static string GetUserFullName(this ApplicationUser user)
        {
            if (user == null) return string.Empty;

            return $"{user.FirstName} {user.LastName}";
        }
    }
}

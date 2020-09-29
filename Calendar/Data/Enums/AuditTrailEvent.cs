using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Data.Enums
{
    public enum AuditTrailEvent
    {
        Unknown = 0,

        UserLogedIn = 11,
        UserLogedOut = 12,

        EventCreated = 21,
        EventModified = 22,
        EventDeleted = 23,
        EventDisplayed = 24
    }
}

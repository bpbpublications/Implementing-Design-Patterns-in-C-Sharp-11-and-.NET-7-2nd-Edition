using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04.OpenClosedPrinciple
{
    interface IUser
    {
        bool Active { get; set; }
        string Email { get; set; }
        string FullName { get; set; }
        IPlatformAccount PlatformAccount { get; set; }
    }
}

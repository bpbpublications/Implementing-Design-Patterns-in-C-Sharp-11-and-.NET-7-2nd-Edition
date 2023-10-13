using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04.OpenClosedPrinciple
{
    class User : IUser
    {
        public string FullName { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }

        public IPlatformAccount PlatformAccount { get; set; } = new PlatformAccount();
    }
}

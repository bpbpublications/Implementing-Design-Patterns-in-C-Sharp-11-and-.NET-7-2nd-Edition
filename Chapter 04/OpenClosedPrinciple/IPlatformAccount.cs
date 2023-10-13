using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04.OpenClosedPrinciple
{
    interface IPlatformAccount
    {
        Customer Generate(User user);
    }
}

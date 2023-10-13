using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04.LiskovPrinciple
{
    class StandardUser : BaseUser
    {
        public void AccessToLimitedTitles()
        {
            Console.WriteLine("Access to limited titles");
        }
    }
}

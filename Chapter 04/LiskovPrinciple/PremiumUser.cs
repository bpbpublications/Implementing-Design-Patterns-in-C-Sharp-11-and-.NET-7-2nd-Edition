using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04.LiskovPrinciple
{
    class PremiumUser : BaseUser
    {
        public void AccessToUnlimitedTitles()
        {
            Console.WriteLine("Access to unlimited titles");
        }

        public void GiveAccessFamilyMembers()
        {
            Console.WriteLine("Access granted to family members");
        }
    }
}

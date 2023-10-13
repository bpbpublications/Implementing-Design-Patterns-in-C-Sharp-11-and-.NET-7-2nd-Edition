using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPBBookChapter14
{
    public class SaoPauloStrategy : ICityStrategy
    {
        public void ApplyEmploymentRules()
        {
            Console.WriteLine("Must have permanent employees");
        }

        public decimal ApplyProfit(decimal price)
        {
            return price * 0.15m;
        }

        public decimal ApplyTax(decimal price)
        {
            return price * 0.10m;
        }
    }
}

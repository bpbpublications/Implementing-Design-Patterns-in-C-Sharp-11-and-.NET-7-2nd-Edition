using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPBBookChapter14
{
    public interface ICityStrategy
    {
        decimal ApplyTax(decimal price);
        void ApplyEmploymentRules();
        decimal ApplyProfit(decimal price);
    }
}

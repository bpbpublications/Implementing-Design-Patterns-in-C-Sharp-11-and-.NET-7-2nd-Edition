using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04.DependencyInversionPrinciple
{
    internal interface IDocumentConversion
    {
        object Convert(Document document);
    }
}

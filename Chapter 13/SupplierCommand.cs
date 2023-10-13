using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBookChapter13
{
    public class SupplierCommand : IPurchaseCommand
    {
        private readonly Purchase _purchase;

        public SupplierCommand(Purchase purchase)
        {
            this._purchase = purchase;
        }

        public void ExecuteOperation()
        {
            Console.WriteLine("Operation to notify the supplier");
        }

        public void RevertOperation()
        {
            Console.WriteLine("Something failed in the supplier notification");
        }
    }

}

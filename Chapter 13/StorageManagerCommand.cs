using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBookChapter13
{
    public class StorageManagerCommand : IPurchaseCommand
    {
        private readonly Purchase _purchase;

        public StorageManagerCommand(Purchase purchase)
        {
            this._purchase = purchase;
        }

        public void ExecuteOperation()
        {
            Console.WriteLine("Operation to decrease the product quantity availability");
        }

        public void RevertOperation()
        {
            Console.WriteLine("Something failed in the storage operation");
        }
    }
}

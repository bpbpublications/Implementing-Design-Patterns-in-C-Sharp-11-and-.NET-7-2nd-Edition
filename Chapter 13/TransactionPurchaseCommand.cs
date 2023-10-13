namespace DesignPatternsBookChapter13
{
    public class TransactionPurchaseCommand : IPurchaseCommand
    {
        private readonly List<IPurchaseCommand> _purchaseCommands;
        private List<IPurchaseCommand> executedPurchaseCommands;
        private List<IPurchaseCommand> failedPurchaseCommands;

        public TransactionPurchaseCommand(List<IPurchaseCommand> purchaseCommands)
        {
            this._purchaseCommands = purchaseCommands;
            executedPurchaseCommands = new List<IPurchaseCommand>();
            failedPurchaseCommands = new List<IPurchaseCommand>();

        }
        public void ExecuteOperation()
        {
            foreach (var purchaseCommand in _purchaseCommands)
            {
                try
                {
                    purchaseCommand.ExecuteOperation();
                    executedPurchaseCommands.Add(purchaseCommand);
                }
                catch (Exception)
                {
                    failedPurchaseCommands.Add(purchaseCommand);
                }
            }

            if (failedPurchaseCommands.Any())
            {
                RevertOperation();
            }
        }

        public void RevertOperation()
        {
            foreach (var purchaseCommand in executedPurchaseCommands)
            {
                purchaseCommand.RevertOperation();
            }
        }
    }
}



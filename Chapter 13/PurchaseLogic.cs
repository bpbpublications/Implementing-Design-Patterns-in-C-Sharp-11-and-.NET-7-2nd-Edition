namespace DesignPatternsBookChapter13
{
    public class PurchaseLogic
    {
        private readonly IPurchaseCommand _purchaseCommand;
        public PurchaseLogic(IPurchaseCommand purchaseCommand)
        {
            this._purchaseCommand = purchaseCommand;
        }
        public void ConfirmPurchase()
        {
            try
            {
                this._purchaseCommand.ExecuteOperation();
            }
            catch (Exception)
            {
                this._purchaseCommand.RevertOperation();
            }
        }
    }
}

namespace DesignPatternsBookChapter13
{
    public class CreditCardPaymentCommand : IPurchaseCommand
    {
        private readonly Purchase _purchase;

        public CreditCardPaymentCommand(Purchase purchase)
        {
            this._purchase = purchase;
        }

        public void ExecuteOperation()
        {
            Console.WriteLine("Integration with the credit card provider");
        }

        public void RevertOperation()
        {
            Console.WriteLine("Something failed in the payment");
        }
    }
}

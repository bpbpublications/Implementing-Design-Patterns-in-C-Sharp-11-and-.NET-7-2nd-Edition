namespace DesignPatternsBookChapter13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer()
            {
                Id = 1,
                FullName = "Customer example"
            };

            CreditCard creditCard = new CreditCard()
            {
                Id = 1,
                ExpirationDate = new DateTime(2030, 12, 31),
                HolderName = "Customer example",
                Number = "1111222233334444",
                SecurityCode = 123
            };



            Purchase purchase = new Purchase()
            {
                CreditCard = creditCard,
                Date = DateTime.UtcNow,
                Customer = customer,
                Product = new Product()
                {
                    Name = "Book",
                    Supplier = new Supplier
                    {
                        Name = "Book Store"
                    }
                }
            };


            IPurchaseCommand paymentCommand = new CreditCardPaymentCommand(purchase);
            IPurchaseCommand storageCommand = new StorageManagerCommand(purchase);
            IPurchaseCommand supplierCommand = new SupplierCommand(purchase);


            List<IPurchaseCommand> purchaseCommands = new List<IPurchaseCommand>()
            {
                paymentCommand,
                storageCommand,
                supplierCommand
            };

            new TransactionPurchaseCommand(purchaseCommands).ExecuteOperation();





            new PurchaseLogic(paymentCommand).ConfirmPurchase();
            new PurchaseLogic(storageCommand).ConfirmPurchase();
            new PurchaseLogic(supplierCommand).ConfirmPurchase();



        }
    }
}
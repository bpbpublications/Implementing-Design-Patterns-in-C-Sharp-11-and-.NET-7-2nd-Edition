using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04
{
    public class CommercialTransactionExampleTwo
    {
        public void CompleteTransaction()
        {
            new Document().ConvertToPDF(@"C:\desktop\myDocument.docx");
            new Email().Send();
            new LogTransaction().RecordTransaction("Transaction finished at " + DateTime.UtcNow.ToString());

        }

    }

    internal class Document
    {
        public void ConvertToPDF(string path)
        {

        }
    }

    internal class Email
    {
        public void Send()
        {

        }
    }
}

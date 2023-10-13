using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04
{
    public class CommercialTransactionExampleOne
    {
        public void CompleteTransaction()
        {
            //CONVERTING A WORD DOC TO PDF

            Microsoft.Office.Interop.Word.Document wordDocument;
            Microsoft.Office.Interop.Word.Application appWord = new
                Microsoft.Office.Interop.Word.Application();

            wordDocument = appWord.Documents.Open(@"C:\desktop\myDocument.docx");
            wordDocument.ExportAsFixedFormat(@"C:\desktop\myConvertedDocument.pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);

            //SENDING EMAIL
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.companyexample.com");

            mail.From = new MailAddress("donotreply@companyexample.com");
            mail.To.Add("customerexample@gmail.com");
            mail.Subject = "Transaction confirmed";
            mail.Body = "This is a transaction confirmation";


            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
            smtpServer.EnableSsl = true;

            smtpServer.Send(mail);

            //RECORDING LOGS
            new LogTransaction().RecordTransaction("Transaction finished at " + DateTime.UtcNow.ToString());
        }
    }

    internal class LogTransaction
    {
        public LogTransaction()
        {
        }

        internal void RecordTransaction(string v)
        {

        }
    }
}

namespace Chapter_6_MVC
{
    public class PdfService
    {
        public void Convert(string filePath, Session session)
        {
            //Logic for conversion here
        }

        public Session StartSession()
        {
            return new Session();
        }
    }
}


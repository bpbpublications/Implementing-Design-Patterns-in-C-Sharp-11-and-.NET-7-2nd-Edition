namespace Chapter_6_MVC
{
    public class PdfConverter : IPdfConverter
    {
        private Session _session;
        private PdfService _pdfService;

        public PdfConverter()
        {
            _pdfService = new PdfService();
            _session = _pdfService.StartSession();
        }

        public void ConvertToPDF(string filePath)
        {

        }

        public string GetSessionInfo()
        {
            return "Session info: " + _session.Id;
        }
    }
}

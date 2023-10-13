namespace Chapter_6_MVC
{
    public interface IPdfConverter
    {
        void ConvertToPDF(string filePath);
        string GetSessionInfo();
    }
}


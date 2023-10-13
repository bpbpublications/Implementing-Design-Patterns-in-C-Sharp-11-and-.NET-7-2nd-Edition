using Chapter_6_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Chapter_6_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPdfConverter _pdfConverter;

        public HomeController(ILogger<HomeController> logger, 
            IPdfConverter pdfConverter)
        {
            _logger = logger;
            _pdfConverter = pdfConverter;
        }


        public IActionResult Index()
        {
            List<string> sessionInfoList = new List<string>();

            string filePathDocumentOne = @"C:\Temp\file1.docx";
            _pdfConverter.ConvertToPDF(filePathDocumentOne);

            sessionInfoList.Add(_pdfConverter.GetSessionInfo());

            string filePathDocumentTwo = @"C:\Temp\file2.docx";
            _pdfConverter.ConvertToPDF(filePathDocumentTwo);

            sessionInfoList.Add(_pdfConverter.GetSessionInfo());

            return View(sessionInfoList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
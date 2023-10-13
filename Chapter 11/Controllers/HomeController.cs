using DesignPatternsBookChapter11.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DesignPatternsBookChapter11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Product book = new Product() { Name = "Book", Price = 35.00m, Category = "Product" };
            Product laptop = new Product() { Name = "Laptop", Price = 1200.00m, Category = "Product" };
            Product monitor = new Product() { Name = "Monitor", Price = 150.00m, Category = "Product" };

            Combo comboOne = new Combo() { Name = "Combo One", Category = "Combo" };
            comboOne.AddProduct(book);
            comboOne.AddProduct(laptop);
            comboOne.AddProduct(monitor);

            Product keyboard = new Product() { Name = "Keyboard", Price = 20.00m, Category = "Product" };
            Product mouse = new Product() { Name = "Mouse", Price = 15.00m, Category = "Product" };
            Product mousePad = new Product() { Name = "Mouse Pad", Price = 25.00m, Category = "Product" };

            Combo comboTwo = new Combo() { Name = "Combo Two", Category = "Combo" };
            comboTwo.AddProduct(keyboard);
            comboTwo.AddProduct(mouse);
            comboTwo.AddProduct(mousePad);

            comboOne.AddProduct(comboTwo);

            comboOne.GetProductDetails();
            comboOne.GetProductPrice();

            return View();
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
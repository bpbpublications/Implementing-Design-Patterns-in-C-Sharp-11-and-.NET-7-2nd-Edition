using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Chapter8.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            CustomerPlan planVersionOne = new CustomerPlan()
            {
                Name = "Plan Version 1",
                Price = 100,
                PlanVersion = new PlanVersion() { VersionNumber = 1 }
            };

            CustomerPlan planVersionTwo = (CustomerPlan) planVersionOne.DeepCopy();

            planVersionTwo.Price = 200;
            planVersionTwo.Name = "Plan Version 2";
            planVersionTwo.PlanVersion = new PlanVersion() { VersionNumber = 2 };

        }
    }
}
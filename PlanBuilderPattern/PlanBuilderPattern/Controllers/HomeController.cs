using Microsoft.AspNetCore.Mvc;
using PlanBuilderPattern.Builders;
using PlanBuilderPattern.Directors;
using PlanBuilderPattern.Models;
using System.Diagnostics;

namespace PlanBuilderPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPlanDirector _director;

        public HomeController(ILogger<HomeController> logger, IPlanDirector director)
        {
            _director = director;
            _logger = logger;
        }

        public IActionResult Index()
        {
            PricingPlansModel model = new();

            // Build Basic Plan

            var basicPlanBuilder = new BasicPlanBuilder();
            _director.SetPlanBuilder(basicPlanBuilder);
            _director.BuildPlan();
            model.BasicPlan = basicPlanBuilder.GetPlan();

            return View(model);
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
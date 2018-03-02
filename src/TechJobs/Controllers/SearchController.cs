using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Threading;
using TechJobs.Models;


namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        public IActionResult Results(string searchType, string searchTerm)
        {
            ViewBag.columns = ListController.columnChoices;

            if (searchTerm != null)
            {
                ViewBag.jobs = JobData.FindByValue(searchTerm);
                ViewBag.searchTerm = searchTerm;

            }
            else
            {
                return Redirect("/search");
            }


            return View("Index");
        }

    }
}

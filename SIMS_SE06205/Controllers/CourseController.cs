using Microsoft.AspNetCore.Mvc;

namespace SIMS_SE06205.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

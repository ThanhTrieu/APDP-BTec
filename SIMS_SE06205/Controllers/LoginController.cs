using Microsoft.AspNetCore.Mvc;
using SIMS_SE06205.Models;

namespace SIMS_SE06205.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            LoginViewModel vm = new LoginViewModel();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                string username = model.UserName.Trim();
                string password = model.Password.Trim();
                string dataJson = System.IO.File.ReadAllText(@"C:\\CSharp\\data-sims\\data-user.json");
           
                // kiem tra username va password co ton tai trong dataJson hay khong ?

                return Ok(dataJson);
            }
            return View(model);
        }
    }
}

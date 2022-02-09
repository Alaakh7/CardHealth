using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Utils.Models;
using Utils.Models.Enums;
using Utils.Services;
using WebServer.Models;

namespace WebServer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Context context;

        public HomeController(ILogger<HomeController> logger , Context context)
        {
            this.context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var getAccountType = HttpContext.CheckAccountType();
            if (!getAccountType.HasValue)
                return RedirectToAction("Login");

            switch (getAccountType.Value)
            {
                case AccountType.Admin:
                    return RedirectToAction("Index", "AdminPanel");
                default:
                    return RedirectToAction("Index", "HealthPointPanel");
            }
        }

        public IActionResult Login()
        {
            if (HttpContext.CheckUser())
                return RedirectToAction("Index");
            return View();
        }

        [HttpPost]
        public async Task<object> Login(string userName , string password)
        {
            if (HttpContext.CheckUser())
                return RedirectToAction("Index");
            var getUser = await context.Accounts.FirstOrDefaultAsync(x => x.UserName == userName && x.Password == password);
            if (getUser == null)
                return ProblemManager.Display401("Wrong account information");
            HttpContext.CreateSession(getUser);
            return RedirectToAction("Index");
        }
    }
}
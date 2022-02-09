using Microsoft.AspNetCore.Mvc;
using Utils.Models;

namespace WebServer.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Context context;

        public AdminPanelController(ILogger<HomeController> logger, Context context)
        {
            this.context = context;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

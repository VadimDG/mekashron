using mekashron.Models;
using mekashron.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace mekashron.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILoginService _loginService;

        public HomeController(ILogger<HomeController> logger, ILoginService loginService)
        {
            _logger = logger;
            _loginService = loginService;
        }

        public IActionResult Index()
        {
            return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> Index(string Username, string Password)
        {
            ServerResponse? res;
            try
            {
                res = await _loginService.Login(Username, Password);
            }
            catch (Exception e)
            {
                _logger.LogError(new EventId().Id, e, null);
                res = null;
            }

           

            return View(res);
        }
    }
}
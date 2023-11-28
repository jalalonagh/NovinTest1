using BazargahNewTemplate.Domain.UserEntities;
using BazargahNewTemplate.Services;
using Microsoft.AspNetCore.Mvc;

namespace BazargahNewTemplate.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            _userService.Register(user);

            return RedirectToAction("Index", "Home", null);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password, string retry)
        {
            return View();
        }
    }
}

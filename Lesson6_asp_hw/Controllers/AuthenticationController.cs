using Lesson6_asp_hw.Models;
using Lesson6_asp_hw.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Lesson6_asp_hw.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IRepository _repository;
        public string Authentication="Authentication";
        public AuthenticationController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NotFound()
        {
            return View();
        }
        public IActionResult GetUsers()
        {
            var users= _repository.GetUsers();
            return View(users);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserForFluent model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            

            var IsLoggedIn = _repository.Login(model.Email,model.Password);
            if (IsLoggedIn)
            {
                return RedirectToAction(nameof(Welcome));
            }
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
            if (!ModelState.IsValid)
            {
                return View();
            }
            var isAdded= _repository.AddUser(user);
            if (isAdded)
            {
                return RedirectToAction(nameof(Welcome));
            }
            return View(user);
        }


    }
}

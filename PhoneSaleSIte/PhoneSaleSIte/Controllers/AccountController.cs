using System;
using Microsoft.AspNetCore.Mvc;
using Common.Models;
using Entity.Repository.Interface;

namespace PhoneSaleSite.Controllers
{
    public class AccountController : Controller
    {
        private IUserRepository _userRepo;

        public AccountController(IUserRepository repo)
        {
            _userRepo = repo;
        }

        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (model.Password != model.ConfirmPassword)
            {
                throw new Exception("Passwords don't match");
            }
            var user = _userRepo.AddUserToDbAsync(model);
            return View("Index");
        }

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Login([FromForm] LoginModel model)
        {
            var user = _userRepo.FindUserInDbAsync(model);

            var output = new LoginModel();
            output.Email = user.Result.Email;
            output.Password = user.Result.Password;

            return View(output);
        }
    }
}

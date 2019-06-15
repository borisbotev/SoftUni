
namespace Panda.Web.Controllers
{
    using Panda.Services;
    using Panda.Web.ViewModels.Users;
    using SIS.MvcFramework;
    using SIS.MvcFramework.Attributes;
    using SIS.MvcFramework.Result;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class UsersController : Controller
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Login()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Login(LoginInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/Users/Login");
            }

            var user = this.userService.GetUserOrNull(model.Username, model.Password);
            if (user == null)
            {
                return this.Redirect("/Users/Login");
            }

            this.SignIn(user.Id, user.Username, user.Email);
            return Redirect("/");
            
        }

        public IActionResult Logout()
        {
            this.SignOut();
            return this.Redirect("/");
        }
        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/Users/Register");
            }

            if (model.Password != model.ConfirmPassword)
            {
                return this.Redirect("/Users/Register");
            }

            var userId = this.userService.CreateUser(model.Username, model.Email, model.Password);
            this.SignIn(userId,model.Username, model.Email);
            return this.Redirect("/");
        }
    }
}

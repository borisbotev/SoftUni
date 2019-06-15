

namespace Panda.Web.ViewModels.Users
{
    using SIS.MvcFramework.Attributes.Validation;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class RegisterInputModel
    {
        [RequiredSis]
        [StringLengthSis(5,20, "Username between 5 and 20 characters")]
        public string Username { get; set; }

        [RequiredSis]
        [StringLengthSis(5, 20, "Username between 5 and 20 characters")]
        public string Email { get; set; }

        [RequiredSis]
        public string Password { get; set; }

        [RequiredSis]
        public string ConfirmPassword { get; set; }
    }
}

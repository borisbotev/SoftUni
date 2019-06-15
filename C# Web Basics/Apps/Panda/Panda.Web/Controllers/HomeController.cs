

namespace Panda.Web.Controllers
{
    using SIS.MvcFramework;
    using SIS.MvcFramework.Attributes;
    using SIS.MvcFramework.Result;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.Json(new {prop = "a" });
        }

        [HttpGet(Url ="/")]
        public IActionResult IndexSlash()
        {
            return this.Index();
        }
    }
}

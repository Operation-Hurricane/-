using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_MVC.Controllers
{
    public class UsersController1 : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Updpwd()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Bonjour.Models;

namespace Bonjour.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string firstName, string lastName, string langSelect)
        {
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.langSelect = langSelect;
            ViewBag.messageOut = CreateMessage(firstName, langSelect);

            return View();
        }

        public static string CreateMessage(string name, string lang)
        {
            if (name != null && lang != null)
            {
                return string.Format("{0} {1}", lang, name);
            }
            return "";
        }    





    }

    internal class CreateMessage
    {
    }
}

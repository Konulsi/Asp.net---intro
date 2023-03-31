using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Principal;
using System;

namespace Asp.net_intro.Controllers
{
    public class AccountController : Controller
    {
        //3) Account controllerin index action-dan onun view-na userlerin list sekilinde adlarini gonderib ekranda li- taglarinda gostermek.
        public IActionResult Index()
        {
            List<string> users= new List<string>() {"Konul","Roya","Chinara","Alakbar","Cavid","Anar"};
            return View(users);
        }
  
    }
}

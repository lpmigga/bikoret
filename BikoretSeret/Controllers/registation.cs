using BikoretSeret.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikoretSeret.Controllers
{
    public class registation : Controller
    {
        public IActionResult Index()
        {
            return View("register");
        }
        public IActionResult register(TbUser user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new Models.DbContect())
                {
                    List<TbUser> users = db.Users.Where(n => n.UserName.Equals(user.UserName)).ToList();
                    if (users.Count() == 0)
                    {
                        TempData["message"] = user.UserName + "has been successfully registered";
                        db.Users.Add(user);
                        db.SaveChanges();
                    }
                    else
                    {
                        TempData["message"] = user.UserName + "fail , try again please";
                    }
                }
            }
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(TbUser user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new Models.DbContect())
                {
                    List<TbUser> users = db.Users.Where(n => n.UserName.Equals(user.UserName)&& n.Password.Equals(user.Password)).ToList();
                    if (users.Count==1)
                    {
                        TempData["message"] = user.UserName + "has been successfully loged in";
                        
                    }
                    else
                    {
                        TempData["message"] = user.UserName + "fail , try again please";
                    }
                }
            }
            return View("SignIn");
        }

    }
}

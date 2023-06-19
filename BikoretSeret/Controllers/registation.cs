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
                        TempData["message"] = user.UserName +   "has been successfully loged in";
                        TempData["name"] = user.UserName.ToString();
                        
                    }
                    else
                    {
                        TempData["message"] = user.UserName +    "fail , try again please";
                    }
                }
            }
            return View("SignIn");
        }
        public IActionResult logOut()
        {
            List<Movie> movies;
            List<string> ImageDataUrls = new List<string>();
            using (var db = new Models.DbContect())
            {
                movies = db.movies.ToList();

            }
            foreach (Movie movie in movies)
            {
                string imageBase64Data = Convert.ToBase64String(movie.ImageData);
                string imageDataUrl = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
                ImageDataUrls.Add(imageDataUrl);
            }
            ViewBag.ImageDataUrl = ImageDataUrls;
            ViewBag.movies = movies;
            TempData.Clear();
            return View("Views/Movies/allMovies.cshtml");
        }

    }
}

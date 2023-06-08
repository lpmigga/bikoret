using BikoretSeret.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikoretSeret.Controllers
{
    public class comments : Controller
    {
        public IActionResult toComment(Comments c)
        {
            string userName = TempData["name"].ToString();
            TempData["name"] = userName;
            c.userName = userName;
            using(var db = new DbContect())
            {
                List<Comments> lst = db.comments.Where(n => n.userName.Equals(userName) && n.movieId == c.movieId).ToList();
                if (lst.Count == 0)
                {
                    db.comments.Add(c);
                }
                else
                {
                    lst[0].comment = c.comment;
                }
                db.SaveChanges();
            }
            return View("/Views/Movies/allMovies.cshtml");
        }
        [Route("comments/commentButton/{ID}")]
        public IActionResult commentButton(int ID)
        {
            ViewBag.id = ID;
            return View("toComment");
        }
    }
}

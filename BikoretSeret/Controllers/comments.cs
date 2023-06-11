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
            return View("/Views/Movies/allMovies.cshtml");
        }
        [Route("comments/commentButton/{ID}")]
        public IActionResult commentButton(int ID)
        {
            ViewBag.id = ID;
            return View("toComment");
        }
        [Route("/comments/DeleteComment/{id}")]
        public IActionResult DeleteComment(int id)
        {

            using (var db = new Models.DbContect())
            {
                db.comments.Remove(db.comments.Find(id));
                db.SaveChanges();
                //ViewBag.message = "this movie has been deleate from this site";
            }

            return View("/Views/Home/Index.cshtml");
        }
    }

}

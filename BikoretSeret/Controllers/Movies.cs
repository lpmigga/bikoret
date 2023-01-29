using BikoretSeret.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikoretSeret.Controllers
{
    public class Movies : Controller
    {
        public IActionResult addMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                using (var db = new Models.DbContect())
                {
                    List<Movie> movies = db.movies.Where(n => n.category.Equals(movie.category)&& n.name.Equals(movie.name)).ToList();
                    if (movies.Count == 0)
                    {
                        TempData["message"] = "your movie has been added";
                        db.movies.Add(movie);
                        db.SaveChanges();
                    }
                    else
                    {
                        TempData["message"] = "fail to add your movie";
                    }
                    return View();
                }
            }
            else
            {
                TempData["message"] = "fail to add your movie";
            }
            return View();
        }
        public IActionResult allMovies ()
        {
            return View();
        }
    }
}

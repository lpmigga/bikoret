using BikoretSeret.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
            string userName = TempData["name"].ToString();
            TempData["name"] = userName;
            movie.creatorName = userName;
            if (ModelState.IsValid)
            {
                using (var db = new Models.DbContect())
                {
                    List<Movie> movies = db.movies.Where(n => n.category.Equals(movie.category) && n.name.Equals(movie.name)).ToList();
                    if (movies.Count == 0)
                    {
                        foreach (var file in Request.Form.Files)
                        {
                            MemoryStream ms = new MemoryStream();
                            file.CopyTo(ms);
                            movie.ImageData = ms.ToArray();
                            ms.Close();
                            ms.Dispose();
                        }
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
        //public IActionResult allMovies ()
        //{
        //    if(ModelState.IsValid)
        //    {
        //        using (var db = new Models.DbContect())
        //        {
        //            List<Movie> Movies = db.movies.ToList();
        //            ViewBag.listOfMovies = Movies;
        //            return View();
        //        }

        //    }
        //    return View();
        //    //לפנות לדטא בייס, להביא את כל הסרטים כרשימה, להעביר אותם כוויו באג

        //}
        public IActionResult allMovies()
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
            return View();
        }
        [Route("Movies/moviePage/{ID}")]
   public IActionResult moviePage(int ID)
        {
            if(ModelState.IsValid)
            {
                using (var db = new Models.DbContect())
                {
                    List<Movie> movies = db.movies.Where(M => M.ID == (ID)).ToList();
                      if(movies.Count>0)
                        {
                            ViewBag.movie = movies[0];
                        }
                }
            }
            return View("/Views/Movies/InformationMoviePage.cshtml");
        }
        public IActionResult myMovie()
        {
            string userName = TempData["name"].ToString();
            TempData["name"] = userName;
            if(ModelState.IsValid)
            {
                using (var db = new Models.DbContect())
                {
                    List<Movie> movies = db.movies.Where(M => M.creatorName.Equals(userName)).ToList();
                    List<string> ImageDataUrls = new List<string>();
                    foreach (Movie movie in movies)
                    {
                        string imageBase64Data = Convert.ToBase64String(movie.ImageData);
                        string imageDataUrl = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
                        ImageDataUrls.Add(imageDataUrl);
                    }
                    ViewBag.ImageDataUrl = ImageDataUrls;
                    ViewBag.movies = movies;
                }
            }
            return View("/views/movies/myMovies.cshtml");
        }
    }
    
   
}

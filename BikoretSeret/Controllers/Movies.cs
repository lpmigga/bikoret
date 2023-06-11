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
            bool found = false;
            if (ModelState.IsValid)
            {
                using (var db = new Models.DbContect())
                {
                    List<Movie> movies = db.movies.Where(M => M.ID == (ID)).ToList();
                    List<Comments> comments = db.comments.Where(c => c.movieId.Equals(ID)).ToList();
                    ViewBag.comments = comments;
                    if (movies.Count > 0)
                    {
                        ViewBag.movie = movies[0];
                        if (TempData.ContainsKey("name"))
                        {
                            string userName = TempData["name"].ToString();
                            TempData["name"] = userName;
                            found = movies[0].creatorName.Equals(userName);
                        }
                    }
                }
            }
            ViewBag.found = found;
            return View("/Views/Movies/InformationMoviePage.cshtml");
        }
        public IActionResult myMovie()
        {
            string userName = TempData["name"].ToString();
            TempData["name"] = userName;
            if (ModelState.IsValid)
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

        public IActionResult filter(Movie movie)
        {
            List<Movie> movies;
            List<string> ImageDataUrls = new List<string>();
            using (var db = new Models.DbContect())
            {
                movies = db.movies.Where(m => m.category.Equals(movie.category)).ToList();

            }
            foreach (Movie mov in movies)
            {
                string imageBase64Data = Convert.ToBase64String(mov.ImageData);
                string imageDataUrl = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
                ImageDataUrls.Add(imageDataUrl);
            }
            ViewBag.ImageDataUrl = ImageDataUrls;
            ViewBag.movies = movies;
            return View("/Views/Movies/AllMovies.cshtml");
        }
        public IActionResult myFilter(Movie movie)
        {
            string userName = TempData["name"].ToString();
            TempData["name"] = userName;
            List<Movie> movies;
            List<string> ImageDataUrls = new List<string>();
            using (var db = new Models.DbContect())
            {
                movies = db.movies.Where(m => m.creatorName.Equals(userName) && m.category.Equals(movie.category)).ToList();
                // db.movies.Remove();

            }
            foreach (Movie mov in movies)
            {
                string imageBase64Data = Convert.ToBase64String(mov.ImageData);
                string imageDataUrl = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
                ImageDataUrls.Add(imageDataUrl);
            }
            ViewBag.ImageDataUrl = ImageDataUrls;
            ViewBag.movies = movies;
            return View("/Views/Movies/AllMovies.cshtml");
        }
        [Route("/Movies/delete/{name}")]
        public IActionResult delete(string name)
        {

            using (var db = new Models.DbContect())
            {
                List<Movie> movie = db.movies.Where(m => m.name.Equals(name)).ToList();
                db.movies.Remove(movie[0]);
                db.SaveChanges();
                ViewBag.message = "this movie has been deleate from this site";
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

            // למצוא את הסרט מהדטא בייס
            // למחוק אותו מהדטאנ בייס
            // להחזיר הודעה מתאימה

            return View("/Views/Movies/AllMovies.cshtml");
        }

    }
    
}
    
   


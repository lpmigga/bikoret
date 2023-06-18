using BikoretSeret.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BikoretSeret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
            return View("Views/Movies/allMovies.cshtml");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

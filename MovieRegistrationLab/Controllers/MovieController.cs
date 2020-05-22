using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRegistrationLab.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieRegistrationLab.Controllers
{
    public class MovieController : Controller
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie() { ID=0, Title = "Onward", Genre="Fantasy", Year=2020, Actors="Tom Holland, Chris Pratt", Directors="Dan Scanlon" },
            new Movie() { ID=1, Title = "Toy Story", Genre="Animated", Year=1995, Actors="Tom Hanks, Andrew Stanton", Directors="John Lasseter" },
            new Movie() { ID=2, Title = "Talladega Nights", Genre="Comedy", Year=2006, Actors="Will Ferrell, Adam McKay", Directors="Adam McKay" },
            new Movie() { ID=3, Title = "The Jerk", Genre="Comedy", Year=1979, Actors="Steve Martin, Carl Gottlieb", Directors="Carl Reiner" },
            new Movie() { ID=4, Title = "The Hangover", Genre="Comedy", Year=2009, Actors="Justin Bartha, Zach Galafanakis", Directors="Todd Phillips" },
            new Movie() { ID=5, Title = "Dumb and Dumber", Genre="Comedy", Year=1994, Actors="Jim Carrey, Jeff Daniels", Directors="Peter Farrelly" },
        };

        public static List<Movie> sessionFilledList = new List<Movie>();
        // GET: /<controller>/
        public IActionResult MovieList()
        {
            return View();
        }
        public IActionResult AddMovie()
        {
            Movie m = movies.Where(x => x.ID.Equals(int.Parse(Request.Query["ID"]))).FirstOrDefault();
            return View(m);
        }
        public IActionResult Cart()
        {
            return View();
        }
    }
}

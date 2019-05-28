using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie_Factory.Data;


namespace Movie_Factory.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _Context;
        public MoviesController (ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public IActionResult Index()
        {
            var list = _Context.Movies.ToList();
            return View(list);
        }
        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound() ;
            }
            var movie = _Context.Movies.FirstOrDefault(m => m.Id == id);
            if (movie==null)
            {
                return NotFound();
            }
            return View(movie);
        }
    }
}
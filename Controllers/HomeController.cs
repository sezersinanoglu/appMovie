using appMovie.Data;
using appMovie.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace appMovie.Controllers
{
    public class HomeController:Controller
    {
       public IActionResult Index(int? id)
       {

            var movies = ProductRepository.Movies;
            if (id!=null)
            {
                movies = movies.Where(x=>x.CategoryId == id).ToList();
            }
            return View(movies);
       }

        public IActionResult Details(int id)
        {
            //ProductCategoryModel model = new ProductCategoryModel();
            //model.Categories = CategoryRepository.Categories;
            //model.Movie = ProductRepository.GetById(id);
            return View(ProductRepository.GetById(id));
        }

        public IActionResult Contact()
       {
         
         return View();
       }
    }
}
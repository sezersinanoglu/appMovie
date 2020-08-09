using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appMovie.Models
{
    public class ProductCategoryModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}

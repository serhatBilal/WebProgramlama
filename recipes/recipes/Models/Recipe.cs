using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipes.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FoodImage { get; set; }
        public string Materials { get; set; }
        public string Details { get; set; }
        public ICollection<Comment> Comment { get; set; }
        
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipes.Models
{
    public class RecipeComment
    {
        public IEnumerable<Recipe> Value1 { get; set; }
        public IEnumerable<Comment> Value2 { get; set; }


    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace recipes.Models
{
    public class MainPage
    {
        public int Id { get; set; }
        public int CategoryId { get; set;}
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}

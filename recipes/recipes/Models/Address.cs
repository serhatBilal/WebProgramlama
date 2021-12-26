using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipes.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LongAdress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }
}
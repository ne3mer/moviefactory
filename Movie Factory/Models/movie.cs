using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFactory.Models
{
    public class Movie
{
        public int Id { get; set; }
        [Required]
        public String Title { get; set; }
        [Required]
        public string Genre { get; set; }
        public int Year { get; set; }
        [Required]
        public String Country { get; set; }
        public String Director { get; set; }



    }
}

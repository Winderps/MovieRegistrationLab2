using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistrationLab.Models
{
    public class Movie
    {
        [Required(ErrorMessage = "Please enter an ID")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        [StringLength(50, ErrorMessage = "Please enter a maximum of 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a year of release")]
        [Range(1880, 2020)]
        public ushort Year { get; set; }

        [Required(ErrorMessage = "Please select a genre")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Please enter at least one actor")]
        public string Actors { get; set; }

        [Required(ErrorMessage = "Please enter at least one director")]
        public string Directors { get; set; }
    }
}

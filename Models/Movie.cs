using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFiveCRUD.Models
{
    public class Movie
    {
        // auto incerement beacuse it's int
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string Title { get; set; }

        public int Year { get; set; }

        public double Rate { get; set; }

        [Required, MaxLength(2500)]
        public string Storeline { get; set; }

        [Required]
        public byte[] Poster { get; set; }

        // must be the same data type
        public byte GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}

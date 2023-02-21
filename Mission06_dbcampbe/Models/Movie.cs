using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_dbcampbe.Models
{
    public class Movie
    {
        //Set attributes for the Movie Model

        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }

        //These ones are not set as required
        //Have Edited as True/False Boolean
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)] //Set notes max length to 25 characters
        public string Notes { get; set; }

    }
}

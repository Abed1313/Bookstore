using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is Required")]
        [StringLength(40, MinimumLength = 4)]
        public string Author { get; set; }

        [Required(ErrorMessage = "Price is Required")]
        [Range(10, 100, ErrorMessage = "Price must be between 10 and 100")]
        public Double Price { get; set; }

        [Required(ErrorMessage = "Genre is Required")]
        public string Genre { get; set; }
    }
}

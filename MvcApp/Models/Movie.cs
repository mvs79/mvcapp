using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60,MinimumLength=3)]
        public string Title { get; set; }
        [Display(Name="ReleaseDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyy-MM-dd}",ApplyFormatInEditMode=true)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Range(1,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }


    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}
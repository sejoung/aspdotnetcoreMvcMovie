using MvcMovie.Constants;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        
        [Display(Name = "Release Date"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        
        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$"),Required,StringLength(30)]
        public string Genre { get; set; }
        
        [Column(TypeName = "decimal(18,2)"), DataType(DataType.Currency), Range(1, 100)]
        public decimal Price { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public MovieRating Rating { get; set; }

    }
}

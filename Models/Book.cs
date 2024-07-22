using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string BookTitle { get; set; }

        [MaxLength(100)]
        public string BookDescription { get; set; }

        public string BookLanguage { get; set; }

        [Required,
        MaxLength(13)]
        public string BookISBN { get; set; }

        [Required,
        DataType(DataType.Date),
        Display(Name = "Date Published")]
        public DateTime BookDatePublished { get; set; }

        [Required,
        DataType(DataType.Currency)]
        public int BookPrice { get; set; }

        [Required]
        public string BookAuthor { get; set; }

        [Display(Name = "Image URL")]
        public string BookImageUrl { get; set; }
    }
}
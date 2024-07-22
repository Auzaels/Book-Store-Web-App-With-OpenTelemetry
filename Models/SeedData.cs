using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new BookStoreContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreContext>>());
            if (context.Books.Any())    // Veritabanının herhangi bir kitap içerip içermediğini kontrol eder
            {
                return;     // Veritabanı halihazırda kitapları içerir
            }

            context.Books.AddRange(
                new Book
                {
                    BookTitle = "Bröderna Lejonhjärta",
                    BookLanguage = "Swedish",
                    BookISBN = "9789129688313",
                    BookDatePublished = DateTime.Parse("2013-9-26"),
                    BookPrice = 139,
                    BookAuthor = "Astrid Lindgren",
                    BookImageUrl = "/images/lejonhjärta.jpg"
                },

                new Book
                {
                    BookTitle = "The Fellowship of the Ring",
                    BookLanguage = "English",
                    BookISBN = "9780261102354",
                    BookDatePublished = DateTime.Parse("1991-7-4"),
                    BookPrice = 100,
                    BookAuthor = "J. R. R. Tolkien",
                    BookImageUrl = "/images/lotr.jpg"
                },

                new Book
                {
                    BookTitle = "Mystic River",
                    BookLanguage = "English",
                    BookISBN = "9780062068408",
                    BookDatePublished = DateTime.Parse("2011-6-1"),
                    BookPrice = 91,
                    BookAuthor = "Dennis Lehane",
                    BookImageUrl = "/images/mystic-river.jpg"
                },

                new Book
                {
                    BookTitle = "Of Mice and Men",
                    BookLanguage = "English",
                    BookISBN = "9780062068408",
                    BookDatePublished = DateTime.Parse("1994-1-2"),
                    BookPrice = 166,
                    BookAuthor = "John Steinbeck",
                    BookImageUrl = "/images/of-mice-and-men.jpg"
                },

                new Book
                {
                    BookTitle = "The Old Man and the Sea",
                    BookLanguage = "English",
                    BookISBN = "9780062068408",
                    BookDatePublished = DateTime.Parse("1994-8-18"),
                    BookPrice = 84,
                    BookAuthor = "Ernest Hemingway",
                    BookImageUrl = "/images/old-man-and-the-sea.jpg"
                },

                new Book
                {
                    BookTitle = "The Road",
                    BookLanguage = "English",
                    BookISBN = "9780307386458",
                    BookDatePublished = DateTime.Parse("2007-5-1"),
                    BookPrice = 95,
                    BookAuthor = "Cormac McCarthy",
                    BookImageUrl = "/images/the-road.jpg"
                }
            );

            context.SaveChanges();
        }
    }
}

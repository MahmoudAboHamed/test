using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstWebApp.Models;

namespace FirstWebApp.Data
{
    public class ComicBookRepository
    {
        public static ComicBook[] _comicBooks = new ComicBook[]
        {
             new ComicBook()
              {
                 Id = 1,
                    SeriesTitle = "The Amazing Spider-Man",
                    IssueNumber = 700,
                    DescriptionHtml = "<p>The best Book in World <strong>HaHaHaHa</strong></p>",
                    Artists = new Artist[]
                    {
                        new Artist() {name = "ana", Role = "script"},
                        new Artist() {name = "ana", Role = "Pencils"},
                        new Artist() {name = "ana", Role = "Inks"}
                    },
                    Favorite = false
             },
            new ComicBook()
             {
                Id =2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p>The best Book in World <strong>HaHaHaHa</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {name = "ana", Role = "script"},
                    new Artist() {name = "ana", Role = "Pencils"},
                    new Artist() {name = "ana", Role = "Inks"}
                },
                Favorite = false
             },
           new ComicBook()
            {
               Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p>The best Book in World <strong>HaHaHaHa</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() {name = "ana", Role = "script"},
                    new Artist() {name = "ana", Role = "Pencils"},
                    new Artist() {name = "ana", Role = "Inks"}
               },
               Favorite = false
            }
        };

        public ComicBook [] GetComicBooks()
        {
            return _comicBooks;
        }

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;
                    break;
                }
            }

            return comicBookToReturn;
        }
    }
}
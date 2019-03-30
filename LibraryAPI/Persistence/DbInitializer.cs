using LibraryAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Persistence
{
    public static class DbInitializer
    {
        public static void Initialize(LibraryContext context)
        {
            context.Database.EnsureCreated();

            // Look for any books.
            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }

            var books = new Book[]
            {
            new Book{Title="The Lord of the Rings"},
            new Book{Title="The Coordinates of Loss"},
            new Book{Title="The Keeper of Lost Things"},
            new Book{Title="Close to Home"},
            new Book{Title="Sweet Little Lies"},
            new Book{Title="Beneath a Scarlet Sky"},
            new Book{Title="A Gentleman in Moscow"},
            new Book{Title="The Girl in the Corner"},
            new Book{Title="The Beekeeper's Promise"},
            new Book{Title="In The Name of the Family"},
            new Book{Title="One Day in December"},
            new Book{Title="How to Play Rock, Paper and Scissors"},
            new Book{Title="CRUD .Net Core for Dummies"},
            new Book{Title="A Funeral in Fiesole"},
            new Book{Title="The Parisians"},
            new Book{Title="The Shadow Queen"},
            new Book{Title="How to be Happy"},
            new Book{Title="Circe"},
            new Book{Title="Stand By Me"},
            new Book{Title="Calling Major Tom"}
            };
            foreach (Book b in books)
            {
                context.Books.Add(b);
            }
            context.SaveChanges();
        }
    }
}

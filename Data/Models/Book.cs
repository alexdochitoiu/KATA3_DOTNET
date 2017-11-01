using System;

namespace Data.Models
{
    public class Book
    {
        public Book()
        { }

        public Guid Id { get; private set; }

        public string Title { get; private set; }

        public int Year { get; private set; }

        public int Price { get; private set; }

        public string Genre { get; private set; }

        public static Book Create(string title, int year, int price, string genre)
        {
            Book instance = new Book { Id = new Guid() };
            instance.Update(title, year, price, genre);
            return instance;
        }

        public void Update(string title, int year, int price, string genre)
        {
            Title = title;
            Year = year;
            Price = price;
            Genre = genre;
        }
    }
}

using System;

namespace Kata3.DTOs
{
    public class UpdateBookDTO
    {
        public Guid Id { get; private set; }

        public string Title { get; private set; }

        public int Year { get; private set; }

        public int Price { get; private set; }

        public string Genre { get; private set; }
    }
}

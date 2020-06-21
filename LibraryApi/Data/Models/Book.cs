using System;

namespace LibraryApi.Data.Models
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public int? Year { get; set; }

        public int Quantity { get; set; }

        public int QuantityAvailable { get; set; }
    }
}

using System;

namespace LibraryApi.Data.Models
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
    }
}

﻿namespace EFE_Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int AuthorId { get; set; }

        public virtual Author? Author { get; set; }

    }
}
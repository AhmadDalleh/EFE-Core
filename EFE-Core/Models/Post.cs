﻿namespace EFE_Core.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public bool IsDeleted { get; set; }
        public int? BlogId { get; set; }
        public virtual Blog? Blog { get; set; }
    }
}
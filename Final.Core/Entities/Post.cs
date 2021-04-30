using System;

namespace Final.Core.Entities
{
    public class Post
    {
        public int PostId { get; set;}

        public int IdUser { get; set; }

        public DateTime Date { get; set; }

        public string Description  { get; set; }

        public string Image { get; set; }

    }
}

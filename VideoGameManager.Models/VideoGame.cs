﻿namespace VideoGameManager.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Developer { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }
    }
}

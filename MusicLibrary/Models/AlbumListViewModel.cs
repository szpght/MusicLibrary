﻿namespace MusicLibrary.Models
{
    public class AlbumListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
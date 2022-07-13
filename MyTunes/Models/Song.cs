using System;
using System.Collections.Generic;

namespace MyTunes.Models
{
    public partial class Song
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int? GenreId { get; set; }
        public int? ArtistId { get; set; }

        public virtual Artist? Artist { get; set; }
        public virtual Genre? Genre { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Data.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Tag { get; set; } // Genre
        public int GameId { get; set; }
        public Game Game { get; set; }

    }
}

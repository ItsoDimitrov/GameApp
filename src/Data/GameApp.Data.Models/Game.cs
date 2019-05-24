using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Data.Models
{
    public class Game
    {
        public Game()
        {
            this.Genres = new HashSet<Genre>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public ICollection<Genre> Genres { get; set; }
        

    }
}

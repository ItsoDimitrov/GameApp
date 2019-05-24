using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Data.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}

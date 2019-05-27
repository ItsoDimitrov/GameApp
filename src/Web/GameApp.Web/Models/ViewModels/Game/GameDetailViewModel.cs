using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Data.Models;

namespace GameApp.Web.Models.ViewModels.Game    
{
    public class GameDetailViewModel
    {
        public int Id { get; set; }
        public string GameTitle { get; set; }
        public string GameDescription { get; set; }
        public string PosterUrl { get; set; }
        public DateTime? GameReleaseDate { get; set; }
        public IQueryable<Genre> Genres { get; set; } 
        public IQueryable<Image> Images { get; set; } /* TODO: Game Images should be displayed ( not hardcoded) */ 

    }
}

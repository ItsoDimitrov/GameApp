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
        public DateTime? GameReleaseDate { get; set; }
        //public ICollection<Genre> Genres { get; set; } TODO: Game Tags should be displayed too
        //public GameImageDetailViewModel Images { get; set; }

    }
}

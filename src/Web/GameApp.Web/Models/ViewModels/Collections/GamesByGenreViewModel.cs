using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Web.Models.ViewModels.Game;

namespace GameApp.Web.Models.ViewModels.Collections
{
    public class GamesByGenreViewModel
    {
        public IEnumerable<GameByGenreViewModel> GamesByGenre { get; set; }
    }
}

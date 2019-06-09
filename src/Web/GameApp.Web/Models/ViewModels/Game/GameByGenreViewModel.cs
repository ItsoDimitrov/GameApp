using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameApp.Web.Models.ViewModels.Game
{
    public class GameByGenreViewModel
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public string GamePoster { get; set; }
    }
}

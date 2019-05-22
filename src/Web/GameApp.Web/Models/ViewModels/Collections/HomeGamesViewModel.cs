using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Web.Models.ViewModels.Home;

namespace GameApp.Web.Models.ViewModels.Collections
{
    public class HomeGamesViewModel
    {
       
        public IEnumerable<HomeGameViewModel> Games { get; set; }
    }
}

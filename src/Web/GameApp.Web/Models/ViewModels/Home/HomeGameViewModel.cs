using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Data.Models;

namespace GameApp.Web.Models.ViewModels.Home
{
    public class HomeGameViewModel
    {
        // View Model for games on index page
        public int Id { get; set; }
        public string GameName { get; set; }

        public string GameDescription { get; set; }
        //public ICollection<Genre> Genres { get; set; } // If want Genres to be displayed !
       
    }
}

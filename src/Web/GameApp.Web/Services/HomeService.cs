using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Data.Models;
using GameApp.Web.Models;
using GameApp.Web.Models.ViewModels.Collections;
using GameApp.Web.Models.ViewModels.Home;
using GameApp.Web.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GameApp.Web.Services
{
    public class HomeService : BaseService, IHomeService
    {
        private const int NEEDED_GAMES_ON_INDEX_VIEW = 4;
        public HomeService(GameAppContext context, UserManager<GameAppUser> userManager) : base(context, userManager)
        {
        }

        public HomeGamesViewModel GetIndexGames()
        {
            var games = this._context.Games.Take(NEEDED_GAMES_ON_INDEX_VIEW)
                .Select(g => new HomeGameViewModel
                {
                    Id = g.Id,
                    GameName = g.Name,
                    GameDescription = g.Description,
                    GamePoster = g.PosterURL,
                    
                    
                });
             var indexGamesViewModel = new HomeGamesViewModel
             {
                 Games = games
             };

            return indexGamesViewModel;
        }
    }
}

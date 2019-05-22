using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Data.Models;
using GameApp.Web.Models.ViewModels.Collections;
using GameApp.Web.Models.ViewModels.Home;

namespace GameApp.Web.Services.Interfaces
{
    public interface IHomeService
    {
         HomeGamesViewModel GetIndexGames();
    }
}

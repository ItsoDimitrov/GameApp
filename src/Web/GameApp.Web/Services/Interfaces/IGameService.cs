using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Web.Models.ViewModels.Game;

namespace GameApp.Web.Services.Interfaces
{
    public interface IGameService
    {
        GameDetailViewModel GetGameDetails(int id);
    }
}

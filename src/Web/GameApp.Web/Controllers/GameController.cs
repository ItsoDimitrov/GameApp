using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GameApp.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        public IActionResult Details(int id)
        {
            var gameDetailsViewModel = this._gameService.GetGameDetails(id);
            return View(gameDetailsViewModel);
        }

    }
}
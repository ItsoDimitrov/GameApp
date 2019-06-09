using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Web.Models;
using GameApp.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GameApp.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _gameService;
        protected  GameAppContext _context;
        public GameController(IGameService gameService, GameAppContext context)
        {
            _gameService = gameService;
            _context = context;
        }

        public IActionResult Details(int id)
        {
            var gameDetailsViewModel = this._gameService.GetGameDetails(id);
            return View(gameDetailsViewModel);
        }

        public IActionResult GamesByGenre(string genre)
        {
            var gamesByGenreViewModel = this._gameService.GetGamesByGenre(genre);
            return View(gamesByGenreViewModel);
        }

    }
}
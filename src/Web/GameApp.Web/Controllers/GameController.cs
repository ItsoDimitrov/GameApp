using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Web.Models;
using GameApp.Web.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        [Authorize]
        public IActionResult Details(int id)
        {
            var gameDetailsViewModel = this._gameService.GetGameDetails(id);
            return View(gameDetailsViewModel);
        }
        [Authorize]
        public IActionResult GamesByGenre(string genre)
        {
            var gamesByGenreViewModel = this._gameService.GetGamesByGenre(genre);
            return View(gamesByGenreViewModel);
        }

    }
}
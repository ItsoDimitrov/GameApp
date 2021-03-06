﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using GameApp.Data.Models;
using GameApp.Web.Models;
using GameApp.Web.Models.ViewModels.Collections;
using GameApp.Web.Models.ViewModels.Game;
using GameApp.Web.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GameApp.Web.Services
{
    public class GameService : BaseService, IGameService
    {
        public GameService(GameAppContext context, UserManager<GameAppUser> userManager) : base(context, userManager)
        {
        }

        public GameDetailViewModel GetGameDetails(int id)
        {
            var game = this._context.Games.FirstOrDefault(g => g.Id == id);
            if (game == null)
            {
                return null; // TODO : not found  message to the user should be returned 
            }


            var gameDetailsViewModel = new GameDetailViewModel
            {
                Id = game.Id,
                GameDescription = game.Description,
                GameReleaseDate = game.ReleaseDate,
                GameTitle = game.Name,
                PosterUrl = game.PosterURL,
                Genres = this._context.Genres.Where(g => g.GameId == game.Id),
                Images = this._context.Images.Where(i => i.GameId == game.Id)
            };
           


            return gameDetailsViewModel;

        }

        public GamesByGenreViewModel GetGamesByGenre(string genre)
        {
            
            var gamesByGivenGenre = this._context.Genres.Where(c => c.Tag == genre).Select(g => new GameByGenreViewModel
            {
                Id = g.GameId,
                GameDescription = g.Game.Description,
                GameName = g.Game.Name,
                GamePoster = g.Game.PosterURL
            });

            var gamesByGivenGenreViewModel = new GamesByGenreViewModel
            {
                GamesByGenre = gamesByGivenGenre
            };

            return gamesByGivenGenreViewModel;
        }
    }
}

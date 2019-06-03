using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Data.Models;
using GameApp.Web.Models;
using GameApp.Web.Models.ViewModels.Category;
using GameApp.Web.Models.ViewModels.Collections;
using GameApp.Web.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using MoreLinq;

namespace GameApp.Web.Services
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(GameAppContext context, UserManager<GameAppUser> userManager) : base(context, userManager)
        {
        }

        public GamesCategoriesViewModel AllCategories()
        {
            
            var categories = this._context.Genres.Select(c => new GameCategoryViewModel
            {
                Tag = c.Tag,
                Id = c.Id,
                GameId = c.GameId,
            }).AsEnumerable().DistinctBy(c => c.Tag);
            
            var categoryViewModel = new GamesCategoriesViewModel
            {
                Categories = categories
            };
            return categoryViewModel;
        }
    }
}

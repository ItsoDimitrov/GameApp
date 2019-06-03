using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GameApp.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Categories()
        {
            var categoriesViewModel = this._categoryService.AllCategories();
            return View(categoriesViewModel);
        }
    }
}
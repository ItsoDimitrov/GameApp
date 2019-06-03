using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Web.Models.ViewModels.Collections;

namespace GameApp.Web.Services.Interfaces
{
    public interface ICategoryService
    {
        GamesCategoriesViewModel AllCategories();
    }
}

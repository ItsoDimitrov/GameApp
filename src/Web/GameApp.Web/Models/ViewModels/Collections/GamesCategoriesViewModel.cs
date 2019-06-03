using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Web.Models.ViewModels.Category;

namespace GameApp.Web.Models.ViewModels.Collections
{
    public class GamesCategoriesViewModel
    {
        public IEnumerable<GameCategoryViewModel> Categories { get; set; }
    }
}

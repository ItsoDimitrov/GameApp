using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameApp.Web.Models.ViewModels.Category
{
    public class GameCategoryViewModel
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public int GameId { get; set; }
        //public int Count { get; set; }
    }
}

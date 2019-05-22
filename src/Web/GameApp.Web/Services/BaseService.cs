using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Data.Models;
using GameApp.Web.Models;
using Microsoft.AspNetCore.Identity;

namespace GameApp.Web.Services
{
    public class BaseService
    {

        protected GameAppContext _context { get; }

        protected UserManager<GameAppUser> _userManager { get; }
        protected BaseService(GameAppContext context, UserManager<GameAppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
    }
}

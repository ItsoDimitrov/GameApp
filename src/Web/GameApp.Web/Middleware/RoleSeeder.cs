using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;


namespace GameApp.Web.Middleware
{
    public class RoleSeeder
    {
        //private static UserManager<GameAppUser> _userManager;
        private static SignInManager<GameAppUser> _signInManager;
        private static RoleManager<IdentityRole> _roleManager;

        public RoleSeeder(/*UserManager<GameAppUser> userManager*/ SignInManager<GameAppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            //_userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public static void Seed(IServiceProvider provider, UserManager<GameAppUser> _userManager)
        {

            var roleManager = provider.GetService<RoleManager<IdentityRole>>();
            var adminRoleExists = roleManager.RoleExistsAsync("Admin").Result;
            if (!adminRoleExists)
            {
                roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            }
            SeedAdminUser(_userManager);
            

        }

        public static void SeedAdminUser(UserManager<GameAppUser> _userManager)
        {
            var password = "123456admin";
            var adminUser = new GameAppUser
            {
                UserName = "testadmin@gmail.com",
                Email = "testadmin@gmail.com",
                
            };

            var result = _userManager.CreateAsync(adminUser, password).GetAwaiter().GetResult();

            if (result.Succeeded)
            {
                 _userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }



    }
}

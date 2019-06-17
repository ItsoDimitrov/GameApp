using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using GameApp.Data.Models;
using GameApp.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GameApp.Sandbox
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"{typeof(Program).Namespace} ({string.Join(" ", args)}) starts working...");
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider(true);

            using (var serviceScope = serviceProvider.CreateScope())
            {
                serviceProvider = serviceScope.ServiceProvider;
                SandboxCode(serviceProvider);
            }

        }

        private static void SandboxCode(IServiceProvider serviceProvider)
        {
            //var db = serviceProvider.GetService<GameAppContext>();           
            //var game = db.Games.FirstOrDefault(g => g.Id == 9);
            //var gameGenres = db.Genres.Where(g => g.GameId == game.Id);
            //foreach (var gameGenre in gameGenres)
            //{
            //    Console.WriteLine(gameGenre);
            //}          
            //var game = new Game
            //{
            //    Name = "Interstellar Transport Company",
            //    ReleaseDate = DateTime.Parse("2019/06/24"),
            //    Description = "Build a galactic transportation empire and supply humanity with everything it needs to colonize the stars. In this sci-fi logistics simulator, grow your company from a local transport agency into an interstellar logistics behemoth! Singleplayer, vs AI, and online multiplayer.",
            //    Genres = new List<Genre>
            //    {
            //        new Genre
            //        {
            //            Tag = "Space"
            //        },
            //        new Genre
            //        {
            //            Tag = "Simulation"
            //        }
            //    },
            //    Images = new List<Image>
            //    {
            //        new Image
            //        {
            //            URL = "https://steamcdn-a.akamaihd.net/steam/apps/573490/ss_b130c723a83ce213950f2f1a0c1d49e2d877f668.600x338.jpg?t=1558702611"
            //        },
            //        new Image
            //        {
            //            URL = "https://steamcdn-a.akamaihd.net/steam/apps/573490/ss_b3ddbe3d37417d5c9138b8a048348374f7126167.600x338.jpg?t=1558702611"
            //        },
            //        new Image
            //        {
            //            URL = "https://steamcdn-a.akamaihd.net/steam/apps/573490/ss_f7f06ce33196b37faa2fbfd5a014c6ee58098773.600x338.jpg?t=1558702611"
            //        }
            //    }
            //};
            //db.Games.Add(game);
            //db.SaveChanges();
            //var game = new Game
            //{
            //    Name = "Black Survival",
            //    Description = "Black Survival aims to be a fair and competitive game without any Pay to Win elements! Simple control, but complex gameplay offer to players!",
            //    Genres = new List<Genre>
            //    {
            //        new Genre
            //        {
            //            Tag = "Survival",

            //        },
            //        new Genre
            //        {
            //            Tag = "Anime"
            //        }
            //    }



            //};
            //db.Games.Add(game);
            //db.SaveChanges();


        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables()
                .Build();

            services.AddDbContext<GameAppContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

        }
    }
}

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
            var db = serviceProvider.GetService<GameAppContext>();
            var game = new Game
            {
                Name = "Black Survival",
                Description = "Black Survival aims to be a fair and competitive game without any Pay to Win elements! Simple control, but complex gameplay offer to players!",
                Genres = new List<Genre>
                {
                    new Genre
                    {
                        Tag = "Survival",
                        
                    },
                    new Genre
                    {
                        Tag = "Anime"
                    }
                }



            };
            db.Games.Add(game);
            db.SaveChanges();


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

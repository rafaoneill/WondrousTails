using Insight.Database;
using AetherCurrents.Database.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using SaintCoinach;
using WolvesDen.Profiles;

namespace WolvesDen
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            var startup = new Startup();
            var provider = startup.ConfigureServices(services);
            
            provider.GetService<ILoggerFactory>().AddConsole(LogLevel.None);
            var logger = provider.GetService<ILoggerFactory>().CreateLogger<GameData>();
            
            var realm = provider.GetService<ARealmReversed>();
            var db = provider.GetService<IDbConnection>();
            var context = provider.GetService<AetherCurrentsContext>();
            context.ChangeTracker.AutoDetectChangesEnabled = false;
            
            var gameData = new GameData(context, realm);
            gameData.BeginTransfer();
        }
    }
}
using AetherCurrents.Database.Entities;
using Insight.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using SaintCoinach;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using WolvesDen.Profiles;

namespace WolvesDen
{
    /// <summary>
    /// The application program class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main method for the application.
        /// </summary>
        public static void Main()
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
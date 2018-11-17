using AetherCurrents.Database.Entities;
using Insight.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SaintCoinach;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace WolvesDen
{
    public class Startup
    {
        IConfigurationRoot Configuration { get; }

        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            
            Configuration = builder.Build();
        }

        public ServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();

            var connectionString = Configuration.GetConnectionString("GubalLibrary");
            var gameDirectory = Configuration["GameDirectory"].ToString();

            AutoMapperConfig.RegisterMappings();
            SqlInsightDbProvider.RegisterProvider();

            services.AddDbContext<AetherCurrentsContext>(opts => opts.UseSqlServer(connectionString));
            services.AddTransient<IDbConnection>(s => new SqlConnection(connectionString));
            services.AddTransient<ARealmReversed>(s => new ARealmReversed(gameDirectory, SaintCoinach.Ex.Language.English));

            return services.BuildServiceProvider();
        }
    }
}
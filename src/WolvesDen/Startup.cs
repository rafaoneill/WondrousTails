using AetherCurrents.Database.Entities;
using Insight.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaintCoinach;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;

namespace WolvesDen
{
    /// <summary>
    /// The application startup class.
    /// </summary>
    public class Startup
    {
        private readonly IConfigurationRoot configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        public Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            configuration = builder.Build();
        }

        /// <summary>
        /// Configure services to be used in the application.
        /// </summary>
        /// <param name="services">The collection of services.</param>
        /// <returns>The service provider.</returns>
        public ServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();

            var connectionString = configuration.GetConnectionString("GubalLibrary");
            var gameDirectory = configuration["GameDirectory"].ToString(CultureInfo.CurrentCulture);

            AutoMapperConfig.RegisterMappings();
            SqlInsightDbProvider.RegisterProvider();

            services.AddDbContext<AetherCurrentsContext>(opts => opts.UseSqlServer(connectionString));
            services.AddTransient<IDbConnection>(s => new SqlConnection(connectionString));
            services.AddTransient<ARealmReversed>(s => new ARealmReversed(gameDirectory, SaintCoinach.Ex.Language.English));

            return services.BuildServiceProvider();
        }
    }
}
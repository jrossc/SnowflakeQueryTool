
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POCSnowflakeIndexServer.Controllers;
using POCSnowflakeIndexServer.DAL;
using POCSnowflakeIndexServer.Helpers;
using POCSnowflakeIndexServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POCSnowflakeIndexServer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, service) =>
            {
                ConfigureServices(context.Configuration, service);
            })
            .Build();

            var services = host.Services;
            var mainForm = services.GetRequiredService<ConnectForm>();

            Application.Run(mainForm);
 
        }

        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            // ...
            services.AddHostedService<SnowflakeDataAccess>();
            services.AddScoped<ISpecificQueryService, SpecificQueryController>();
            services.AddScoped<IQueryAsParameterService, QueryAsParameterController>();
            services.AddScoped<IJSONConverterService, JSONConverterHelper>();
            services.AddTransient<SimpleQueryForm>();
            services.AddTransient<SimpleAggregationForm>();
            services.AddTransient<XAxisAggregationForm>();
            services.AddTransient<XYAxisAggregationForm>();
            services.AddTransient<SchemaListForm>();
            services.AddTransient<XYAxisAggregationWithFilterForm>();
            services.AddSingleton<ConnectForm>();
        }
    }
}

using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorMovies.Client.Helpers;

namespace BlazorMovies.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            ConfigurationServices(builder.Services);

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
        private static void ConfigurationServices(IServiceCollection services)
        {
            services.AddOptions(); //Authorization System
            services.AddSingleton<SingletonService>();
            services.AddTransient<TransientService>();
            services.AddTransient<IRepository,RepositoryMemory>();
        }
    }
}

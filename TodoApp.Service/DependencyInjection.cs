using Microsoft.Extensions.DependencyInjection;
using TodoApp.Service.Classes;

namespace TodoApp.Service
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {

            services.AddSingleton<TaskService>();

            return services;
        }
    }
}

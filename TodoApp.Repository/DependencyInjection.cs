using Microsoft.Extensions.DependencyInjection;
using TodoApp.Repository.Classes;

namespace TodoApp.Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {

            services.AddSingleton<TaskRepository>();

            return services;
        }
    }
}

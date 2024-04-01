using Microsoft.Extensions.DependencyInjection;

namespace UI.ViewModels
{
    public static class Extensions
    {
        public static IServiceCollection AddViewModels(this IServiceCollection services)
        {
            services.AddScoped<HomeViewModel>();
            return services;
        }
    }
}

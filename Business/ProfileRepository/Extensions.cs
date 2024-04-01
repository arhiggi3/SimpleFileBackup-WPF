using Microsoft.Extensions.DependencyInjection;

namespace Business.ProfileRepository
{
    internal static class Extensions
    {
        public static IServiceCollection AddProfileRepository(this IServiceCollection services)
        {
            services.AddProfileRepository();
            return services;
        }
    }
}

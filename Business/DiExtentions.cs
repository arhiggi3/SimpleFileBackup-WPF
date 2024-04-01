using Business.ProfileRepository;
using Data;
using Microsoft.Extensions.DependencyInjection;

namespace Business
{
    public static class DiExtentions
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IProfileContext,ProfileContext>();
            services.AddScoped<IProfileRepositoryService, ProfileRepositoryService>();
            return services;
        } 
    }
}

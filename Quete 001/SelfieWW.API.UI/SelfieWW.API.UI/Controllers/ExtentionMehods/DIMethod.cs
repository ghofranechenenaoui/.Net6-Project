using SelfieAwwokieCore.Selfies.Domain;
using SelfieAwwokieCore.Selfies.Infrastructure.Repositories;

namespace SelfieWW.API.UI.Controllers.ExtentionMehods
{
    public static class DIMethod
        
        //preparation des injections 
    {
        public static void AddInjection(this IServiceCollection services)
        {
            services.AddScoped<ISelfieRepository, DefaultSelfieRepositories>();
        }
    }
}

using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Singleton
{
    public sealed class SingletonExtension
    {
        public static void UseSingletion(this IServiceCollection services)
        {
            services.AddSingleton<ILog, DatabaseLog>();
        }
    }
}
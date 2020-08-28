using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns
{
    public sealed class DependencyResolver
    {
        private ServiceProvider _currentServiceProvider;
        private static ServiceProvider _serviceProvider;

        public DependencyResolver( ServiceProvider currentServiceProvider)
        {
            _currentServiceProvider = currentServiceProvider;
        }

        public static DependencyResolver Current
        {
            get
            {
                return new DependencyResolver(
                    _serviceProvider);
            }
        }
    }
}

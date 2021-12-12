using System.Collections.Generic;

namespace DependencyInjectionLibrary
{
    public class ServiceCollection
    {
        private List<ServiceMetadata> _servicesMetadatas = new List<ServiceMetadata>();

        //Singleton
        public void RegisterSingleton<TService>()
        {
            _servicesMetadatas.Add(new ServiceMetadata(typeof(TService), ServiceLifetime.Singleton));
        }

        public void RegisterSingleton<TService>(TService implementation)
        {
            _servicesMetadatas.Add(new ServiceMetadata(implementation, ServiceLifetime.Singleton));
        }

        public void RegisterSingleton<TService, TImplementation>() where TImplementation : TService
        {
            _servicesMetadatas.Add(new ServiceMetadata(typeof(TService), typeof(TImplementation), ServiceLifetime.Singleton));
        }

        //Transient
        public void RegisterTransient<TService>()
        {
            _servicesMetadatas.Add(new ServiceMetadata(typeof(TService), ServiceLifetime.Transient));
        }

        public void RegisterTransient<TService, TImplementation>() where TImplementation : TService
        {
            _servicesMetadatas.Add(new ServiceMetadata(typeof(TService), typeof(TImplementation), ServiceLifetime.Transient));
        }

        public ServiceAccessUnity BuildContainer()
        {
            return new ServiceAccessUnity(_servicesMetadatas);
        }
    }
}

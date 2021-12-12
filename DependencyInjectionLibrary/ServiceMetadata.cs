using System;

namespace DependencyInjectionLibrary
{
    public class ServiceMetadata
    {
        public object Implementation { get; internal set; }
        public Type ServiceType { get; }
        public Type ImplementationType { get; }
        public ServiceLifetime Lifetime { get; }

        public ServiceMetadata(object implementation, ServiceLifetime serviceLifetime)
        {
            Implementation = implementation;
            ServiceType = implementation.GetType();
            Lifetime = serviceLifetime;
        }

        public ServiceMetadata(Type serviceType, ServiceLifetime serviceLifetime)
        {
            ServiceType = serviceType;
            Lifetime = serviceLifetime;
        }

        public ServiceMetadata(Type serviceType, Type implementationType, ServiceLifetime serviceLifetime)
        {
            ServiceType = serviceType;
            ImplementationType = implementationType;
            Lifetime = serviceLifetime;
        }
    }
}

using DependencyInjectionLibrary;
using Dumdumpay.Payment.Getway;

namespace DummyPayLibrary
{
    public static class ServiceDIBuilder
    {
        private static ServiceCollection _services;
        public static void Register()
        {
            _services = new ServiceCollection();

            _services.RegisterSingleton<IPaymentProcessor, PaymentProcessor>();
            _services.RegisterSingleton<IDummyPayAPI, DummyPayAPI>();
        }

        public static IDummyPayAPI Build()
        {
            var container = _services.BuildContainer();
            var service = container.GetService<IDummyPayAPI>();

            return service;
        }
    }
}

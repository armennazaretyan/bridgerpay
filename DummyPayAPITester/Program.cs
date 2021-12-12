using DummyPayLibrary;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.Threading.Tasks;

namespace DummyPayAPITester
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                SetupStaticLogger();

                Log.Information("Application started.");

                Log.Warning("NEED to register dipendency injection!");

                Log.Verbose("Trying to register dipendency injection.");
                ServiceDIBuilder.Register();
                Log.Information("Dipendency injection successfully registered.");

                Log.Verbose("Getting Dummy Payment API."); 
                IDummyPayAPI dummyPayAPI = ServiceDIBuilder.Build();
                Log.Information("DummyPayAPI successfully created.");

                Log.Verbose("Starting to create new payment.");
                //await dummyPayAPI.CreatePayment();
                Log.Information("New payment successfully created.");

                Log.Verbose("Starting to confirmation payment.");
                //await dummyPayAPI.PaymentConfirmation();
                Log.Information("Payment successfully confirmed.");
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "An unhandled exception occurred.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        private static void SetupStaticLogger()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }
    }
}

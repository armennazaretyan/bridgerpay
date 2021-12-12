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

    #region MyRegion
    //public class Person
    //{
    //    public string Name { get; set; }
    //    public string Occupation { get; set; }

    //    public override string ToString()
    //    {
    //        return $"{Name}: {Occupation}";
    //    }
    //}


    //var person = new Person();
    //person.Name = "John Doe";
    //person.Occupation = "gardener";

    //var jsonX = JsonConvert.SerializeObject(person);
    //var dataX = new StringContent(jsonX, Encoding.UTF8, "application/json");

    //var url = "https://httpbin.org/post";
    //string result = "";
    //using (var client = new HttpClient())
    //{
    //    var response = await client.PostAsync(url, dataX);

    //    result = response.Content.ReadAsStringAsync().Result;
    //}
















    //    string MerchId = "6fc3aa31-7afd-4df1-825f-192e60950ca1";
    //string SecKey = "53cr3t";

    //CommantRequest commantRequest = new CommantRequest();
    //    commantRequest.MechantId = MerchId;
    //    commantRequest.SecretKey = SecKey;
    //    commantRequest.Url = "create";
    //    commantRequest.RequestObject = new PaymentCreateRequest("DBB99946-A10A-4D1B-A742-577FA026BC57", 125); //Guid.NewGuid().ToString()

    //    using (var client = new HttpClient())
    //    {
    //        string resp = "";

    //        try
    //        {

    //            //string value = System.Configuration.ConfigurationManager.AppSettings[key];

    //            //client.BaseAddress = new Uri("https://dumdumpay.site/api/payment/");
    //            //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
    //            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    //            client.DefaultRequestHeaders.Add("Mechant-Id", commantRequest.MechantId);
    //            client.DefaultRequestHeaders.Add("Secret-Key", commantRequest.SecretKey);




    //            var json = JsonConvert.SerializeObject(commantRequest.RequestObject);
    //            var data = new StringContent(json, Encoding.UTF8, "application/json");
    //            var response = await client.PostAsync("https://dumdumpay.site/api/payment/" + commantRequest.Url, data);

    //            //HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://httpbin.org/post"); //https://dumdumpay.site/api/payment/ + commantRequest.Url
    //            //request.Content = data;
    //            //await client.SendAsync(request)
    //            //  .ContinueWith(responseTask =>
    //            //  {
    //            //      //Console.WriteLine("Response: {0}", responseTask.Result);
    //            //      resp = responseTask.Result.Content.ReadAsStringAsync().Result;
    //            //  });



    //            //resp = response.Content.ReadAsStringAsync().Result;
    //            resp = await response.Content.ReadAsStringAsync();


    //        }
    //        catch (Exception ex)
    //        {
    //        }

    //        //TResponce contributors = JsonConvert.DeserializeObject<TResponce>(resp);
    //        //return contributors;
    //    }


    #endregion
}

using Dumdumpay.Payment.Getway.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Dumdumpay.Payment.Getway.Helper
{
    public class HttpClientModule
    {
        public async Task<TResponse> RequestAsync<TResponse>(CommantRequest commantRequest)
        {
            using (var client = new HttpClient())
            {
                string resp = "";

                try
                {

                    //string value = System.Configuration.ConfigurationManager.AppSettings[key];

                    //client.BaseAddress = new Uri("https://dumdumpay.site/api/payment/");
                    //client.DefaultRequestHeaders.Add("Content-Type", "application/json");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("mechant-id", commantRequest.MechantId);
                    client.DefaultRequestHeaders.Add("secret-key", commantRequest.SecretKey);




                    var json = JsonConvert.SerializeObject(commantRequest.RequestObject);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync("https://dumdumpay.site/api/payment/" + commantRequest.Url, data);

                    //var response = await client.PostAsync("https://private-anon-5b2b56725b-dumdumpay.apiary-proxy.com/api/payment/" + commantRequest.Url, data);


                    //HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "https://dumdumpay.site/api/payment/" + commantRequest.Url);
                    //request.Content = data;
                    //await client.SendAsync(request)
                    //  .ContinueWith(responseTask =>
                    //  {
                    //      //Console.WriteLine("Response: {0}", responseTask.Result);
                    //      resp = responseTask.Result.Content.ReadAsStringAsync().Result;
                    //  });



                    //resp = response.Content.ReadAsStringAsync().Result;
                    resp = await response.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                }

                TResponse contributors = JsonConvert.DeserializeObject<TResponse>(resp);
                return contributors;
            }
        }
    }
}

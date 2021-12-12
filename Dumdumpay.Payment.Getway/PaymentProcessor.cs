using Dumdumpay.Payment.Getway.Helper;
using Dumdumpay.Payment.Getway.Models;
using Dumdumpay.Payment.Getway.Models.Requests;
using Dumdumpay.Payment.Getway.Models.Responses;
using System.Threading.Tasks;

namespace Dumdumpay.Payment.Getway
{
    /// <summary>
    /// Service API documentation: https://dumdumpay.docs.apiary.io/
    /// </summary>
    public class PaymentProcessor : IPaymentProcessor
    {
        private string MerchId { get; set; } = "6fc3aa31-7afd-4df1-825f-192e60950ca1";
        private string SecKey { get; set; } = "53cr3t";

        /// <summary>
        /// Post
        /// https://dumdumpay.site/api/payment/create
        /// </summary>
        public async Task Create()
        {
            CommantRequest commantRequest = new CommantRequest();
            commantRequest.MechantId = MerchId;
            commantRequest.SecretKey = SecKey;
            commantRequest.Url = "create";
            commantRequest.RequestObject = new PaymentCreateRequest("DBB99946-A10A-4D1B-A742-577FA026BC57", 125); //Guid.NewGuid().ToString()

            HttpClientModule responce = new HttpClientModule();
            var resp = await responce.RequestAsync<CreateResponse>(commantRequest);

        }

        /// <summary>
        /// Post
        /// https://dumdumpay.site/api/payment/confirm
        /// </summary>
        public async Task Confirm()
        {
            CommantRequest commantRequest = new CommantRequest();
            commantRequest.MechantId = MerchId;
            commantRequest.SecretKey = SecKey;
            commantRequest.Url = "confirm";
            commantRequest.RequestObject = new PaymentConfirmRequest();

            HttpClientModule responce = new HttpClientModule();
            var resp = await responce.RequestAsync<ConfirmResponse>(commantRequest);
        }
    }
}

using System.Collections.Generic;

namespace Dumdumpay.Payment.Getway.Models.Responses
{
    public class CreateResponse
    {
        public PaymentCreateResponse Result { get; set; }
        public List<ErrorsResponse> Errors { get; set; }
    }
    public class PaymentCreateResponse
    {
        public string TransactionId { get; set; }
        public string TransactionStatus { get; set; }
        public string paReq { get; set; }
        public string Url { get; set; }
        public string Method { get; set; }
    }
}

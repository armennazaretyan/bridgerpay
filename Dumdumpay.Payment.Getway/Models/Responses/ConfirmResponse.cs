using System.Collections.Generic;

namespace Dumdumpay.Payment.Getway.Models.Responses
{
    public class ConfirmResponse
    {
        public PaymentConfirmResponse Result { get; set; }
        public List<ErrorsResponse> Errors { get; set; }
    }
    public class PaymentConfirmResponse
    {
        public string TransactionId { get; set; }
        public string Status { get; set; }
        public string Amount { get; set; }
        public string Currency { get; set; }
        public string OrderId { get; set; }
        public string LastFourDigits { get; set; }
    }
}

using Dumdumpay.Payment.Getway.Models.Interfaces;

namespace Dumdumpay.Payment.Getway.Models.Requests
{
    public class PaymentCreateRequest : IRequest
    {
        public string orderId { get; set; }
        public double amount { get; set; }
        public string currency { get; set; }
        public string country { get; set; }
        public string cardNumber { get; set; }
        public string cardHolder { get; set; }
        public string cardExpiryDate { get; set; }
        public string cvv { get; set; }

        public PaymentCreateRequest(string _orderId, double _amount)
        {
            orderId = _orderId;
            amount = _amount;
            currency = "USD";
            country = "CY";
            cardNumber = "4111111111111111";
            cardHolder = "TEST TESTER";
            cardExpiryDate = "1123";
            cvv = "111";
        }
    }
}

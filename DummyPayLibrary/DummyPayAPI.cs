using Dumdumpay.Payment.Getway;
using System.Threading.Tasks;

namespace DummyPayLibrary
{
    public class DummyPayAPI : IDummyPayAPI
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public DummyPayAPI(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public async Task CreatePayment()
        {
            await _paymentProcessor.Create();
        }

        public async Task PaymentConfirmation()
        {
            await _paymentProcessor.Confirm();
        }
    }
}

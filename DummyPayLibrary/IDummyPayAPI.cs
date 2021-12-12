using System.Threading.Tasks;

namespace DummyPayLibrary
{
    public interface IDummyPayAPI
    {
        Task CreatePayment();

        Task PaymentConfirmation();
    }
}

using System.Threading.Tasks;

namespace Dumdumpay.Payment.Getway
{
    public interface IPaymentProcessor
    {
        Task Create();

        Task Confirm();
    }
}

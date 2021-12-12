using Dumdumpay.Payment.Getway.Models.Interfaces;

namespace Dumdumpay.Payment.Getway.Models
{
    public class CommantRequest
    {
        public string Url { get; set; }
        public string MechantId { get; set; }
        public string SecretKey { get; set; }
        public IRequest RequestObject { get; set; }
    }
}

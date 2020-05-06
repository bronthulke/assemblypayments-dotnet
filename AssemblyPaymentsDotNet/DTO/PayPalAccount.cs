using Newtonsoft.Json;

namespace AssemblyPaymentsDotNet.DTO
{
    public class PayPalAccount : AbstractAccount
    {
        [JsonProperty(PropertyName = "paypal")]
        public PayPal PayPal { get; set; }
    }
}

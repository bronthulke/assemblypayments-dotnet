using Newtonsoft.Json;

namespace AssemblyPaymentsDotNet.DTO
{
    public class PayPal
    {
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
    }
}

using Newtonsoft.Json;

namespace AssemblyPaymentsDotNet.DTO
{
    public class BankAccount : AbstractAccount
    {
        [JsonProperty(PropertyName = "bank")]
        public Bank Bank { get; set; }
    }
}

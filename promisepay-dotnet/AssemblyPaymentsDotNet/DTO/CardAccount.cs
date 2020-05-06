using Newtonsoft.Json;

namespace AssemblyPaymentsDotNet.DTO
{
    public class CardAccount : AbstractAccount
    {
        [JsonProperty(PropertyName = "card")]
        public Card Card { get; set; }
    }
}

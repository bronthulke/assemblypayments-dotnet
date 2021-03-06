using Newtonsoft.Json;
using System.Collections.Generic;

namespace AssemblyPaymentsDotNet.DTO
{
    public class User : AbstractDTO
    {
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "mobile")]
        public string Mobile { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "address_line1")]
        public string AddressLine1 { get; set; }

        [JsonProperty(PropertyName = "address_line2")]
        public string AddressLine2 { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "dob")]
        public string Dob { get; set; }

        [JsonProperty(PropertyName = "full_name")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "verification_state")]
        public string VerificationState { get; set; }

        [JsonProperty(PropertyName = "drivers_license")]
        public string DriversLicense { get; set; }

        [JsonProperty(PropertyName = "drivers_license_number")]
        public string DriversLicenseNumber { get; set; }

        [JsonProperty(PropertyName = "drivers_license_state")]
        public string DriversLicenseState { get; set; }

        [JsonProperty(PropertyName = "government_number")]
        public string GovernmentNumber { get; set; }

        [JsonProperty(PropertyName = "ip_address")]
        public string IPAddress { get; set; }

        [JsonProperty(PropertyName = "logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty(PropertyName = "color_1")]
        public string Color1 { get; set; }

        [JsonProperty(PropertyName = "color_2")]
        public string Color2 { get; set; }

        [JsonProperty(PropertyName = "custom_descriptor")]
        public string CustomDescriptor { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "held_state")]
        public bool HeldState { get; set; }

        [JsonProperty(PropertyName = "related")]
        public IDictionary<string, string> Related { get; set; }

        [JsonProperty(PropertyName = "roles")]
        public string[] Roles{ get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestingCosmos.models
{
    public class Contact
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "adminUser")]
        public string adminUser { get; set; }

        [JsonProperty(PropertyName = "companyName")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "contactNumber")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "emailAddress")]
        public string emailAddress { get; set; }
    }
}

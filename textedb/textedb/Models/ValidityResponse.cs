using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textedb.Models
{
    [Serializable]
    public class ValidityResponse
    {
        [JsonProperty(PropertyName = "is_valid")]
        public string isSuccessful { get; set; }

        public ValidityResponse(string isSuccessful)
        {
            this.isSuccessful = isSuccessful;
        }

        public override string ToString()
        {
            return isSuccessful;
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterEmployeeFinger.src.Class.API
{
    class DataResponseFull
    {
        [JsonProperty("status")]
        public int Status
        {
            get;
            set;
        }

        [JsonProperty("message")]
        public string Message
        {
            get;
            set;
        }

        [JsonProperty("data")]
        public JObject Data
        {
            get;
            set;
        }
    }
}

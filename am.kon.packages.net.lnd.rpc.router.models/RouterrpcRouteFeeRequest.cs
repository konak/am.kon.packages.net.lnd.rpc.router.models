using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcRouteFeeRequest
    {
        /// <summary>
        /// The destination once wishes to obtain a routing fee quote to.
        /// </summary>
        [JsonProperty("dest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Dest { get; set; }

        /// <summary>
        /// The amount one wishes to send to the target destination.
        /// </summary>
        [JsonProperty("amt_sat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Amt_sat { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings());
        }

        public static RouterrpcRouteFeeRequest FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcRouteFeeRequest>(data, new JsonSerializerSettings());
        }
    }
}

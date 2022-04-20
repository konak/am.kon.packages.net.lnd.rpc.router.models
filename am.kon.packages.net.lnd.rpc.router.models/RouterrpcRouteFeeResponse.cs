using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcRouteFeeResponse
    {
        /// <summary>
        /// A lower bound of the estimated fee to the target destination within the
        /// <br/>network, expressed in milli-satoshis.
        /// </summary>
        [JsonProperty("routing_fee_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Routing_fee_msat { get; set; }

        /// <summary>
        /// An estimate of the worst case time delay that can occur. Note that callers
        /// <br/>will still need to factor in the final CLTV delta of the last hop into this
        /// <br/>value.
        /// </summary>
        [JsonProperty("time_lock_delay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Time_lock_delay { get; set; }

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

        public static RouterrpcRouteFeeResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcRouteFeeResponse>(data, new JsonSerializerSettings());
        }
    }
}

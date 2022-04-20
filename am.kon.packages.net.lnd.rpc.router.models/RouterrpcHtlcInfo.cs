using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcHtlcInfo
    {
        /// <summary>
        /// The timelock on the incoming htlc.
        /// </summary>
        [JsonProperty("incoming_timelock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Incoming_timelock { get; set; }

        /// <summary>
        /// The timelock on the outgoing htlc.
        /// </summary>
        [JsonProperty("outgoing_timelock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Outgoing_timelock { get; set; }

        /// <summary>
        /// The amount of the incoming htlc.
        /// </summary>
        [JsonProperty("incoming_amt_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Incoming_amt_msat { get; set; }

        /// <summary>
        /// The amount of the outgoing htlc.
        /// </summary>
        [JsonProperty("outgoing_amt_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Outgoing_amt_msat { get; set; }

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

        public static RouterrpcHtlcInfo FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcHtlcInfo>(data, new JsonSerializerSettings());
        }
    }
}

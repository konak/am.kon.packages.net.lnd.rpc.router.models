using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    /// <summary>
    /// PairHistory contains the mission control state for a particular node pair.
    /// </summary>
    public class RouterrpcPairHistory
    {
        /// <summary>
        /// The source node pubkey of the pair.
        /// </summary>
        [JsonProperty("node_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Node_from { get; set; }

        /// <summary>
        /// The destination node pubkey of the pair.
        /// </summary>
        [JsonProperty("node_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Node_to { get; set; }

        [JsonProperty("history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RouterrpcPairData History { get; set; }

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

        public static RouterrpcPairHistory FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcPairHistory>(data, new JsonSerializerSettings());
        }
    }
}

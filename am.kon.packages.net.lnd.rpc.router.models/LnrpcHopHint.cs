using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class LnrpcHopHint
    {
        /// <summary>
        /// The public key of the node at the start of the channel.
        /// </summary>
        [JsonProperty("node_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Node_id { get; set; }

        /// <summary>
        /// The unique identifier of the channel.
        /// </summary>
        [JsonProperty("chan_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Chan_id { get; set; }

        /// <summary>
        /// The base fee of the channel denominated in millisatoshis.
        /// </summary>
        [JsonProperty("fee_base_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Fee_base_msat { get; set; }

        /// <summary>
        /// The fee rate of the channel for sending one satoshi across it denominated in
        /// <br/>millionths of a satoshi.
        /// </summary>
        [JsonProperty("fee_proportional_millionths", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Fee_proportional_millionths { get; set; }

        /// <summary>
        /// The time-lock delta of the channel.
        /// </summary>
        [JsonProperty("cltv_expiry_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Cltv_expiry_delta { get; set; }

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

        public static LnrpcHopHint FromJson(string data)
        {
            return JsonConvert.DeserializeObject<LnrpcHopHint>(data, new JsonSerializerSettings());
        }
    }
}

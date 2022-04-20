using Newtonsoft.Json;
using System.Collections.Generic;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class LnrpcChannelPoint
    {
        /// <summary>
        /// Txid of the funding transaction. When using REST, this field must be
        /// <br/>encoded as base64.
        /// </summary>
        [JsonProperty("funding_txid_bytes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Funding_txid_bytes { get; set; }

        /// <summary>
        /// Hex-encoded string representing the byte-reversed hash of the funding
        /// <br/>transaction.
        /// </summary>
        [JsonProperty("funding_txid_str", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Funding_txid_str { get; set; }

        [JsonProperty("output_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Output_index { get; set; }

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
        public static LnrpcChannelPoint FromJson(string data)
        {
            return JsonConvert.DeserializeObject<LnrpcChannelPoint>(data, new JsonSerializerSettings());
        }
    }
}

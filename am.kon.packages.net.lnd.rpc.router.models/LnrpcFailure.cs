using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class LnrpcFailure
    {
        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public FailureFailureCode? Code { get; set; }

        /// <summary>
        /// An optional channel update message.
        /// </summary>
        [JsonProperty("channel_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LnrpcChannelUpdate Channel_update { get; set; }

        /// <summary>
        /// A failure type-dependent htlc value.
        /// </summary>
        [JsonProperty("htlc_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Htlc_msat { get; set; }

        /// <summary>
        /// The sha256 sum of the onion payload.
        /// </summary>
        [JsonProperty("onion_sha_256", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Onion_sha_256 { get; set; }

        /// <summary>
        /// A failure type-dependent cltv expiry value.
        /// </summary>
        [JsonProperty("cltv_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Cltv_expiry { get; set; }

        /// <summary>
        /// A failure type-dependent flags value.
        /// </summary>
        [JsonProperty("flags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Flags { get; set; }

        /// <summary>
        /// The position in the path of the intermediate or final node that generated
        /// <br/>the failure message. Position zero is the sender node.
        /// </summary>
        [JsonProperty("failure_source_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Failure_source_index { get; set; }

        /// <summary>
        /// A failure type-dependent block height.
        /// </summary>
        [JsonProperty("height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }

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

        public static LnrpcFailure FromJson(string data)
        {
            return JsonConvert.DeserializeObject<LnrpcFailure>(data, new JsonSerializerSettings());
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcPaymentStatus
    {
        /// <summary>
        /// Current state the payment is in.
        /// </summary>
        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public RouterrpcPaymentState? State { get; set; }

        /// <summary>
        /// The pre-image of the payment when state is SUCCEEDED.
        /// </summary>
        [JsonProperty("preimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Preimage { get; set; }

        /// <summary>
        /// The HTLCs made in attempt to settle the payment [EXPERIMENTAL].
        /// </summary>
        [JsonProperty("htlcs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<LnrpcHTLCAttempt> Htlcs { get; set; }

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

        public static RouterrpcPaymentStatus FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcPaymentStatus>(data, new JsonSerializerSettings());
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace am.kon.packages.net.lnd.rpc.router
{
    /// <summary>
    /// *
    /// <br/>ForwardHtlcInterceptResponse enables the caller to resolve a previously hold
    /// <br/>forward. The caller can choose either to:
    /// <br/>- `Resume`: Execute the default behavior (usually forward).
    /// <br/>- `Reject`: Fail the htlc backwards.
    /// <br/>- `Settle`: Settle this htlc with a given preimage.
    /// </summary>
    public class RouterrpcForwardHtlcInterceptResponse
    {
        /// <summary>
        /// *
        /// <br/>The key of this forwarded htlc. It defines the incoming channel id and
        /// <br/>the index in this channel.
        /// </summary>
        [JsonProperty("incoming_circuit_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RouterrpcCircuitKey Incoming_circuit_key { get; set; }

        /// <summary>
        /// The resolve action for this intercepted htlc.
        /// </summary>
        [JsonProperty("action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public RouterrpcResolveHoldForwardAction? Action { get; set; }

        /// <summary>
        /// The preimage in case the resolve action is Settle.
        /// </summary>
        [JsonProperty("preimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Preimage { get; set; }

        /// <summary>
        /// Encrypted failure message in case the resolve action is Fail.
        /// <br/>
        /// <br/>If failure_message is specified, the failure_code field must be set
        /// <br/>to zero.
        /// </summary>
        [JsonProperty("failure_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Failure_message { get; set; }

        /// <summary>
        /// Return the specified failure code in case the resolve action is Fail. The
        /// <br/>message data fields are populated automatically.
        /// <br/>
        /// <br/>If a non-zero failure_code is specified, failure_message must not be set.
        /// <br/>
        /// <br/>For backwards-compatibility reasons, TEMPORARY_CHANNEL_FAILURE is the
        /// <br/>default value for this field.
        /// </summary>
        [JsonProperty("failure_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public FailureFailureCode? Failure_code { get; set; }

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

        public static RouterrpcForwardHtlcInterceptResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcForwardHtlcInterceptResponse>(data, new JsonSerializerSettings());
        }
    }
}

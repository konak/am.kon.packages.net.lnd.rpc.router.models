using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class LnrpcHTLCAttempt
    {
        /// <summary>
        /// The unique ID that is used for this attempt.
        /// </summary>
        [JsonProperty("attempt_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Attempt_id { get; set; }

        /// <summary>
        /// The status of the HTLC.
        /// </summary>
        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public HTLCAttemptHTLCStatus? Status { get; set; }

        /// <summary>
        /// The route taken by this HTLC.
        /// </summary>
        [JsonProperty("route", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LnrpcRoute Route { get; set; }

        /// <summary>
        /// The time in UNIX nanoseconds at which this HTLC was sent.
        /// </summary>
        [JsonProperty("attempt_time_ns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Attempt_time_ns { get; set; }

        /// <summary>
        /// The time in UNIX nanoseconds at which this HTLC was settled or failed.
        /// <br/>This value will not be set if the HTLC is still IN_FLIGHT.
        /// </summary>
        [JsonProperty("resolve_time_ns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Resolve_time_ns { get; set; }

        /// <summary>
        /// Detailed htlc failure info.
        /// </summary>
        [JsonProperty("failure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LnrpcFailure Failure { get; set; }

        /// <summary>
        /// The preimage that was used to settle the HTLC.
        /// </summary>
        [JsonProperty("preimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Preimage { get; set; }

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

        public static LnrpcHTLCAttempt FromJson(string data)
        {
            return JsonConvert.DeserializeObject<LnrpcHTLCAttempt>(data, new JsonSerializerSettings());
        }
    }
}
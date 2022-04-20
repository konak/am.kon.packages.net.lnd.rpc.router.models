using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class LnrpcPayment
    {
        [JsonProperty("payment_hash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Payment_hash { get; set; }

        /// <summary>
        /// Deprecated, use value_sat or value_msat.
        /// </summary>
        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        [JsonProperty("creation_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Creation_date { get; set; }

        /// <summary>
        /// Deprecated, use fee_sat or fee_msat.
        /// </summary>
        [JsonProperty("fee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fee { get; set; }

        [JsonProperty("payment_preimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Payment_preimage { get; set; }

        [JsonProperty("value_sat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Value_sat { get; set; }

        [JsonProperty("value_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Value_msat { get; set; }

        /// <summary>
        /// The optional payment request being fulfilled.
        /// </summary>
        [JsonProperty("payment_request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Payment_request { get; set; }

        /// <summary>
        /// The status of the payment.
        /// </summary>
        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public LnrpcPaymentPaymentStatus? Status { get; set; }

        [JsonProperty("fee_sat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fee_sat { get; set; }

        [JsonProperty("fee_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fee_msat { get; set; }

        /// <summary>
        /// The time in UNIX nanoseconds at which the payment was created.
        /// </summary>
        [JsonProperty("creation_time_ns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Creation_time_ns { get; set; }

        /// <summary>
        /// The HTLCs made in attempt to settle the payment.
        /// </summary>
        [JsonProperty("htlcs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<LnrpcHTLCAttempt> Htlcs { get; set; }

        /// <summary>
        /// The creation index of this payment. Each payment can be uniquely identified
        /// <br/>by this index, which may not strictly increment by 1 for payments made in
        /// <br/>older versions of lnd.
        /// </summary>
        [JsonProperty("payment_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Payment_index { get; set; }

        [JsonProperty("failure_reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public LnrpcPaymentFailureReason? Failure_reason { get; set; }

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

        public static LnrpcPayment FromJson(string data)
        {
            return JsonConvert.DeserializeObject<LnrpcPayment>(data, new JsonSerializerSettings());
        }
    }
}

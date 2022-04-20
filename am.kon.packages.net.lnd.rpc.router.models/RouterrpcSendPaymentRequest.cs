using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcSendPaymentRequest
    {
        [JsonProperty("dest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Dest { get; set; }

        /// <summary>
        /// Number of satoshis to send.
        /// <br/>
        /// <br/>The fields amt and amt_msat are mutually exclusive.
        /// </summary>
        [JsonProperty("amt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Amt { get; set; }

        /// <summary>
        /// Number of millisatoshis to send.
        /// <br/>
        /// <br/>The fields amt and amt_msat are mutually exclusive.
        /// </summary>
        [JsonProperty("amt_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Amt_msat { get; set; }

        [JsonProperty("payment_hash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Payment_hash { get; set; }

        /// <summary>
        /// The CLTV delta from the current height that should be used to set the
        /// <br/>timelock for the final hop.
        /// </summary>
        [JsonProperty("final_cltv_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Final_cltv_delta { get; set; }

        /// <summary>
        /// An optional payment addr to be included within the last hop of the route.
        /// </summary>
        [JsonProperty("payment_addr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Payment_addr { get; set; }

        /// <summary>
        /// A bare-bones invoice for a payment within the Lightning Network.  With the
        /// <br/>details of the invoice, the sender has all the data necessary to send a
        /// <br/>payment to the recipient. The amount in the payment request may be zero. In
        /// <br/>that case it is required to set the amt field as well. If no payment request
        /// <br/>is specified, the following fields are required: dest, amt and payment_hash.
        /// </summary>
        [JsonProperty("payment_request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Payment_request { get; set; }

        /// <summary>
        /// An upper limit on the amount of time we should spend when attempting to
        /// <br/>fulfill the payment. This is expressed in seconds. If we cannot make a
        /// <br/>successful payment within this time frame, an error will be returned.
        /// <br/>This field must be non-zero.
        /// </summary>
        [JsonProperty("timeout_seconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout_seconds { get; set; }

        /// <summary>
        /// The maximum number of satoshis that will be paid as a fee of the payment.
        /// <br/>If this field is left to the default value of 0, only zero-fee routes will
        /// <br/>be considered. This usually means single hop routes connecting directly to
        /// <br/>the destination. To send the payment without a fee limit, use max int here.
        /// <br/>
        /// <br/>The fields fee_limit_sat and fee_limit_msat are mutually exclusive.
        /// </summary>
        [JsonProperty("fee_limit_sat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fee_limit_sat { get; set; }

        /// <summary>
        /// The maximum number of millisatoshis that will be paid as a fee of the
        /// <br/>payment. If this field is left to the default value of 0, only zero-fee
        /// <br/>routes will be considered. This usually means single hop routes connecting
        /// <br/>directly to the destination. To send the payment without a fee limit, use
        /// <br/>max int here.
        /// <br/>
        /// <br/>The fields fee_limit_sat and fee_limit_msat are mutually exclusive.
        /// </summary>
        [JsonProperty("fee_limit_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fee_limit_msat { get; set; }

        /// <summary>
        /// Deprecated, use outgoing_chan_ids. The channel id of the channel that must
        /// <br/>be taken to the first hop. If zero, any channel may be used (unless
        /// <br/>outgoing_chan_ids are set).
        /// </summary>
        [JsonProperty("outgoing_chan_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Outgoing_chan_id { get; set; }

        /// <summary>
        /// The channel ids of the channels are allowed for the first hop. If empty,
        /// <br/>any channel may be used.
        /// </summary>
        [JsonProperty("outgoing_chan_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Outgoing_chan_ids { get; set; }

        /// <summary>
        /// The pubkey of the last hop of the route. If empty, any hop may be used.
        /// </summary>
        [JsonProperty("last_hop_pubkey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Last_hop_pubkey { get; set; }

        /// <summary>
        /// An optional maximum total time lock for the route. This should not exceed
        /// <br/>lnd's `--max-cltv-expiry` setting. If zero, then the value of
        /// <br/>`--max-cltv-expiry` is enforced.
        /// </summary>
        [JsonProperty("cltv_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cltv_limit { get; set; }

        /// <summary>
        /// Optional route hints to reach the destination through private channels.
        /// </summary>
        [JsonProperty("route_hints", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<LnrpcRouteHint> Route_hints { get; set; }

        /// <summary>
        /// An optional field that can be used to pass an arbitrary set of TLV records
        /// <br/>to a peer which understands the new records. This can be used to pass
        /// <br/>application specific data during the payment attempt. Record types are
        /// <br/>required to be in the custom range &gt;= 65536. When using REST, the values
        /// <br/>must be encoded as base64.
        /// </summary>
        [JsonProperty("dest_custom_records", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, byte[]> Dest_custom_records { get; set; }

        /// <summary>
        /// If set, circular payments to self are permitted.
        /// </summary>
        [JsonProperty("allow_self_payment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_self_payment { get; set; }

        /// <summary>
        /// Features assumed to be supported by the final node. All transitive feature
        /// <br/>dependencies must also be set properly. For a given feature bit pair, either
        /// <br/>optional or remote may be set, but not both. If this field is nil or empty,
        /// <br/>the router will try to load destination features from the graph as a
        /// <br/>fallback.
        /// </summary>
        [JsonProperty("dest_features", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore, ItemConverterType = typeof(StringEnumConverter))]
        public List<LnrpcFeatureBit> Dest_features { get; set; }

        /// <summary>
        /// The maximum number of   payments that may be use to complete the full
        /// <br/>amount.
        /// </summary>
        [JsonProperty("max_parts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Max_parts { get; set; }

        /// <summary>
        /// If set, only the final payment update is streamed back. Intermediate updates
        /// <br/>that show which htlcs are still in flight are suppressed.
        /// </summary>
        [JsonProperty("no_inflight_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? No_inflight_updates { get; set; }

        /// <summary>
        /// The largest payment split that should be attempted when making a payment if
        /// <br/>splitting is necessary. Setting this value will effectively cause lnd to
        /// <br/>split more aggressively, vs only when it thinks it needs to. Note that this
        /// <br/>value is in milli-satoshis.
        /// </summary>
        [JsonProperty("max_shard_size_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Max_shard_size_msat { get; set; }

        /// <summary>
        /// If set, an AMP-payment will be attempted.
        /// </summary>
        [JsonProperty("amp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Amp { get; set; }

        /// <summary>
        /// The time preference for this payment. Set to -1 to optimize for fees
        /// <br/>only, to 1 to optimize for reliability only or a value inbetween for a mix.
        /// </summary>
        [JsonProperty("time_pref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Time_pref { get; set; }

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

        public static RouterrpcSendPaymentRequest FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcSendPaymentRequest>(data, new JsonSerializerSettings());
        }
    }
}
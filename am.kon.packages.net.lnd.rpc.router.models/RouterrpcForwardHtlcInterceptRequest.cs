using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcForwardHtlcInterceptRequest
    {
        /// <summary>
        /// The key of this forwarded htlc. It defines the incoming channel id and
        /// <br/>the index in this channel.
        /// </summary>
        [JsonProperty("incoming_circuit_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RouterrpcCircuitKey Incoming_circuit_key { get; set; }

        /// <summary>
        /// The incoming htlc amount.
        /// </summary>
        [JsonProperty("incoming_amount_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Incoming_amount_msat { get; set; }

        /// <summary>
        /// The incoming htlc expiry.
        /// </summary>
        [JsonProperty("incoming_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Incoming_expiry { get; set; }

        /// <summary>
        /// The htlc payment hash. This value is not guaranteed to be unique per
        /// <br/>request.
        /// </summary>
        [JsonProperty("payment_hash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Payment_hash { get; set; }

        /// <summary>
        /// The requested outgoing channel id for this forwarded htlc. Because of
        /// <br/>non-strict forwarding, this isn't necessarily the channel over which the
        /// <br/>packet will be forwarded eventually. A different channel to the same peer
        /// <br/>may be selected as well.
        /// </summary>
        [JsonProperty("outgoing_requested_chan_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Outgoing_requested_chan_id { get; set; }

        /// <summary>
        /// The outgoing htlc amount.
        /// </summary>
        [JsonProperty("outgoing_amount_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Outgoing_amount_msat { get; set; }

        /// <summary>
        /// The outgoing htlc expiry.
        /// </summary>
        [JsonProperty("outgoing_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Outgoing_expiry { get; set; }

        /// <summary>
        /// Any custom records that were present in the payload.
        /// </summary>
        [JsonProperty("custom_records", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, byte[]> Custom_records { get; set; }

        [JsonProperty("onion_blob", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Onion_blob { get; set; }

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

        public static RouterrpcForwardHtlcInterceptRequest FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcForwardHtlcInterceptRequest>(data, new JsonSerializerSettings());
        }
    }
}

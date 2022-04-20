using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class LnrpcHop
    {
        /// <summary>
        /// The unique channel ID for the channel. The first 3 bytes are the block
        /// <br/>height, the next 3 the index within the block, and the last 2 bytes are the
        /// <br/>output index for the channel.
        /// </summary>
        [JsonProperty("chan_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Chan_id { get; set; }

        [JsonProperty("chan_capacity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Chan_capacity { get; set; }

        [JsonProperty("amt_to_forward", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Amt_to_forward { get; set; }

        [JsonProperty("fee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fee { get; set; }

        [JsonProperty("expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Expiry { get; set; }

        [JsonProperty("amt_to_forward_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Amt_to_forward_msat { get; set; }

        [JsonProperty("fee_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fee_msat { get; set; }

        /// <summary>
        /// An optional public key of the hop. If the public key is given, the payment
        /// <br/>can be executed without relying on a copy of the channel graph.
        /// </summary>
        [JsonProperty("pub_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Pub_key { get; set; }

        /// <summary>
        /// If set to true, then this hop will be encoded using the new variable length
        /// <br/>TLV format. Note that if any custom tlv_records below are specified, then
        /// <br/>this field MUST be set to true for them to be encoded properly.
        /// </summary>
        [JsonProperty("tlv_payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tlv_payload { get; set; }

        /// <summary>
        /// An optional TLV record that signals the use of an MPP payment. If present,
        /// <br/>the receiver will enforce that the same mpp_record is included in the final
        /// <br/>hop payload of all non-zero payments in the HTLC set. If empty, a regular
        /// <br/>single-shot payment is or was attempted.
        /// </summary>
        [JsonProperty("mpp_record", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LnrpcMPPRecord Mpp_record { get; set; }

        /// <summary>
        /// An optional TLV record that signals the use of an AMP payment. If present,
        /// <br/>the receiver will treat all received payments including the same
        /// <br/>(payment_addr, set_id) pair  as being part of one logical payment. The
        /// <br/>payment will be settled by XORing the root_share's together and deriving the
        /// <br/>child hashes and preimages according to BOLT XX. Must be used in conjunction
        /// <br/>with mpp_record.
        /// </summary>
        [JsonProperty("amp_record", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LnrpcAMPRecord Amp_record { get; set; }

        /// <summary>
        /// An optional set of key-value TLV records. This is useful within the context
        /// <br/>of the SendToRoute call as it allows callers to specify arbitrary K-V pairs
        /// <br/>to drop off at each hop within the onion.
        /// </summary>
        [JsonProperty("custom_records", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, byte[]> Custom_records { get; set; }

        /// <summary>
        /// The payment metadata to send along with the payment to the payee.
        /// </summary>
        [JsonProperty("metadata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Metadata { get; set; }

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

        public static LnrpcHop FromJson(string data)
        {
            return JsonConvert.DeserializeObject<LnrpcHop>(data, new JsonSerializerSettings());
        }
    }
}

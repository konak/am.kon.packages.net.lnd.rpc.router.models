using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class LnrpcChannelUpdate
    {
        /// <summary>
        /// The signature that validates the announced data and proves the ownership
        /// <br/>of node id.
        /// </summary>
        [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Signature { get; set; }

        /// <summary>
        /// The target chain that this channel was opened within. This value
        /// <br/>should be the genesis hash of the target chain. Along with the short
        /// <br/>channel ID, this uniquely identifies the channel globally in a
        /// <br/>blockchain.
        /// </summary>
        [JsonProperty("chain_hash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Chain_hash { get; set; }

        /// <summary>
        /// The unique description of the funding transaction.
        /// </summary>
        [JsonProperty("chan_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Chan_id { get; set; }

        /// <summary>
        /// A timestamp that allows ordering in the case of multiple announcements.
        /// <br/>We should ignore the message if timestamp is not greater than the
        /// <br/>last-received.
        /// </summary>
        [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// The bitfield that describes whether optional fields are present in this
        /// <br/>update. Currently, the least-significant bit must be set to 1 if the
        /// <br/>optional field MaxHtlc is present.
        /// </summary>
        [JsonProperty("message_flags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Message_flags { get; set; }

        /// <summary>
        /// The bitfield that describes additional meta-data concerning how the
        /// <br/>update is to be interpreted. Currently, the least-significant bit must be
        /// <br/>set to 0 if the creating node corresponds to the first node in the
        /// <br/>previously sent channel announcement and 1 otherwise. If the second bit
        /// <br/>is set, then the channel is set to be disabled.
        /// </summary>
        [JsonProperty("channel_flags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Channel_flags { get; set; }

        /// <summary>
        /// The minimum number of blocks this node requires to be added to the expiry
        /// <br/>of HTLCs. This is a security parameter determined by the node operator.
        /// <br/>This value represents the required gap between the time locks of the
        /// <br/>incoming and outgoing HTLC's set to this node.
        /// </summary>
        [JsonProperty("time_lock_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Time_lock_delta { get; set; }

        /// <summary>
        /// The minimum HTLC value which will be accepted.
        /// </summary>
        [JsonProperty("htlc_minimum_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Htlc_minimum_msat { get; set; }

        /// <summary>
        /// The base fee that must be used for incoming HTLC's to this particular
        /// <br/>channel. This value will be tacked onto the required for a payment
        /// <br/>independent of the size of the payment.
        /// </summary>
        [JsonProperty("base_fee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Base_fee { get; set; }

        /// <summary>
        /// The fee rate that will be charged per millionth of a satoshi.
        /// </summary>
        [JsonProperty("fee_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Fee_rate { get; set; }

        /// <summary>
        /// The maximum HTLC value which will be accepted.
        /// </summary>
        [JsonProperty("htlc_maximum_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Htlc_maximum_msat { get; set; }

        /// <summary>
        /// The set of data that was appended to this message, some of which we may
        /// <br/>not actually know how to iterate or parse. By holding onto this data, we
        /// <br/>ensure that we're able to properly validate the set of signatures that
        /// <br/>cover these new fields, and ensure we're able to make upgrades to the
        /// <br/>network in a forwards compatible manner.
        /// </summary>
        [JsonProperty("extra_opaque_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Extra_opaque_data { get; set; }

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

        public static LnrpcChannelUpdate FromJson(string data)
        {
            return JsonConvert.DeserializeObject<LnrpcChannelUpdate>(data, new JsonSerializerSettings());
        }
    }
}

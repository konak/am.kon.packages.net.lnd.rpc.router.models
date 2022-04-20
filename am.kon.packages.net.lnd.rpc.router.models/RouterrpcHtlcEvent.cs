
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcHtlcEvent
    {
        /// <summary>
        /// The short channel id that the incoming htlc arrived at our node on. This
        /// <br/>value is zero for sends.
        /// </summary>
        [JsonProperty("incoming_channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Incoming_channel_id { get; set; }

        /// <summary>
        /// The short channel id that the outgoing htlc left our node on. This value
        /// <br/>is zero for receives.
        /// </summary>
        [JsonProperty("outgoing_channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Outgoing_channel_id { get; set; }

        /// <summary>
        /// Incoming id is the index of the incoming htlc in the incoming channel.
        /// <br/>This value is zero for sends.
        /// </summary>
        [JsonProperty("incoming_htlc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Incoming_htlc_id { get; set; }

        /// <summary>
        /// Outgoing id is the index of the outgoing htlc in the outgoing channel.
        /// <br/>This value is zero for receives.
        /// </summary>
        [JsonProperty("outgoing_htlc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Outgoing_htlc_id { get; set; }

        /// <summary>
        /// The time in unix nanoseconds that the event occurred.
        /// </summary>
        [JsonProperty("timestamp_ns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp_ns { get; set; }

        /// <summary>
        /// The event type indicates whether the htlc was part of a send, receive or
        /// <br/>forward.
        /// </summary>
        [JsonProperty("event_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public RouterrpcHtlcEventEventType? Event_type { get; set; }

        [JsonProperty("forward_event", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RouterrpcForwardEvent Forward_event { get; set; }

        [JsonProperty("forward_fail_event", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RouterrpcForwardFailEvent Forward_fail_event { get; set; }

        [JsonProperty("settle_event", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RouterrpcSettleEvent Settle_event { get; set; }

        [JsonProperty("link_fail_event", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RouterrpcLinkFailEvent Link_fail_event { get; set; }

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

        public static RouterrpcHtlcEvent FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcHtlcEvent>(data, new JsonSerializerSettings());
        }
    }
}

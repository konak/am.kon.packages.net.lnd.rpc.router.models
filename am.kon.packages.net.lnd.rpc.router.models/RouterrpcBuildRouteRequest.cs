using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcBuildRouteRequest
    {
        /// <summary>
        /// The amount to send expressed in msat. If set to zero, the minimum routable
        /// <br/>amount is used.
        /// </summary>
        [JsonProperty("amt_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Amt_msat { get; set; }

        [JsonProperty("final_cltv_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Final_cltv_delta { get; set; }

        /// <summary>
        /// The channel id of the channel that must be taken to the first hop. If zero,
        /// <br/>any channel may be used.
        /// </summary>
        [JsonProperty("outgoing_chan_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Outgoing_chan_id { get; set; }

        /// <summary>
        /// A list of hops that defines the route. This does not include the source hop
        /// <br/>pubkey.
        /// </summary>
        [JsonProperty("hop_pubkeys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<byte[]> Hop_pubkeys { get; set; }

        /// <summary>
        /// An optional payment addr to be included within the last hop of the route.
        /// </summary>
        [JsonProperty("payment_addr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Payment_addr { get; set; }

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

        public static RouterrpcBuildRouteRequest FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcBuildRouteRequest>(data, new JsonSerializerSettings());
        }
    }
}

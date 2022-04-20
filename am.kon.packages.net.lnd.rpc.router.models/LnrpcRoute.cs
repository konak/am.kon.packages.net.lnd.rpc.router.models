using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    /// <summary>
    /// A path through the channel graph which runs over one or more channels in
    /// <br/>succession. This struct carries all the information required to craft the
    /// <br/>Sphinx onion packet, and send the payment along the first hop in the path. A
    /// <br/>route is only selected as valid if all the channels have sufficient capacity to
    /// <br/>carry the initial payment amount after fees are accounted for.
    /// </summary>
    public class LnrpcRoute
    {
        /// <summary>
        /// The cumulative (final) time lock across the entire route. This is the CLTV
        /// <br/>value that should be extended to the first hop in the route. All other hops
        /// <br/>will decrement the time-lock as advertised, leaving enough time for all
        /// <br/>hops to wait for or present the payment preimage to complete the payment.
        /// </summary>
        [JsonProperty("total_time_lock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Total_time_lock { get; set; }

        /// <summary>
        /// The sum of the fees paid at each hop within the final route. In the case
        /// <br/>of a one-hop payment, this value will be zero as we don't need to pay a fee
        /// <br/>to ourselves.
        /// </summary>
        [JsonProperty("total_fees", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Total_fees { get; set; }

        /// <summary>
        /// The total amount of funds required to complete a payment over this route.
        /// <br/>This value includes the cumulative fees at each hop. As a result, the HTLC
        /// <br/>extended to the first-hop in the route will need to have at least this many
        /// <br/>satoshis, otherwise the route will fail at an intermediate node due to an
        /// <br/>insufficient amount of fees.
        /// </summary>
        [JsonProperty("total_amt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Total_amt { get; set; }

        /// <summary>
        /// Contains details concerning the specific forwarding details at each hop.
        /// </summary>
        [JsonProperty("hops", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<LnrpcHop> Hops { get; set; }

        /// <summary>
        /// The total fees in millisatoshis.
        /// </summary>
        [JsonProperty("total_fees_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Total_fees_msat { get; set; }

        /// <summary>
        /// The total amount in millisatoshis.
        /// </summary>
        [JsonProperty("total_amt_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Total_amt_msat { get; set; }

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

        public static LnrpcRoute FromJson(string data)
        {
            return JsonConvert.DeserializeObject<LnrpcRoute>(data, new JsonSerializerSettings());
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class LnrpcMPPRecord
    {
        /// <summary>
        /// A unique, random identifier used to authenticate the sender as the intended
        /// <br/>payer of a multi-path payment. The payment_addr must be the same for all
        /// <br/>subpayments, and match the payment_addr provided in the receiver's invoice.
        /// <br/>The same payment_addr must be used on all subpayments.
        /// </summary>
        [JsonProperty("payment_addr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Payment_addr { get; set; }

        /// <summary>
        /// The total amount in milli-satoshis being sent as part of a larger multi-path
        /// <br/>payment. The caller is responsible for ensuring subpayments to the same node
        /// <br/>and payment_hash sum exactly to total_amt_msat. The same
        /// <br/>total_amt_msat must be used on all subpayments.
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

        public static LnrpcMPPRecord FromJson(string data)
        {
            return JsonConvert.DeserializeObject<LnrpcMPPRecord>(data, new JsonSerializerSettings());
        }
    }
}

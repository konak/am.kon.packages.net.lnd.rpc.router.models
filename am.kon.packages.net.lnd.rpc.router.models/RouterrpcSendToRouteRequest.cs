using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcSendToRouteRequest
    {
        /// <summary>
        /// The payment hash to use for the HTLC.
        /// </summary>
        [JsonProperty("payment_hash", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Payment_hash { get; set; }

        /// <summary>
        /// Route that should be used to attempt to complete the payment.
        /// </summary>
        [JsonProperty("route", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LnrpcRoute Route { get; set; }

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

        public static RouterrpcSendToRouteRequest FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcSendToRouteRequest>(data, new JsonSerializerSettings());
        }
    }
}

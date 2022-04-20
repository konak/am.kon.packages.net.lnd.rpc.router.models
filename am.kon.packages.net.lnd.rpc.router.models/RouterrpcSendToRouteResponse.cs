using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcSendToRouteResponse
    {
        /// <summary>
        /// The preimage obtained by making the payment.
        /// </summary>
        [JsonProperty("preimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Preimage { get; set; }

        /// <summary>
        /// The failure message in case the payment failed.
        /// </summary>
        [JsonProperty("failure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LnrpcFailure Failure { get; set; }

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

        public static RouterrpcSendToRouteResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcSendToRouteResponse>(data, new JsonSerializerSettings());
        }
    }
}

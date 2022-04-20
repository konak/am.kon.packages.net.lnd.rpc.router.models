using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcBuildRouteResponse
    {
        /// <summary>
        /// Fully specified route that can be used to execute the payment.
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

        public static RouterrpcBuildRouteResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcBuildRouteResponse>(data, new JsonSerializerSettings());
        }
    }
}

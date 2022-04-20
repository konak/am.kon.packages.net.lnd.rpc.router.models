using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcQueryProbabilityResponse
    {
        /// <summary>
        /// The success probability for the requested pair.
        /// </summary>
        [JsonProperty("probability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Probability { get; set; }

        /// <summary>
        /// The historical data for the requested pair.
        /// </summary>
        [JsonProperty("history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RouterrpcPairData History { get; set; }

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

        public static RouterrpcQueryProbabilityResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcQueryProbabilityResponse>(data, new JsonSerializerSettings());
        }
    }
}

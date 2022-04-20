using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    /// <summary>
    /// QueryMissionControlResponse contains mission control state.
    /// </summary>
    public class RouterrpcQueryMissionControlResponse
    {
        /// <summary>
        /// Node pair-level mission control state.
        /// </summary>
        [JsonProperty("pairs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<RouterrpcPairHistory> Pairs { get; set; }

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

        public static RouterrpcQueryMissionControlResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcQueryMissionControlResponse>(data, new JsonSerializerSettings());
        }
    }
}

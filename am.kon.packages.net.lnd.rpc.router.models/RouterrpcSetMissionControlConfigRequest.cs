using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcSetMissionControlConfigRequest
    {
        /// <summary>
        /// The config to set for mission control. Note that all values *must* be set,
        /// <br/>because the full config will be applied.
        /// </summary>
        [JsonProperty("config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RouterrpcMissionControlConfig Config { get; set; }

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

        public static RouterrpcSetMissionControlConfigRequest FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcSetMissionControlConfigRequest>(data, new JsonSerializerSettings());
        }
    }
}

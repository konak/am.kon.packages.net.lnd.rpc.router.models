using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcGetMissionControlConfigResponse
    {
        /// <summary>
        /// Mission control's currently active config.
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

        public static RouterrpcGetMissionControlConfigResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcGetMissionControlConfigResponse>(data, new JsonSerializerSettings());
        }
    }
}

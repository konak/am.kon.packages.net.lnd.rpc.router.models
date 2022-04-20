using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcXImportMissionControlRequest
    {
        /// <summary>
        /// Node pair-level mission control state to be imported.
        /// </summary>
        [JsonProperty("pairs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<RouterrpcPairHistory> Pairs { get; set; }

        /// <summary>
        /// Whether to force override MC pair history. Note that even with force
        /// <br/>override the failure pair is imported before the success pair and both
        /// <br/>still clamp existing failure/success amounts.
        /// </summary>
        [JsonProperty("force", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

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

        public static RouterrpcXImportMissionControlRequest FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcXImportMissionControlRequest>(data, new JsonSerializerSettings());
        }
    }
}

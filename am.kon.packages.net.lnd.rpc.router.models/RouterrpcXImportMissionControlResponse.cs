using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcXImportMissionControlResponse
    {
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

        public static RouterrpcXImportMissionControlResponse FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcXImportMissionControlResponse>(data, new JsonSerializerSettings());
        }
    }
}

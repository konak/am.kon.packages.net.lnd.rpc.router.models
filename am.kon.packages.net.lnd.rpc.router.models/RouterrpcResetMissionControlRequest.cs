using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcResetMissionControlRequest
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

        public static RouterrpcResetMissionControlRequest FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcResetMissionControlRequest>(data, new JsonSerializerSettings());
        }
    }
}

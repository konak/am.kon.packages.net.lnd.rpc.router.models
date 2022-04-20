using Newtonsoft.Json;
using System.Collections.Generic;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class LnrpcAMPRecord
    {
        [JsonProperty("root_share", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Root_share { get; set; }

        [JsonProperty("set_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Set_id { get; set; }

        [JsonProperty("child_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Child_index { get; set; }

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

        public static LnrpcAMPRecord FromJson(string data)
        {
            return JsonConvert.DeserializeObject<LnrpcAMPRecord>(data, new JsonSerializerSettings());
        }
    }
}

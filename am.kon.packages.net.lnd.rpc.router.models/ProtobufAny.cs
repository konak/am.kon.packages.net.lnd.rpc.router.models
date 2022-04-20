using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class ProtobufAny
    {
        [JsonProperty("type_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type_url { get; set; }

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Value { get; set; }

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
        public static ProtobufAny FromJson(string data)
        {
            return JsonConvert.DeserializeObject<ProtobufAny>(data, new JsonSerializerSettings());
        }
    }
}

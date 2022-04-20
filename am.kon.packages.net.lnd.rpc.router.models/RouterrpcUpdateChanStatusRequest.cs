using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcUpdateChanStatusRequest
    {
        [JsonProperty("chan_point", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LnrpcChannelPoint Chan_point { get; set; }

        [JsonProperty("action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public RouterrpcChanStatusAction? Action { get; set; }

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

        public static RouterrpcUpdateChanStatusRequest FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcUpdateChanStatusRequest>(data, new JsonSerializerSettings());
        }
    }
}

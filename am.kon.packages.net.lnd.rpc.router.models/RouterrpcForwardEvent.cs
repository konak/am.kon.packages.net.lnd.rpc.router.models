using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcForwardEvent
    {
        /// <summary>
        /// Info contains details about the htlc that was forwarded.
        /// </summary>
        [JsonProperty("info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RouterrpcHtlcInfo Info { get; set; }

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

        public static RouterrpcForwardEvent FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcForwardEvent>(data, new JsonSerializerSettings());
        }
    }
}

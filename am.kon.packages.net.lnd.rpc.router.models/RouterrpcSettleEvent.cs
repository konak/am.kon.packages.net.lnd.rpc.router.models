using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcSettleEvent
    {
        /// <summary>
        /// The revealed preimage.
        /// </summary>
        [JsonProperty("preimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[] Preimage { get; set; }

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

        public static RouterrpcSettleEvent FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcSettleEvent>(data, new JsonSerializerSettings());
        }
    }
}
using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcCircuitKey
    {
        /// <summary>
        /// / The id of the channel that the is part of this circuit.
        /// </summary>
        [JsonProperty("chan_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Chan_id { get; set; }

        /// <summary>
        /// / The index of the incoming htlc in the incoming channel.
        /// </summary>
        [JsonProperty("htlc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Htlc_id { get; set; }

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

        public static RouterrpcCircuitKey FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcCircuitKey>(data, new JsonSerializerSettings());
        }
    }
}

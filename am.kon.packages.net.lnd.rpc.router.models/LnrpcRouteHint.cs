using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class LnrpcRouteHint
    {
        /// <summary>
        /// A list of hop hints that when chained together can assist in reaching a
        /// <br/>specific destination.
        /// </summary>
        [JsonProperty("hop_hints", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<LnrpcHopHint> Hop_hints { get; set; }

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

        public static LnrpcRouteHint FromJson(string data)
        {
            return JsonConvert.DeserializeObject<LnrpcRouteHint>(data, new JsonSerializerSettings());
        }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcPairData
    {
        /// <summary>
        /// Time of last failure.
        /// </summary>
        [JsonProperty("fail_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fail_time { get; set; }

        /// <summary>
        /// Lowest amount that failed to forward rounded to whole sats. This may be
        /// <br/>set to zero if the failure is independent of amount.
        /// </summary>
        [JsonProperty("fail_amt_sat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fail_amt_sat { get; set; }

        /// <summary>
        /// Lowest amount that failed to forward in millisats. This may be
        /// <br/>set to zero if the failure is independent of amount.
        /// </summary>
        [JsonProperty("fail_amt_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Fail_amt_msat { get; set; }

        /// <summary>
        /// Time of last success.
        /// </summary>
        [JsonProperty("success_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Success_time { get; set; }

        /// <summary>
        /// Highest amount that we could successfully forward rounded to whole sats.
        /// </summary>
        [JsonProperty("success_amt_sat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Success_amt_sat { get; set; }

        /// <summary>
        /// Highest amount that we could successfully forward in millisats.
        /// </summary>
        [JsonProperty("success_amt_msat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Success_amt_msat { get; set; }

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

        public static RouterrpcPairData FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcPairData>(data, new JsonSerializerSettings());
        }
    }
}

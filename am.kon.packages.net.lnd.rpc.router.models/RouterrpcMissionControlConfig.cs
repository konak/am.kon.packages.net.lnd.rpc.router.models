using System.Collections.Generic;
using Newtonsoft.Json;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcMissionControlConfig
    {
        /// <summary>
        /// The amount of time mission control will take to restore a penalized node
        /// <br/>or channel back to 50% success probability, expressed in seconds. Setting
        /// <br/>this value to a higher value will penalize failures for longer, making
        /// <br/>mission control less likely to route through nodes and channels that we
        /// <br/>have previously recorded failures for.
        /// </summary>
        [JsonProperty("half_life_seconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Half_life_seconds { get; set; }

        /// <summary>
        /// The probability of success mission control should assign to hop in a route
        /// <br/>where it has no other information available. Higher values will make mission
        /// <br/>control more willing to try hops that we have no information about, lower
        /// <br/>values will discourage trying these hops.
        /// </summary>
        [JsonProperty("hop_probability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Hop_probability { get; set; }

        /// <summary>
        /// The importance that mission control should place on historical results,
        /// <br/>expressed as a value in [0;1]. Setting this value to 1 will ignore all
        /// <br/>historical payments and just use the hop probability to assess the
        /// <br/>probability of success for each hop. A zero value ignores hop probability
        /// <br/>completely and relies entirely on historical results, unless none are
        /// <br/>available.
        /// </summary>
        [JsonProperty("weight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public float? Weight { get; set; }

        /// <summary>
        /// The maximum number of payment results that mission control will store.
        /// </summary>
        [JsonProperty("maximum_payment_results", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Maximum_payment_results { get; set; }

        /// <summary>
        /// The minimum time that must have passed since the previously recorded failure
        /// <br/>before we raise the failure amount.
        /// </summary>
        [JsonProperty("minimum_failure_relax_interval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Minimum_failure_relax_interval { get; set; }

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

        public static RouterrpcMissionControlConfig FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcMissionControlConfig>(data, new JsonSerializerSettings());
        }
    }
}


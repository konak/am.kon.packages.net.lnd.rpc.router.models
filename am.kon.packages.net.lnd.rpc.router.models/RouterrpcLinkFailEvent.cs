using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace am.kon.packages.net.lnd.rpc.router
{
    public class RouterrpcLinkFailEvent
    {
        /// <summary>
        /// Info contains details about the htlc that we failed.
        /// </summary>
        [JsonProperty("info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RouterrpcHtlcInfo Info { get; set; }

        /// <summary>
        /// FailureCode is the BOLT error code for the failure.
        /// </summary>
        [JsonProperty("wire_failure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public FailureFailureCode? Wire_failure { get; set; }

        /// <summary>
        /// FailureDetail provides additional information about the reason for the
        /// <br/>failure. This detail enriches the information provided by the wire message
        /// <br/>and may be 'no detail' if the wire message requires no additional metadata.
        /// </summary>
        [JsonProperty("failure_detail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(StringEnumConverter))]
        public RouterrpcFailureDetail? Failure_detail { get; set; }

        /// <summary>
        /// A string representation of the link failure.
        /// </summary>
        [JsonProperty("failure_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Failure_string { get; set; }

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

        public static RouterrpcLinkFailEvent FromJson(string data)
        {
            return JsonConvert.DeserializeObject<RouterrpcLinkFailEvent>(data, new JsonSerializerSettings());
        }
    }
}

using System.Runtime.Serialization;

namespace am.kon.packages.net.lnd.rpc.router
{
    public enum LnrpcPaymentPaymentStatus
    {
        [EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 0,

        [EnumMember(Value = @"IN_FLIGHT")]
        IN_FLIGHT = 1,

        [EnumMember(Value = @"SUCCEEDED")]
        SUCCEEDED = 2,

        [EnumMember(Value = @"FAILED")]
        FAILED = 3,
    }
}

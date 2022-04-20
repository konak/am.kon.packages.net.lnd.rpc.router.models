using System.Runtime.Serialization;

namespace am.kon.packages.net.lnd.rpc.router
{
    public enum HTLCAttemptHTLCStatus
    {
        [EnumMember(Value = @"IN_FLIGHT")]
        IN_FLIGHT = 0,

        [EnumMember(Value = @"SUCCEEDED")]
        SUCCEEDED = 1,

        [EnumMember(Value = @"FAILED")]
        FAILED = 2,
    }
}

using System.Runtime.Serialization;

namespace am.kon.packages.net.lnd.rpc.router
{
    public enum RouterrpcHtlcEventEventType
    {
        [EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 0,

        [EnumMember(Value = @"SEND")]
        SEND = 1,

        [EnumMember(Value = @"RECEIVE")]
        RECEIVE = 2,

        [EnumMember(Value = @"FORWARD")]
        FORWARD = 3,
    }
}

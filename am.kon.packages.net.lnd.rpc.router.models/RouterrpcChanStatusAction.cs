using System.Runtime.Serialization;

namespace am.kon.packages.net.lnd.rpc.router
{
    public enum RouterrpcChanStatusAction
    {
        [EnumMember(Value = @"ENABLE")]
        ENABLE = 0,

        [EnumMember(Value = @"DISABLE")]
        DISABLE = 1,

        [EnumMember(Value = @"AUTO")]
        AUTO = 2,
    }
}

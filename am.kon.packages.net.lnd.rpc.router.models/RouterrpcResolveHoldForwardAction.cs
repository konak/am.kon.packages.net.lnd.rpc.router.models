using System.Runtime.Serialization;

namespace am.kon.packages.net.lnd.rpc.router
{
    public enum RouterrpcResolveHoldForwardAction
    {
        [EnumMember(Value = @"SETTLE")]
        SETTLE = 0,

        [EnumMember(Value = @"FAIL")]
        FAIL = 1,

        [EnumMember(Value = @"RESUME")]
        RESUME = 2,
    }
}

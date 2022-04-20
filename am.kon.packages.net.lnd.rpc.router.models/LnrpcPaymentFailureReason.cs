using System.Runtime.Serialization;

namespace am.kon.packages.net.lnd.rpc.router
{
    /// <summary>
    ///  - FAILURE_REASON_NONE: Payment isn't failed (yet).
    /// <br/> - FAILURE_REASON_TIMEOUT: There are more routes to try, but the payment timeout was exceeded.
    /// <br/> - FAILURE_REASON_NO_ROUTE: All possible routes were tried and failed permanently. Or were no
    /// <br/>routes to the destination at all.
    /// <br/> - FAILURE_REASON_ERROR: A non-recoverable error has occured.
    /// <br/> - FAILURE_REASON_INCORRECT_PAYMENT_DETAILS: Payment details incorrect (unknown hash, invalid amt or
    /// <br/>invalid final cltv delta)
    /// <br/> - FAILURE_REASON_INSUFFICIENT_BALANCE: Insufficient local balance.
    /// </summary>
    public enum LnrpcPaymentFailureReason
    {
        [EnumMember(Value = @"FAILURE_REASON_NONE")]
        FAILURE_REASON_NONE = 0,

        [EnumMember(Value = @"FAILURE_REASON_TIMEOUT")]
        FAILURE_REASON_TIMEOUT = 1,

        [EnumMember(Value = @"FAILURE_REASON_NO_ROUTE")]
        FAILURE_REASON_NO_ROUTE = 2,

        [EnumMember(Value = @"FAILURE_REASON_ERROR")]
        FAILURE_REASON_ERROR = 3,

        [EnumMember(Value = @"FAILURE_REASON_INCORRECT_PAYMENT_DETAILS")]
        FAILURE_REASON_INCORRECT_PAYMENT_DETAILS = 4,

        [EnumMember(Value = @"FAILURE_REASON_INSUFFICIENT_BALANCE")]
        FAILURE_REASON_INSUFFICIENT_BALANCE = 5,
    }
}

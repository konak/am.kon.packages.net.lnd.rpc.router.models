using System.Runtime.Serialization;

namespace am.kon.packages.net.lnd.rpc.router
{
    /// <summary>
    ///  - IN_FLIGHT: Payment is still in flight.
    /// <br/> - SUCCEEDED: Payment completed successfully.
    /// <br/> - FAILED_TIMEOUT: There are more routes to try, but the payment timeout was exceeded.
    /// <br/> - FAILED_NO_ROUTE: All possible routes were tried and failed permanently. Or were no
    /// <br/>routes to the destination at all.
    /// <br/> - FAILED_ERROR: A non-recoverable error has occured.
    /// <br/> - FAILED_INCORRECT_PAYMENT_DETAILS: Payment details incorrect (unknown hash, invalid amt or
    /// <br/>invalid final cltv delta)
    /// <br/> - FAILED_INSUFFICIENT_BALANCE: Insufficient local balance.
    /// </summary>
    public enum RouterrpcPaymentState
    {
        [EnumMember(Value = @"IN_FLIGHT")]
        IN_FLIGHT = 0,

        [EnumMember(Value = @"SUCCEEDED")]
        SUCCEEDED = 1,

        [EnumMember(Value = @"FAILED_TIMEOUT")]
        FAILED_TIMEOUT = 2,

        [EnumMember(Value = @"FAILED_NO_ROUTE")]
        FAILED_NO_ROUTE = 3,

        [EnumMember(Value = @"FAILED_ERROR")]
        FAILED_ERROR = 4,

        [EnumMember(Value = @"FAILED_INCORRECT_PAYMENT_DETAILS")]
        FAILED_INCORRECT_PAYMENT_DETAILS = 5,

        [EnumMember(Value = @"FAILED_INSUFFICIENT_BALANCE")]
        FAILED_INSUFFICIENT_BALANCE = 6,
    }
}

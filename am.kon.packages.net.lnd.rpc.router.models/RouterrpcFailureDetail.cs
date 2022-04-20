using System.Runtime.Serialization;

namespace am.kon.packages.net.lnd.rpc.router
{
    public enum RouterrpcFailureDetail
    {
        [EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 0,

        [EnumMember(Value = @"NO_DETAIL")]
        NO_DETAIL = 1,

        [EnumMember(Value = @"ONION_DECODE")]
        ONION_DECODE = 2,

        [EnumMember(Value = @"LINK_NOT_ELIGIBLE")]
        LINK_NOT_ELIGIBLE = 3,

        [EnumMember(Value = @"ON_CHAIN_TIMEOUT")]
        ON_CHAIN_TIMEOUT = 4,

        [EnumMember(Value = @"HTLC_EXCEEDS_MAX")]
        HTLC_EXCEEDS_MAX = 5,

        [EnumMember(Value = @"INSUFFICIENT_BALANCE")]
        INSUFFICIENT_BALANCE = 6,

        [EnumMember(Value = @"INCOMPLETE_FORWARD")]
        INCOMPLETE_FORWARD = 7,

        [EnumMember(Value = @"HTLC_ADD_FAILED")]
        HTLC_ADD_FAILED = 8,

        [EnumMember(Value = @"FORWARDS_DISABLED")]
        FORWARDS_DISABLED = 9,

        [EnumMember(Value = @"INVOICE_CANCELED")]
        INVOICE_CANCELED = 10,

        [EnumMember(Value = @"INVOICE_UNDERPAID")]
        INVOICE_UNDERPAID = 11,

        [EnumMember(Value = @"INVOICE_EXPIRY_TOO_SOON")]
        INVOICE_EXPIRY_TOO_SOON = 12,

        [EnumMember(Value = @"INVOICE_NOT_OPEN")]
        INVOICE_NOT_OPEN = 13,

        [EnumMember(Value = @"MPP_INVOICE_TIMEOUT")]
        MPP_INVOICE_TIMEOUT = 14,

        [EnumMember(Value = @"ADDRESS_MISMATCH")]
        ADDRESS_MISMATCH = 15,

        [EnumMember(Value = @"SET_TOTAL_MISMATCH")]
        SET_TOTAL_MISMATCH = 16,

        [EnumMember(Value = @"SET_TOTAL_TOO_LOW")]
        SET_TOTAL_TOO_LOW = 17,

        [EnumMember(Value = @"SET_OVERPAID")]
        SET_OVERPAID = 18,

        [EnumMember(Value = @"UNKNOWN_INVOICE")]
        UNKNOWN_INVOICE = 19,

        [EnumMember(Value = @"INVALID_KEYSEND")]
        INVALID_KEYSEND = 20,

        [EnumMember(Value = @"MPP_IN_PROGRESS")]
        MPP_IN_PROGRESS = 21,

        [EnumMember(Value = @"CIRCULAR_ROUTE")]
        CIRCULAR_ROUTE = 22,
    }
}

using System.Runtime.Serialization;

namespace am.kon.packages.net.lnd.rpc.router
{
    /// <summary>
    ///  - RESERVED: The numbers assigned in this enumeration match the failure codes as
    /// <br/>defined in BOLT #4. Because protobuf 3 requires enums to start with 0,
    /// <br/>a RESERVED value is added.
    /// <br/> - INTERNAL_FAILURE: An internal error occurred.
    /// <br/> - UNKNOWN_FAILURE: The error source is known, but the failure itself couldn't be decoded.
    /// <br/> - UNREADABLE_FAILURE: An unreadable failure result is returned if the received failure message
    /// <br/>cannot be decrypted. In that case the error source is unknown.
    /// </summary>
    public enum FailureFailureCode
    {
        [EnumMember(Value = @"RESERVED")]
        RESERVED = 0,

        [EnumMember(Value = @"INCORRECT_OR_UNKNOWN_PAYMENT_DETAILS")]
        INCORRECT_OR_UNKNOWN_PAYMENT_DETAILS = 1,

        [EnumMember(Value = @"INCORRECT_PAYMENT_AMOUNT")]
        INCORRECT_PAYMENT_AMOUNT = 2,

        [EnumMember(Value = @"FINAL_INCORRECT_CLTV_EXPIRY")]
        FINAL_INCORRECT_CLTV_EXPIRY = 3,

        [EnumMember(Value = @"FINAL_INCORRECT_HTLC_AMOUNT")]
        FINAL_INCORRECT_HTLC_AMOUNT = 4,

        [EnumMember(Value = @"FINAL_EXPIRY_TOO_SOON")]
        FINAL_EXPIRY_TOO_SOON = 5,

        [EnumMember(Value = @"INVALID_REALM")]
        INVALID_REALM = 6,

        [EnumMember(Value = @"EXPIRY_TOO_SOON")]
        EXPIRY_TOO_SOON = 7,

        [EnumMember(Value = @"INVALID_ONION_VERSION")]
        INVALID_ONION_VERSION = 8,

        [EnumMember(Value = @"INVALID_ONION_HMAC")]
        INVALID_ONION_HMAC = 9,

        [EnumMember(Value = @"INVALID_ONION_KEY")]
        INVALID_ONION_KEY = 10,

        [EnumMember(Value = @"AMOUNT_BELOW_MINIMUM")]
        AMOUNT_BELOW_MINIMUM = 11,

        [EnumMember(Value = @"FEE_INSUFFICIENT")]
        FEE_INSUFFICIENT = 12,

        [EnumMember(Value = @"INCORRECT_CLTV_EXPIRY")]
        INCORRECT_CLTV_EXPIRY = 13,

        [EnumMember(Value = @"CHANNEL_DISABLED")]
        CHANNEL_DISABLED = 14,

        [EnumMember(Value = @"TEMPORARY_CHANNEL_FAILURE")]
        TEMPORARY_CHANNEL_FAILURE = 15,

        [EnumMember(Value = @"REQUIRED_NODE_FEATURE_MISSING")]
        REQUIRED_NODE_FEATURE_MISSING = 16,

        [EnumMember(Value = @"REQUIRED_CHANNEL_FEATURE_MISSING")]
        REQUIRED_CHANNEL_FEATURE_MISSING = 17,

        [EnumMember(Value = @"UNKNOWN_NEXT_PEER")]
        UNKNOWN_NEXT_PEER = 18,

        [EnumMember(Value = @"TEMPORARY_NODE_FAILURE")]
        TEMPORARY_NODE_FAILURE = 19,

        [EnumMember(Value = @"PERMANENT_NODE_FAILURE")]
        PERMANENT_NODE_FAILURE = 20,

        [EnumMember(Value = @"PERMANENT_CHANNEL_FAILURE")]
        PERMANENT_CHANNEL_FAILURE = 21,

        [EnumMember(Value = @"EXPIRY_TOO_FAR")]
        EXPIRY_TOO_FAR = 22,

        [EnumMember(Value = @"MPP_TIMEOUT")]
        MPP_TIMEOUT = 23,

        [EnumMember(Value = @"INVALID_ONION_PAYLOAD")]
        INVALID_ONION_PAYLOAD = 24,

        [EnumMember(Value = @"INTERNAL_FAILURE")]
        INTERNAL_FAILURE = 25,

        [EnumMember(Value = @"UNKNOWN_FAILURE")]
        UNKNOWN_FAILURE = 26,

        [EnumMember(Value = @"UNREADABLE_FAILURE")]
        UNREADABLE_FAILURE = 27,
    }
}

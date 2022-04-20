using System.Runtime.Serialization;

namespace am.kon.packages.net.lnd.rpc.router
{
    public enum LnrpcFeatureBit
    {
        [EnumMember(Value = @"DATALOSS_PROTECT_REQ")]
        DATALOSS_PROTECT_REQ = 0,

        [EnumMember(Value = @"DATALOSS_PROTECT_OPT")]
        DATALOSS_PROTECT_OPT = 1,

        [EnumMember(Value = @"INITIAL_ROUING_SYNC")]
        INITIAL_ROUING_SYNC = 2,

        [EnumMember(Value = @"UPFRONT_SHUTDOWN_SCRIPT_REQ")]
        UPFRONT_SHUTDOWN_SCRIPT_REQ = 3,

        [EnumMember(Value = @"UPFRONT_SHUTDOWN_SCRIPT_OPT")]
        UPFRONT_SHUTDOWN_SCRIPT_OPT = 4,

        [EnumMember(Value = @"GOSSIP_QUERIES_REQ")]
        GOSSIP_QUERIES_REQ = 5,

        [EnumMember(Value = @"GOSSIP_QUERIES_OPT")]
        GOSSIP_QUERIES_OPT = 6,

        [EnumMember(Value = @"TLV_ONION_REQ")]
        TLV_ONION_REQ = 7,

        [EnumMember(Value = @"TLV_ONION_OPT")]
        TLV_ONION_OPT = 8,

        [EnumMember(Value = @"EXT_GOSSIP_QUERIES_REQ")]
        EXT_GOSSIP_QUERIES_REQ = 9,

        [EnumMember(Value = @"EXT_GOSSIP_QUERIES_OPT")]
        EXT_GOSSIP_QUERIES_OPT = 10,

        [EnumMember(Value = @"STATIC_REMOTE_KEY_REQ")]
        STATIC_REMOTE_KEY_REQ = 11,

        [EnumMember(Value = @"STATIC_REMOTE_KEY_OPT")]
        STATIC_REMOTE_KEY_OPT = 12,

        [EnumMember(Value = @"PAYMENT_ADDR_REQ")]
        PAYMENT_ADDR_REQ = 13,

        [EnumMember(Value = @"PAYMENT_ADDR_OPT")]
        PAYMENT_ADDR_OPT = 14,

        [EnumMember(Value = @"MPP_REQ")]
        MPP_REQ = 15,

        [EnumMember(Value = @"MPP_OPT")]
        MPP_OPT = 16,

        [EnumMember(Value = @"WUMBO_CHANNELS_REQ")]
        WUMBO_CHANNELS_REQ = 17,

        [EnumMember(Value = @"WUMBO_CHANNELS_OPT")]
        WUMBO_CHANNELS_OPT = 18,

        [EnumMember(Value = @"ANCHORS_REQ")]
        ANCHORS_REQ = 19,

        [EnumMember(Value = @"ANCHORS_OPT")]
        ANCHORS_OPT = 20,

        [EnumMember(Value = @"ANCHORS_ZERO_FEE_HTLC_REQ")]
        ANCHORS_ZERO_FEE_HTLC_REQ = 21,

        [EnumMember(Value = @"ANCHORS_ZERO_FEE_HTLC_OPT")]
        ANCHORS_ZERO_FEE_HTLC_OPT = 22,

        [EnumMember(Value = @"AMP_REQ")]
        AMP_REQ = 23,

        [EnumMember(Value = @"AMP_OPT")]
        AMP_OPT = 24,
    }
}

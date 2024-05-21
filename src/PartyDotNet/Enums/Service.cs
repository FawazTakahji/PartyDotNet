using System.Runtime.Serialization;

namespace PartyDotNet.Enums;

public enum Service
{
    Unknown = 0,

    // Kemono Services
    [EnumMember(Value = "afdian")]
    Afdian = 1,

    [EnumMember(Value = "boosty")]
    Boosty = 2,

    [EnumMember(Value = "dlsite")]
    DLsite = 3,

    [EnumMember(Value = "discord")]
    Discord = 4,

    [EnumMember(Value = "fanbox")]
    Fanbox = 5,

    [EnumMember(Value = "fantia")]
    Fantia = 6,

    [EnumMember(Value = "gumroad")]
    Gumroad = 7,

    [EnumMember(Value = "patreon")]
    Patreon = 8,

    [EnumMember(Value = "subscribestar")]
    SubscribeStar = 9,

    // Coomer Services
    [EnumMember(Value = "candfans")]
    CandFans = 10,

    [EnumMember(Value = "fansly")]
    Fansly = 11,

    [EnumMember(Value = "onlyfans")]
    OnlyFans = 12
}
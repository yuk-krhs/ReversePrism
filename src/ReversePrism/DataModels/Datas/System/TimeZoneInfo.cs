using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 lazyHaveRegistry                         Lazy`1<bool> IL2CPP_TYPE_GENERICINST
    // 010 Id                                       000186672F10 ModelPrimitiveType string string string String
    // 018 DisplayName                              000186672F10 ModelPrimitiveType string string string String
    // 020 StandardDisplayName                      000186672F10 ModelPrimitiveType string string string String
    // 028 DaylightDisplayName                      000186672F10 ModelPrimitiveType string string string String
    // 030 BaseUtcOffset                            00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 038 SupportsDaylightSavingTime               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 040 AdjustmentRules                          000185B87180 ModelClassListType AdjustmentRule[] AdjustmentRule[] List<AdjustmentRule> Pointer
    // 008 s_utcTimeZone                            TimeZoneInfo IL2CPP_TYPE_CLASS
    // 010 S_cachedData                             000186609410 ModelClassType CachedData CachedData CachedData Pointer
    // 018 S_maxDateOnly                            0001865BA6C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 S_minDateOnly                            0001865BA6C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 MaxOffset                                00018668BA00 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 030 MinOffset                                00018668BA00 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    public partial class TimeZoneInfo
    {
        public string                                   Id                                      { get; set; }
        public string                                   DisplayName                             { get; set; }
        public string                                   StandardDisplayName                     { get; set; }
        public string                                   DaylightDisplayName                     { get; set; }
        public TimeSpan                                 BaseUtcOffset                           { get; set; }
        public bool                                     SupportsDaylightSavingTime              { get; set; }
        public List<AdjustmentRule>?                    AdjustmentRules                         { get; set; }
        public CachedData?                              S_cachedData                            { get; set; }
        public DateTime                                 S_maxDateOnly                           { get; set; }
        public DateTime                                 S_minDateOnly                           { get; set; }
        public TimeSpan                                 MaxOffset                               { get; set; }
        public TimeSpan                                 MinOffset                               { get; set; }

        public static TimeZoneInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeZoneInfo();

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 027003CA71E8 0x10 Id                          ( 000186672F10 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x018)); // 027003CA7208 0x18 DisplayName                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.StandardDisplayName                       = GetString(new IntPtr(p + 0x020)); // 027003CA7228 0x20 StandardDisplayName         ( 000186672F10 ModelPrimitiveType string string string String )
            value.DaylightDisplayName                       = GetString(new IntPtr(p + 0x028)); // 027003CA7248 0x28 DaylightDisplayName         ( 000186672F10 ModelPrimitiveType string string string String )
            value.BaseUtcOffset                             = (TimeSpan)GetInt32(new IntPtr(p + 0x030)); // 027003CA7268 0x30 BaseUtcOffset               ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.SupportsDaylightSavingTime                = GetBool(new IntPtr(p + 0x038)); // 027003CA7288 0x38 SupportsDaylightSavingTime  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.AdjustmentRules                           = GetObjectList<AdjustmentRule>(new IntPtr(p + 0x040), ReversePrism.DataModels.AdjustmentRule.FromPointer); // 027003CA72A8 0x40 AdjustmentRules             ( 000185B87180 ModelClassListType AdjustmentRule[] AdjustmentRule[] List<AdjustmentRule> Pointer )
            value.S_cachedData                              = GetObject<CachedData>(new IntPtr(p + 0x010), ReversePrism.DataModels.CachedData.FromPointer); // 027003CA72E8 0x10 S_cachedData                ( 000186609410 ModelClassType CachedData CachedData CachedData Pointer )
            value.S_maxDateOnly                             = GetDateTime(new IntPtr(p + 0x018)); // 027003CA7308 0x18 S_maxDateOnly               ( 0001865BA6C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.S_minDateOnly                             = GetDateTime(new IntPtr(p + 0x020)); // 027003CA7328 0x20 S_minDateOnly               ( 0001865BA6C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.MaxOffset                                 = (TimeSpan)GetInt32(new IntPtr(p + 0x028)); // 027003CA7348 0x28 MaxOffset                   ( 00018668BA00 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.MinOffset                                 = (TimeSpan)GetInt32(new IntPtr(p + 0x030)); // 027003CA7368 0x30 MinOffset                   ( 00018668BA00 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )

            return value;
        }
    }
}

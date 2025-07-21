using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 lazyHaveRegistry                         Lazy`1<bool> IL2CPP_TYPE_GENERICINST
    // 010 Id                                       ModelPrimitiveType string string string String
    // 018 DisplayName                              ModelPrimitiveType string string string String
    // 020 StandardDisplayName                      ModelPrimitiveType string string string String
    // 028 DaylightDisplayName                      ModelPrimitiveType string string string String
    // 030 BaseUtcOffset                            ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 038 SupportsDaylightSavingTime               ModelPrimitiveType bool bool bool Bool
    // 040 AdjustmentRules                          ModelClassListType AdjustmentRule[] AdjustmentRule[] List<AdjustmentRule> Pointer
    // 008 s_utcTimeZone                            TimeZoneInfo IL2CPP_TYPE_CLASS
    // 010 S_cachedData                             ModelClassType CachedData CachedData CachedData Pointer
    // 018 S_maxDateOnly                            ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 S_minDateOnly                            ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 028 MaxOffset                                ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 030 MinOffset                                ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    public partial class TimeZoneInfo : DataModel
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
            var value   = new TimeZoneInfo() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x018)); // 0x18 DisplayName                 ( ModelPrimitiveType string string string String )
            value.StandardDisplayName                       = GetString(new IntPtr(p + 0x020)); // 0x20 StandardDisplayName         ( ModelPrimitiveType string string string String )
            value.DaylightDisplayName                       = GetString(new IntPtr(p + 0x028)); // 0x28 DaylightDisplayName         ( ModelPrimitiveType string string string String )
            value.BaseUtcOffset                             = (TimeSpan)GetInt32(new IntPtr(p + 0x030)); // 0x30 BaseUtcOffset               ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.SupportsDaylightSavingTime                = GetBool(new IntPtr(p + 0x038)); // 0x38 SupportsDaylightSavingTime  ( ModelPrimitiveType bool bool bool Bool )
            value.AdjustmentRules                           = GetObjectList<AdjustmentRule>(new IntPtr(p + 0x040), ReversePrism.DataModels.AdjustmentRule.FromPointer); // 0x40 AdjustmentRules             ( ModelClassListType AdjustmentRule[] AdjustmentRule[] List<AdjustmentRule> Pointer )
            value.S_cachedData                              = GetObject<CachedData>(new IntPtr(p + 0x010), ReversePrism.DataModels.CachedData.FromPointer); // 0x10 S_cachedData                ( ModelClassType CachedData CachedData CachedData Pointer )
            value.S_maxDateOnly                             = GetDateTime(new IntPtr(p + 0x018)); // 0x18 S_maxDateOnly               ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.S_minDateOnly                             = GetDateTime(new IntPtr(p + 0x020)); // 0x20 S_minDateOnly               ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.MaxOffset                                 = (TimeSpan)GetInt32(new IntPtr(p + 0x028)); // 0x28 MaxOffset                   ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.MinOffset                                 = (TimeSpan)GetInt32(new IntPtr(p + 0x030)); // 0x30 MinOffset                   ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )

            return value;
        }
    }
}

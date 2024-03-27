using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OneYearLocalFromUtc                      0001866098B0 ModelClassType OffsetAndRule OffsetAndRule OffsetAndRule Pointer
    // 018 LocalTimeZone                            00018668C9A0 ModelClassType TimeZoneInfo TimeZoneInfo TimeZoneInfo Pointer
    // 020 _systemTimeZones                         Dictionary`2<string, TimeZoneInfo> IL2CPP_TYPE_GENERICINST
    // 028 _readOnlySystemTimeZones                 ReadOnlyCollection`1<TimeZoneInfo> IL2CPP_TYPE_GENERICINST
    // 030 AllSystemTimeZonesRead                   000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class CachedData
    {
        public OffsetAndRule?                           OneYearLocalFromUtc                     { get; set; }
        public TimeZoneInfo?                            LocalTimeZone                           { get; set; }
        public bool                                     AllSystemTimeZonesRead                  { get; set; }

        public static CachedData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CachedData();

            value.OneYearLocalFromUtc                       = GetObject<OffsetAndRule>(new IntPtr(p + 0x010), ReversePrism.DataModels.OffsetAndRule.FromPointer); // 027003CA7790 0x10 OneYearLocalFromUtc         ( 0001866098B0 ModelClassType OffsetAndRule OffsetAndRule OffsetAndRule Pointer )
            value.LocalTimeZone                             = GetObject<TimeZoneInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.TimeZoneInfo.FromPointer); // 027003CA77B0 0x18 LocalTimeZone               ( 00018668C9A0 ModelClassType TimeZoneInfo TimeZoneInfo TimeZoneInfo Pointer )
            value.AllSystemTimeZonesRead                    = GetBool(new IntPtr(p + 0x030)); // 027003CA7810 0x30 AllSystemTimeZonesRead      ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

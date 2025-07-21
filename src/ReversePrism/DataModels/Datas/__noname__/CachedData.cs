using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OneYearLocalFromUtc                      ModelClassType OffsetAndRule OffsetAndRule OffsetAndRule Pointer
    // 018 LocalTimeZone                            ModelClassType TimeZoneInfo TimeZoneInfo TimeZoneInfo Pointer
    // 020 _systemTimeZones                         Dictionary`2<string, TimeZoneInfo> IL2CPP_TYPE_GENERICINST
    // 028 _readOnlySystemTimeZones                 ReadOnlyCollection`1<TimeZoneInfo> IL2CPP_TYPE_GENERICINST
    // 030 AllSystemTimeZonesRead                   ModelPrimitiveType bool bool bool Bool
    public partial class CachedData : DataModel
    {
        public OffsetAndRule?                           OneYearLocalFromUtc                     { get; set; }
        public TimeZoneInfo?                            LocalTimeZone                           { get; set; }
        public bool                                     AllSystemTimeZonesRead                  { get; set; }

        public static CachedData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CachedData() { Pointer= p0 };

            value.OneYearLocalFromUtc                       = GetObject<OffsetAndRule>(new IntPtr(p + 0x010), ReversePrism.DataModels.OffsetAndRule.FromPointer); // 0x10 OneYearLocalFromUtc         ( ModelClassType OffsetAndRule OffsetAndRule OffsetAndRule Pointer )
            value.LocalTimeZone                             = GetObject<TimeZoneInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.TimeZoneInfo.FromPointer); // 0x18 LocalTimeZone               ( ModelClassType TimeZoneInfo TimeZoneInfo TimeZoneInfo Pointer )
            value.AllSystemTimeZonesRead                    = GetBool(new IntPtr(p + 0x030)); // 0x30 AllSystemTimeZonesRead      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

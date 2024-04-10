using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TZI                                      000186725BD0 ModelEnumType TIME_ZONE_INFORMATION TIME_ZONE_INFORMATION TIME_ZONE_INFORMATION Int32
    // 0C0 TimeZoneKeyName                          000186674A00 ModelPrimitiveType string string string String
    // 0C8 DynamicDaylightTimeDisabled              00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class DYNAMIC_TIME_ZONE_INFORMATION : DataModel
    {
        public TIME_ZONE_INFORMATION                    TZI                                     { get; set; }
        public string                                   TimeZoneKeyName                         { get; set; }
        public sbyte                                    DynamicDaylightTimeDisabled             { get; set; }

        public static DYNAMIC_TIME_ZONE_INFORMATION? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DYNAMIC_TIME_ZONE_INFORMATION() { Pointer= p0 };

            value.TZI                                       = (TIME_ZONE_INFORMATION)GetInt32(new IntPtr(p + 0x010)); // 0246669D7448 0x10 TZI                         ( 000186725BD0 ModelEnumType TIME_ZONE_INFORMATION TIME_ZONE_INFORMATION TIME_ZONE_INFORMATION Int32 )
            value.TimeZoneKeyName                           = GetString(new IntPtr(p + 0x0C0)); // 0246669D7468 0xC0 TimeZoneKeyName             ( 000186674A00 ModelPrimitiveType string string string String )
            value.DynamicDaylightTimeDisabled               = GetSByte(new IntPtr(p + 0x0C8)); // 0246669D7488 0xC8 DynamicDaylightTimeDisabled ( 00018659CC70 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}

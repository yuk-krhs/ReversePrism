using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    0001865BA3F0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 End                                      0001865BA3F0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 Delta                                    00018668B770 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    public partial class DaylightTimeStruct
    {
        public DateTime                                 Start                                   { get; set; }
        public DateTime                                 End                                     { get; set; }
        public TimeSpan                                 Delta                                   { get; set; }

        public static DaylightTimeStruct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DaylightTimeStruct();

            value.Start                                     = GetDateTime(new IntPtr(p + 0x010)); // 0270D6961398 0x10 Start                       ( 0001865BA3F0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.End                                       = GetDateTime(new IntPtr(p + 0x018)); // 0270D69613B8 0x18 End                         ( 0001865BA3F0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Delta                                     = (TimeSpan)GetInt32(new IntPtr(p + 0x020)); // 0270D69613D8 0x20 Delta                       ( 00018668B770 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )

            return value;
        }
    }
}

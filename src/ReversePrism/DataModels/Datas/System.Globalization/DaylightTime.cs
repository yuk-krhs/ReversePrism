using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Start                                    ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 018 End                                      ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 Delta                                    ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    public partial class DaylightTime : DataModel
    {
        public DateTime                                 Start                                   { get; set; }
        public DateTime                                 End                                     { get; set; }
        public TimeSpan                                 Delta                                   { get; set; }

        public static DaylightTime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DaylightTime() { Pointer= p0 };

            value.Start                                     = GetDateTime(new IntPtr(p + 0x010)); // 0x10 Start                       ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.End                                       = GetDateTime(new IntPtr(p + 0x018)); // 0x18 End                         ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Delta                                     = (TimeSpan)GetInt32(new IntPtr(p + 0x020)); // 0x20 Delta                       ( ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_total                                  ModelPrimitiveType int int int Int32
    // 014 M_start                                  ModelPrimitiveType int int int Int32
    public partial class TimeoutTracker : DataModel
    {
        public int                                      M_total                                 { get; set; }
        public int                                      M_start                                 { get; set; }

        public static TimeoutTracker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeoutTracker() { Pointer= p0 };

            value.M_total                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_total                     ( ModelPrimitiveType int int int Int32 )
            value.M_start                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_start                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

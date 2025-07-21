using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DebugFrameTiming                       ModelClassType DebugFrameTiming DebugFrameTiming DebugFrameTiming Pointer
    public partial class DebugDisplayStats : DataModel
    {
        public DebugFrameTiming?                        M_DebugFrameTiming                      { get; set; }

        public static DebugDisplayStats? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugDisplayStats() { Pointer= p0 };

            value.M_DebugFrameTiming                        = GetObject<DebugFrameTiming>(new IntPtr(p + 0x010), ReversePrism.DataModels.DebugFrameTiming.FromPointer); // 0x10 M_DebugFrameTiming          ( ModelClassType DebugFrameTiming DebugFrameTiming DebugFrameTiming Pointer )

            return value;
        }
    }
}

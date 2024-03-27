using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sw                                       00018658EAD0 ModelClassType Stopwatch Stopwatch Stopwatch Pointer
    // 018 CSource                                  0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 020 Running                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 DefaultTimeoutMs                         int IL2CPP_TYPE_I4
    public partial class TimeSlicer
    {
        public Stopwatch?                               Sw                                      { get; set; }
        public CancellationTokenSource?                 CSource                                 { get; set; }
        public bool                                     Running                                 { get; set; }

        public static TimeSlicer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeSlicer();

            value.Sw                                        = GetObject<Stopwatch>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stopwatch.FromPointer); // 027003DCAD98 0x10 Sw                          ( 00018658EAD0 ModelClassType Stopwatch Stopwatch Stopwatch Pointer )
            value.CSource                                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x018), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 027003DCADB8 0x18 CSource                     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Running                                   = GetBool(new IntPtr(p + 0x020)); // 027003DCADD8 0x20 Running                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

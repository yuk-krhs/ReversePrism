using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 IsTapped                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class TapStatusHandler
    {
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public bool                                     IsTapped                                { get; set; }

        public static TapStatusHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TapStatusHandler();

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5DDE488 0x10 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsTapped                                  = GetBool(new IntPtr(p + 0x018)); // 0270D5DDE4A8 0x18 IsTapped                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 018 IsTapped                                 ModelPrimitiveType bool bool bool Bool
    public partial class TapStatusHandler : DataModel
    {
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public bool                                     IsTapped                                { get; set; }

        public static TapStatusHandler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TapStatusHandler() { Pointer= p0 };

            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x10 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsTapped                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 IsTapped                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

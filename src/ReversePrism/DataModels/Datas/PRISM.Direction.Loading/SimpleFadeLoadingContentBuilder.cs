using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LoadingContentView                       00018650B3D0 ModelClassType SimpleFadeLoadingContentView SimpleFadeLoadingContentView SimpleFadeLoadingContentView Pointer
    public partial class SimpleFadeLoadingContentBuilder : DataModel
    {
        public SimpleFadeLoadingContentView?            LoadingContentView                      { get; set; }

        public static SimpleFadeLoadingContentBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleFadeLoadingContentBuilder() { Pointer= p0 };

            value.LoadingContentView                        = GetObject<SimpleFadeLoadingContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SimpleFadeLoadingContentView.FromPointer); // 0245A1EA00A0 0x20 LoadingContentView          ( 00018650B3D0 ModelClassType SimpleFadeLoadingContentView SimpleFadeLoadingContentView SimpleFadeLoadingContentView Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LoadingContentView                       ModelClassType SpecialLoadingContentView SpecialLoadingContentView SpecialLoadingContentView Pointer
    public partial class SpecialLoadingContentBuilder : DataModel
    {
        public SpecialLoadingContentView?               LoadingContentView                      { get; set; }

        public static SpecialLoadingContentBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialLoadingContentBuilder() { Pointer= p0 };

            value.LoadingContentView                        = GetObject<SpecialLoadingContentView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpecialLoadingContentView.FromPointer); // 0x20 LoadingContentView          ( ModelClassType SpecialLoadingContentView SpecialLoadingContentView SpecialLoadingContentView Pointer )

            return value;
        }
    }
}

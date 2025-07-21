using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType ISimpleFadeLoadingContentView ISimpleFadeLoadingContentView ISimpleFadeLoadingContentView Pointer
    // 018 SimpleFadeType                           ModelPrimitiveType int int int Int32
    public partial class SimpleFadeLoadingContentPresenter : DataModel
    {
        public ISimpleFadeLoadingContentView?           View                                    { get; set; }
        public int                                      SimpleFadeType                          { get; set; }

        public static SimpleFadeLoadingContentPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleFadeLoadingContentPresenter() { Pointer= p0 };

            value.View                                      = GetObject<ISimpleFadeLoadingContentView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISimpleFadeLoadingContentView.FromPointer); // 0x10 View                        ( ModelClassType ISimpleFadeLoadingContentView ISimpleFadeLoadingContentView ISimpleFadeLoadingContentView Pointer )
            value.SimpleFadeType                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 SimpleFadeType              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

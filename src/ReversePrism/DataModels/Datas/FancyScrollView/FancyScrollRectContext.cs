using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FancyScrollView.IFancyScrollRectContext.ScrollDirection 0001866F7950 ModelEnumType ScrollDirection ScrollDirection ScrollDirection Int32
    // 018 <FancyScrollView.IFancyScrollRectContext.CalculateScrollSize>k__BackingField Func`1<ValueTuple`2<float, float>> IL2CPP_TYPE_GENERICINST
    public partial class FancyScrollRectContext
    {
        public ScrollDirection                          FancyScrollView.IFancyScrollRectContext.ScrollDirection { get; set; }

        public static FancyScrollRectContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FancyScrollRectContext();

            value.FancyScrollView.IFancyScrollRectContext.ScrollDirection = (ScrollDirection)GetInt32(new IntPtr(p + 0x010)); // 027004F748A0 0x10 FancyScrollView.IFancyScrollRectContext.ScrollDirection ( 0001866F7950 ModelEnumType ScrollDirection ScrollDirection ScrollDirection Int32 )

            return value;
        }
    }
}

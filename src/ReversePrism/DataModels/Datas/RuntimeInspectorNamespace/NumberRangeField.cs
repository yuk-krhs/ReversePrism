using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Slider                                   00018676EEA0 ModelClassType BoundSlider BoundSlider BoundSlider Pointer
    public partial class NumberRangeField : DataModel
    {
        public BoundSlider?                             Slider                                  { get; set; }

        public static NumberRangeField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NumberRangeField() { Pointer= p0 };

            value.Slider                                    = GetObject<BoundSlider>(new IntPtr(p + 0x090), ReversePrism.DataModels.BoundSlider.FromPointer); // 02466B247E00 0x90 Slider                      ( 00018676EEA0 ModelClassType BoundSlider BoundSlider BoundSlider Pointer )

            return value;
        }
    }
}

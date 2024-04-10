using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 3C8 valueChanged                             Action`1<float> IL2CPP_TYPE_GENERICINST
    // 3D0 Slider                                   00018651D6D0 ModelClassType Slider Slider Slider Pointer
    // 3D8 LowButton                                000186662440 ModelClassType RepeatButton RepeatButton RepeatButton Pointer
    // 3E0 HighButton                               000186662440 ModelClassType RepeatButton RepeatButton RepeatButton Pointer
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 horizontalVariantUssClassName            string IL2CPP_TYPE_STRING
    // 010 VerticalVariantUssClassName              000186674040 ModelPrimitiveType string string string String
    // 018 SliderUssClassName                       000186674040 ModelPrimitiveType string string string String
    // 020 LowButtonUssClassName                    000186674040 ModelPrimitiveType string string string String
    // 028 HighButtonUssClassName                   000186674040 ModelPrimitiveType string string string String
    public partial class Scroller : DataModel
    {
        public Slider?                                  Slider                                  { get; set; }
        public RepeatButton?                            LowButton                               { get; set; }
        public RepeatButton?                            HighButton                              { get; set; }
        public string                                   VerticalVariantUssClassName             { get; set; }
        public string                                   SliderUssClassName                      { get; set; }
        public string                                   LowButtonUssClassName                   { get; set; }
        public string                                   HighButtonUssClassName                  { get; set; }

        public static Scroller? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Scroller() { Pointer= p0 };

            value.Slider                                    = GetObject<Slider>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.Slider.FromPointer); // 0245A66F8720 0x3D0 Slider                      ( 00018651D6D0 ModelClassType Slider Slider Slider Pointer )
            value.LowButton                                 = GetObject<RepeatButton>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.RepeatButton.FromPointer); // 0245A66F8740 0x3D8 LowButton                   ( 000186662440 ModelClassType RepeatButton RepeatButton RepeatButton Pointer )
            value.HighButton                                = GetObject<RepeatButton>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.RepeatButton.FromPointer); // 0245A66F8760 0x3E0 HighButton                  ( 000186662440 ModelClassType RepeatButton RepeatButton RepeatButton Pointer )
            value.VerticalVariantUssClassName               = GetString(new IntPtr(p + 0x010)); // 0245A66F87C0 0x10 VerticalVariantUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.SliderUssClassName                        = GetString(new IntPtr(p + 0x018)); // 0245A66F87E0 0x18 SliderUssClassName          ( 000186674040 ModelPrimitiveType string string string String )
            value.LowButtonUssClassName                     = GetString(new IntPtr(p + 0x020)); // 0245A66F8800 0x20 LowButtonUssClassName       ( 000186674040 ModelPrimitiveType string string string String )
            value.HighButtonUssClassName                    = GetString(new IntPtr(p + 0x028)); // 0245A66F8820 0x28 HighButtonUssClassName      ( 000186674040 ModelPrimitiveType string string string String )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 3C8 valueChanged                             Action`1<float> IL2CPP_TYPE_GENERICINST
    // 3D0 Slider                                   ModelClassType Slider Slider Slider Pointer
    // 3D8 LowButton                                ModelClassType RepeatButton RepeatButton RepeatButton Pointer
    // 3E0 HighButton                               ModelClassType RepeatButton RepeatButton RepeatButton Pointer
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 horizontalVariantUssClassName            string IL2CPP_TYPE_STRING
    // 010 VerticalVariantUssClassName              ModelPrimitiveType string string string String
    // 018 SliderUssClassName                       ModelPrimitiveType string string string String
    // 020 LowButtonUssClassName                    ModelPrimitiveType string string string String
    // 028 HighButtonUssClassName                   ModelPrimitiveType string string string String
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

            value.Slider                                    = GetObject<Slider>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.Slider.FromPointer); // 0x3D0 Slider                      ( ModelClassType Slider Slider Slider Pointer )
            value.LowButton                                 = GetObject<RepeatButton>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.RepeatButton.FromPointer); // 0x3D8 LowButton                   ( ModelClassType RepeatButton RepeatButton RepeatButton Pointer )
            value.HighButton                                = GetObject<RepeatButton>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.RepeatButton.FromPointer); // 0x3E0 HighButton                  ( ModelClassType RepeatButton RepeatButton RepeatButton Pointer )
            value.VerticalVariantUssClassName               = GetString(new IntPtr(p + 0x010)); // 0x10 VerticalVariantUssClassName ( ModelPrimitiveType string string string String )
            value.SliderUssClassName                        = GetString(new IntPtr(p + 0x018)); // 0x18 SliderUssClassName          ( ModelPrimitiveType string string string String )
            value.LowButtonUssClassName                     = GetString(new IntPtr(p + 0x020)); // 0x20 LowButtonUssClassName       ( ModelPrimitiveType string string string String )
            value.HighButtonUssClassName                    = GetString(new IntPtr(p + 0x028)); // 0x28 HighButtonUssClassName      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}

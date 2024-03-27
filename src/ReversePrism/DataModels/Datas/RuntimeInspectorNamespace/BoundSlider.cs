using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Slider                                   00018651CF50 ModelClassType Slider Slider Slider Pointer
    // 028 SliderBackground                         0001866CCDB0 ModelClassType Image Image Image Pointer
    // 030 Thumb                                    0001866CCDB0 ModelClassType Image Image Image Pointer
    // 038 SliderFocused                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C M_skinVersion                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 M_skin                                   0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer
    // 048 OnValueChanged                           000186705A00 ModelClassType OnValueChangedDelegate OnValueChangedDelegate OnValueChangedDelegate Pointer
    public partial class BoundSlider
    {
        public Slider?                                  Slider                                  { get; set; }
        public Image?                                   SliderBackground                        { get; set; }
        public Image?                                   Thumb                                   { get; set; }
        public bool                                     SliderFocused                           { get; set; }
        public int                                      M_skinVersion                           { get; set; }
        public UISkin?                                  M_skin                                  { get; set; }
        public OnValueChangedDelegate?                  OnValueChanged                          { get; set; }

        public static BoundSlider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoundSlider();

            value.Slider                                    = GetObject<Slider>(new IntPtr(p + 0x020), ReversePrism.DataModels.Slider.FromPointer); // 0270DB1E7E20 0x20 Slider                      ( 00018651CF50 ModelClassType Slider Slider Slider Pointer )
            value.SliderBackground                          = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0270DB1E7E40 0x28 SliderBackground            ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.Thumb                                     = GetObject<Image>(new IntPtr(p + 0x030), ReversePrism.DataModels.Image.FromPointer); // 0270DB1E7E60 0x30 Thumb                       ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.SliderFocused                             = GetBool(new IntPtr(p + 0x038)); // 0270DB1E7E80 0x38 SliderFocused               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_skinVersion                             = GetInt32(new IntPtr(p + 0x03C)); // 0270DB1E7EA0 0x3C M_skinVersion               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_skin                                    = GetObject<UISkin>(new IntPtr(p + 0x040), ReversePrism.DataModels.UISkin.FromPointer); // 0270DB1E7EC0 0x40 M_skin                      ( 0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer )
            value.OnValueChanged                            = GetObject<OnValueChangedDelegate>(new IntPtr(p + 0x048), ReversePrism.DataModels.OnValueChangedDelegate.FromPointer); // 0270DB1E7EE0 0x48 OnValueChanged              ( 000186705A00 ModelClassType OnValueChangedDelegate OnValueChangedDelegate OnValueChangedDelegate Pointer )

            return value;
        }
    }
}

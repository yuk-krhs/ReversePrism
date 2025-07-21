using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RectTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 AlphaImage                               ModelClassType Image Image Image Pointer
    // 030 Selector                                 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 M_value                                  ModelPrimitiveType float float float Single
    // 040 OnValueChanged                           ModelClassType OnValueChangedDelegate OnValueChangedDelegate OnValueChangedDelegate Pointer
    public partial class ColorPickerAlphaSlider : DataModel
    {
        public RectTransform?                           RectTransform                           { get; set; }
        public Image?                                   AlphaImage                              { get; set; }
        public RectTransform?                           Selector                                { get; set; }
        public float                                    M_value                                 { get; set; }
        public OnValueChangedDelegate?                  OnValueChanged                          { get; set; }

        public static ColorPickerAlphaSlider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorPickerAlphaSlider() { Pointer= p0 };

            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 RectTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AlphaImage                                = GetObject<Image>(new IntPtr(p + 0x028), ReversePrism.DataModels.Image.FromPointer); // 0x28 AlphaImage                  ( ModelClassType Image Image Image Pointer )
            value.Selector                                  = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0x30 Selector                    ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.M_value                                   = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_value                     ( ModelPrimitiveType float float float Single )
            value.OnValueChanged                            = GetObject<OnValueChangedDelegate>(new IntPtr(p + 0x040), ReversePrism.DataModels.OnValueChangedDelegate.FromPointer); // 0x40 OnValueChanged              ( ModelClassType OnValueChangedDelegate OnValueChangedDelegate OnValueChangedDelegate Pointer )

            return value;
        }
    }
}

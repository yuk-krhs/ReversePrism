using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ColorPickerArea                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 088 InputColor                               ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer
    // 090 ColorImg                                 ModelClassType Image Image Image Pointer
    // 098 IsColor32                                ModelPrimitiveType bool bool bool Bool
    public partial class ColorField : DataModel
    {
        public RectTransform?                           ColorPickerArea                         { get; set; }
        public PointerEventListener?                    InputColor                              { get; set; }
        public Image?                                   ColorImg                                { get; set; }
        public bool                                     IsColor32                               { get; set; }

        public static ColorField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorField() { Pointer= p0 };

            value.ColorPickerArea                           = GetObject<RectTransform>(new IntPtr(p + 0x080), ReversePrism.DataModels.RectTransform.FromPointer); // 0x80 ColorPickerArea             ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.InputColor                                = GetObject<PointerEventListener>(new IntPtr(p + 0x088), ReversePrism.DataModels.PointerEventListener.FromPointer); // 0x88 InputColor                  ( ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer )
            value.ColorImg                                  = GetObject<Image>(new IntPtr(p + 0x090), ReversePrism.DataModels.Image.FromPointer); // 0x90 ColorImg                    ( ModelClassType Image Image Image Pointer )
            value.IsColor32                                 = GetBool(new IntPtr(p + 0x098)); // 0x98 IsColor32                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

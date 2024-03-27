using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 ColorPickerArea                          000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 088 InputColor                               00018675AFC0 ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer
    // 090 ColorImg                                 0001866CCDB0 ModelClassType Image Image Image Pointer
    // 098 IsColor32                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ColorField
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
            var value   = new ColorField();

            value.ColorPickerArea                           = GetObject<RectTransform>(new IntPtr(p + 0x080), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DB1D6C90 0x80 ColorPickerArea             ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.InputColor                                = GetObject<PointerEventListener>(new IntPtr(p + 0x088), ReversePrism.DataModels.PointerEventListener.FromPointer); // 0270DB1D6CB0 0x88 InputColor                  ( 00018675AFC0 ModelClassType PointerEventListener PointerEventListener PointerEventListener Pointer )
            value.ColorImg                                  = GetObject<Image>(new IntPtr(p + 0x090), ReversePrism.DataModels.Image.FromPointer); // 0270DB1D6CD0 0x90 ColorImg                    ( 0001866CCDB0 ModelClassType Image Image Image Pointer )
            value.IsColor32                                 = GetBool(new IntPtr(p + 0x098)); // 0270DB1D6CF0 0x98 IsColor32                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

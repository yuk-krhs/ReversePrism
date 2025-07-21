using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PanelColor                               ModelEnumType Color Color Color Int32
    // 020 TextTitleColor                           ModelEnumType Color Color Color Int32
    // 030 TextColor                                ModelEnumType Color Color Color Int32
    // 040 FramePanelSprite                         ModelClassType Sprite Sprite Sprite Pointer
    public partial class ColorData : DataModel
    {
        public Color                                    PanelColor                              { get; set; }
        public Color                                    TextTitleColor                          { get; set; }
        public Color                                    TextColor                               { get; set; }
        public Sprite?                                  FramePanelSprite                        { get; set; }

        public static ColorData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorData() { Pointer= p0 };

            value.PanelColor                                = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 PanelColor                  ( ModelEnumType Color Color Color Int32 )
            value.TextTitleColor                            = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 TextTitleColor              ( ModelEnumType Color Color Color Int32 )
            value.TextColor                                 = (Color)GetInt32(new IntPtr(p + 0x030)); // 0x30 TextColor                   ( ModelEnumType Color Color Color Int32 )
            value.FramePanelSprite                          = GetObject<Sprite>(new IntPtr(p + 0x040), ReversePrism.DataModels.Sprite.FromPointer); // 0x40 FramePanelSprite            ( ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}

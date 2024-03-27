using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PanelColor                               0001865AB0A0 ModelEnumType Color Color Color Int32
    // 020 TextTitleColor                           0001865AB0A0 ModelEnumType Color Color Color Int32
    // 030 TextColor                                0001865AB0A0 ModelEnumType Color Color Color Int32
    // 040 FramePanelSprite                         00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer
    public partial class ColorData
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
            var value   = new ColorData();

            value.PanelColor                                = (Color)GetInt32(new IntPtr(p + 0x010)); // 0270DA1FCDF0 0x10 PanelColor                  ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.TextTitleColor                            = (Color)GetInt32(new IntPtr(p + 0x020)); // 0270DA1FCE10 0x20 TextTitleColor              ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.TextColor                                 = (Color)GetInt32(new IntPtr(p + 0x030)); // 0270DA1FCE30 0x30 TextColor                   ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.FramePanelSprite                          = GetObject<Sprite>(new IntPtr(p + 0x040), ReversePrism.DataModels.Sprite.FromPointer); // 0270DA1FCE50 0x40 FramePanelSprite            ( 00018666B8E0 ModelClassType Sprite Sprite Sprite Pointer )

            return value;
        }
    }
}

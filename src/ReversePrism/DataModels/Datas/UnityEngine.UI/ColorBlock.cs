using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_NormalColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 020 M_HighlightedColor                       0001865AA8E0 ModelEnumType Color Color Color Int32
    // 030 M_PressedColor                           0001865AA8E0 ModelEnumType Color Color Color Int32
    // 040 M_SelectedColor                          0001865AA8E0 ModelEnumType Color Color Color Int32
    // 050 M_DisabledColor                          0001865AA8E0 ModelEnumType Color Color Color Int32
    // 060 M_ColorMultiplier                        0001866656B0 ModelPrimitiveType float float float Single
    // 064 M_FadeDuration                           0001866656B0 ModelPrimitiveType float float float Single
    // 000 defaultColorBlock                        ColorBlock IL2CPP_TYPE_VALUETYPE
    public partial class ColorBlock
    {
        public Color                                    M_NormalColor                           { get; set; }
        public Color                                    M_HighlightedColor                      { get; set; }
        public Color                                    M_PressedColor                          { get; set; }
        public Color                                    M_SelectedColor                         { get; set; }
        public Color                                    M_DisabledColor                         { get; set; }
        public float                                    M_ColorMultiplier                       { get; set; }
        public float                                    M_FadeDuration                          { get; set; }

        public static ColorBlock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColorBlock();

            value.M_NormalColor                             = (Color)GetInt32(new IntPtr(p + 0x010)); // 0270D0A88B58 0x10 M_NormalColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_HighlightedColor                        = (Color)GetInt32(new IntPtr(p + 0x020)); // 0270D0A88B78 0x20 M_HighlightedColor          ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_PressedColor                            = (Color)GetInt32(new IntPtr(p + 0x030)); // 0270D0A88B98 0x30 M_PressedColor              ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_SelectedColor                           = (Color)GetInt32(new IntPtr(p + 0x040)); // 0270D0A88BB8 0x40 M_SelectedColor             ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_DisabledColor                           = (Color)GetInt32(new IntPtr(p + 0x050)); // 0270D0A88BD8 0x50 M_DisabledColor             ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_ColorMultiplier                         = GetSingle(new IntPtr(p + 0x060)); // 0270D0A88BF8 0x60 M_ColorMultiplier           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_FadeDuration                            = GetSingle(new IntPtr(p + 0x064)); // 0270D0A88C18 0x64 M_FadeDuration              ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}

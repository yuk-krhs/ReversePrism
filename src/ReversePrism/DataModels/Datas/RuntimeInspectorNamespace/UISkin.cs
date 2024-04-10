using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_version                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_font                                   0001865AD0A0 ModelClassType Font Font Font Pointer
    // 028 M_fontSize                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C M_lineHeight                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 M_indentAmount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 M_labelWidthPercentage                   0001866656B0 ModelPrimitiveType float float float Single
    // 038 M_expandArrowSpacing                     0001866656B0 ModelPrimitiveType float float float Single
    // 03C M_windowColor                            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 04C M_backgroundColor                        0001865AA8E0 ModelEnumType Color Color Color Int32
    // 05C M_textColor                              0001865AA8E0 ModelEnumType Color Color Color Int32
    // 06C M_scrollbarColor                         0001865AA8E0 ModelEnumType Color Color Color Int32
    // 07C M_expandArrowColor                       0001865AA8E0 ModelEnumType Color Color Color Int32
    // 08C M_inputFieldNormalBackgroundColor        0001865AA8E0 ModelEnumType Color Color Color Int32
    // 09C M_inputFieldInvalidBackgroundColor       0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0AC M_inputFieldTextColor                    0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0BC M_toggleCheckmarkColor                   0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0CC M_sliderBackgroundColor                  0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0DC M_sliderThumbColor                       0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0EC M_buttonBackgroundColor                  0001865AA8E0 ModelEnumType Color Color Color Int32
    // 0FC M_buttonTextColor                        0001865AA8E0 ModelEnumType Color Color Color Int32
    // 10C M_selectedItemBackgroundColor            0001865AA8E0 ModelEnumType Color Color Color Int32
    // 11C M_selectedItemTextColor                  0001865AA8E0 ModelEnumType Color Color Color Int32
    public partial class UISkin : DataModel
    {
        public int                                      M_version                               { get; set; }
        public Font?                                    M_font                                  { get; set; }
        public int                                      M_fontSize                              { get; set; }
        public int                                      M_lineHeight                            { get; set; }
        public int                                      M_indentAmount                          { get; set; }
        public float                                    M_labelWidthPercentage                  { get; set; }
        public float                                    M_expandArrowSpacing                    { get; set; }
        public Color                                    M_windowColor                           { get; set; }
        public Color                                    M_backgroundColor                       { get; set; }
        public Color                                    M_textColor                             { get; set; }
        public Color                                    M_scrollbarColor                        { get; set; }
        public Color                                    M_expandArrowColor                      { get; set; }
        public Color                                    M_inputFieldNormalBackgroundColor       { get; set; }
        public Color                                    M_inputFieldInvalidBackgroundColor      { get; set; }
        public Color                                    M_inputFieldTextColor                   { get; set; }
        public Color                                    M_toggleCheckmarkColor                  { get; set; }
        public Color                                    M_sliderBackgroundColor                 { get; set; }
        public Color                                    M_sliderThumbColor                      { get; set; }
        public Color                                    M_buttonBackgroundColor                 { get; set; }
        public Color                                    M_buttonTextColor                       { get; set; }
        public Color                                    M_selectedItemBackgroundColor           { get; set; }
        public Color                                    M_selectedItemTextColor                 { get; set; }

        public static UISkin? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UISkin() { Pointer= p0 };

            value.M_version                                 = GetInt32(new IntPtr(p + 0x018)); // 02466B2196F0 0x18 M_version                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_font                                    = GetObject<Font>(new IntPtr(p + 0x020), ReversePrism.DataModels.Font.FromPointer); // 02466B219710 0x20 M_font                      ( 0001865AD0A0 ModelClassType Font Font Font Pointer )
            value.M_fontSize                                = GetInt32(new IntPtr(p + 0x028)); // 02466B219730 0x28 M_fontSize                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_lineHeight                              = GetInt32(new IntPtr(p + 0x02C)); // 02466B219750 0x2C M_lineHeight                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_indentAmount                            = GetInt32(new IntPtr(p + 0x030)); // 02466B219770 0x30 M_indentAmount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_labelWidthPercentage                    = GetSingle(new IntPtr(p + 0x034)); // 02466B219790 0x34 M_labelWidthPercentage      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_expandArrowSpacing                      = GetSingle(new IntPtr(p + 0x038)); // 02466B2197B0 0x38 M_expandArrowSpacing        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_windowColor                             = (Color)GetInt32(new IntPtr(p + 0x03C)); // 02466B2197D0 0x3C M_windowColor               ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_backgroundColor                         = (Color)GetInt32(new IntPtr(p + 0x04C)); // 02466B2197F0 0x4C M_backgroundColor           ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_textColor                               = (Color)GetInt32(new IntPtr(p + 0x05C)); // 02466B219810 0x5C M_textColor                 ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_scrollbarColor                          = (Color)GetInt32(new IntPtr(p + 0x06C)); // 02466B219830 0x6C M_scrollbarColor            ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_expandArrowColor                        = (Color)GetInt32(new IntPtr(p + 0x07C)); // 02466B219850 0x7C M_expandArrowColor          ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_inputFieldNormalBackgroundColor         = (Color)GetInt32(new IntPtr(p + 0x08C)); // 02466B219870 0x8C M_inputFieldNormalBackgroundColor ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_inputFieldInvalidBackgroundColor        = (Color)GetInt32(new IntPtr(p + 0x09C)); // 02466B219890 0x9C M_inputFieldInvalidBackgroundColor ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_inputFieldTextColor                     = (Color)GetInt32(new IntPtr(p + 0x0AC)); // 02466B2198B0 0xAC M_inputFieldTextColor       ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_toggleCheckmarkColor                    = (Color)GetInt32(new IntPtr(p + 0x0BC)); // 02466B2198D0 0xBC M_toggleCheckmarkColor      ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_sliderBackgroundColor                   = (Color)GetInt32(new IntPtr(p + 0x0CC)); // 02466B2198F0 0xCC M_sliderBackgroundColor     ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_sliderThumbColor                        = (Color)GetInt32(new IntPtr(p + 0x0DC)); // 02466B219910 0xDC M_sliderThumbColor          ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_buttonBackgroundColor                   = (Color)GetInt32(new IntPtr(p + 0x0EC)); // 02466B219930 0xEC M_buttonBackgroundColor     ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_buttonTextColor                         = (Color)GetInt32(new IntPtr(p + 0x0FC)); // 02466B219950 0xFC M_buttonTextColor           ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_selectedItemBackgroundColor             = (Color)GetInt32(new IntPtr(p + 0x10C)); // 02466B219970 0x10C M_selectedItemBackgroundColor ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )
            value.M_selectedItemTextColor                   = (Color)GetInt32(new IntPtr(p + 0x11C)); // 02466B219990 0x11C M_selectedItemTextColor     ( 0001865AA8E0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}

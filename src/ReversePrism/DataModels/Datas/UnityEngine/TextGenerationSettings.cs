using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Font                                     0001865AD2F0 ModelClassType Font Font Font Pointer
    // 018 Color                                    0001865AB0A0 ModelEnumType Color Color Color Int32
    // 028 FontSize                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C LineSpacing                              000186666050 ModelPrimitiveType float float float Single
    // 030 RichText                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 034 ScaleFactor                              000186666050 ModelPrimitiveType float float float Single
    // 038 FontStyle                                0001865B1310 ModelEnumType FontStyle FontStyle FontStyle Int32
    // 03C TextAnchor                               000186633B90 ModelEnumType TextAnchor TextAnchor TextAnchor Int32
    // 040 AlignByGeometry                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 041 ResizeTextForBestFit                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 044 ResizeTextMinSize                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 048 ResizeTextMaxSize                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 04C UpdateBounds                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 050 VerticalOverflow                         0001865165A0 ModelEnumType VerticalWrapMode VerticalWrapMode VerticalWrapMode Int32
    // 054 HorizontalOverflow                       0001866D6A80 ModelEnumType HorizontalWrapMode HorizontalWrapMode HorizontalWrapMode Int32
    // 058 GenerationExtents                        0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 060 Pivot                                    0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 068 GenerateOutOfBounds                      000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class TextGenerationSettings
    {
        public Font?                                    Font                                    { get; set; }
        public Color                                    Color                                   { get; set; }
        public int                                      FontSize                                { get; set; }
        public float                                    LineSpacing                             { get; set; }
        public bool                                     RichText                                { get; set; }
        public float                                    ScaleFactor                             { get; set; }
        public FontStyle                                FontStyle                               { get; set; }
        public TextAnchor                               TextAnchor                              { get; set; }
        public bool                                     AlignByGeometry                         { get; set; }
        public bool                                     ResizeTextForBestFit                    { get; set; }
        public int                                      ResizeTextMinSize                       { get; set; }
        public int                                      ResizeTextMaxSize                       { get; set; }
        public bool                                     UpdateBounds                            { get; set; }
        public VerticalWrapMode                         VerticalOverflow                        { get; set; }
        public HorizontalWrapMode                       HorizontalOverflow                      { get; set; }
        public Vector2                                  GenerationExtents                       { get; set; }
        public Vector2                                  Pivot                                   { get; set; }
        public bool                                     GenerateOutOfBounds                     { get; set; }

        public static TextGenerationSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextGenerationSettings();

            value.Font                                      = GetObject<Font>(new IntPtr(p + 0x010), ReversePrism.DataModels.Font.FromPointer); // 02700217A990 0x10 Font                        ( 0001865AD2F0 ModelClassType Font Font Font Pointer )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x018)); // 02700217A9B0 0x18 Color                       ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.FontSize                                  = GetInt32(new IntPtr(p + 0x028)); // 02700217A9D0 0x28 FontSize                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LineSpacing                               = GetSingle(new IntPtr(p + 0x02C)); // 02700217A9F0 0x2C LineSpacing                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.RichText                                  = GetBool(new IntPtr(p + 0x030)); // 02700217AA10 0x30 RichText                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ScaleFactor                               = GetSingle(new IntPtr(p + 0x034)); // 02700217AA30 0x34 ScaleFactor                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.FontStyle                                 = (FontStyle)GetInt32(new IntPtr(p + 0x038)); // 02700217AA50 0x38 FontStyle                   ( 0001865B1310 ModelEnumType FontStyle FontStyle FontStyle Int32 )
            value.TextAnchor                                = (TextAnchor)GetInt32(new IntPtr(p + 0x03C)); // 02700217AA70 0x3C TextAnchor                  ( 000186633B90 ModelEnumType TextAnchor TextAnchor TextAnchor Int32 )
            value.AlignByGeometry                           = GetBool(new IntPtr(p + 0x040)); // 02700217AA90 0x40 AlignByGeometry             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ResizeTextForBestFit                      = GetBool(new IntPtr(p + 0x041)); // 02700217AAB0 0x41 ResizeTextForBestFit        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ResizeTextMinSize                         = GetInt32(new IntPtr(p + 0x044)); // 02700217AAD0 0x44 ResizeTextMinSize           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ResizeTextMaxSize                         = GetInt32(new IntPtr(p + 0x048)); // 02700217AAF0 0x48 ResizeTextMaxSize           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UpdateBounds                              = GetBool(new IntPtr(p + 0x04C)); // 02700217AB10 0x4C UpdateBounds                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.VerticalOverflow                          = (VerticalWrapMode)GetInt32(new IntPtr(p + 0x050)); // 02700217AB30 0x50 VerticalOverflow            ( 0001865165A0 ModelEnumType VerticalWrapMode VerticalWrapMode VerticalWrapMode Int32 )
            value.HorizontalOverflow                        = (HorizontalWrapMode)GetInt32(new IntPtr(p + 0x054)); // 02700217AB50 0x54 HorizontalOverflow          ( 0001866D6A80 ModelEnumType HorizontalWrapMode HorizontalWrapMode HorizontalWrapMode Int32 )
            value.GenerationExtents                         = (Vector2)GetInt32(new IntPtr(p + 0x058)); // 02700217AB70 0x58 GenerationExtents           ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Pivot                                     = (Vector2)GetInt32(new IntPtr(p + 0x060)); // 02700217AB90 0x60 Pivot                       ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.GenerateOutOfBounds                       = GetBool(new IntPtr(p + 0x068)); // 02700217ABB0 0x68 GenerateOutOfBounds         ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

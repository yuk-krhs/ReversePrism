using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Font                                     ModelClassType Font Font Font Pointer
    // 018 Color                                    ModelEnumType Color Color Color Int32
    // 028 FontSize                                 ModelPrimitiveType int int int Int32
    // 02C LineSpacing                              ModelPrimitiveType float float float Single
    // 030 RichText                                 ModelPrimitiveType bool bool bool Bool
    // 034 ScaleFactor                              ModelPrimitiveType float float float Single
    // 038 FontStyle                                ModelEnumType FontStyle FontStyle FontStyle Int32
    // 03C TextAnchor                               ModelEnumType TextAnchor TextAnchor TextAnchor Int32
    // 040 AlignByGeometry                          ModelPrimitiveType bool bool bool Bool
    // 041 ResizeTextForBestFit                     ModelPrimitiveType bool bool bool Bool
    // 044 ResizeTextMinSize                        ModelPrimitiveType int int int Int32
    // 048 ResizeTextMaxSize                        ModelPrimitiveType int int int Int32
    // 04C UpdateBounds                             ModelPrimitiveType bool bool bool Bool
    // 050 VerticalOverflow                         ModelEnumType VerticalWrapMode VerticalWrapMode VerticalWrapMode Int32
    // 054 HorizontalOverflow                       ModelEnumType HorizontalWrapMode HorizontalWrapMode HorizontalWrapMode Int32
    // 058 GenerationExtents                        ModelEnumType Vector2 Vector2 Vector2 Int32
    // 060 Pivot                                    ModelEnumType Vector2 Vector2 Vector2 Int32
    // 068 GenerateOutOfBounds                      ModelPrimitiveType bool bool bool Bool
    public partial class TextGenerationSettings : DataModel
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
            var value   = new TextGenerationSettings() { Pointer= p0 };

            value.Font                                      = GetObject<Font>(new IntPtr(p + 0x010), ReversePrism.DataModels.Font.FromPointer); // 0x10 Font                        ( ModelClassType Font Font Font Pointer )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x018)); // 0x18 Color                       ( ModelEnumType Color Color Color Int32 )
            value.FontSize                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 FontSize                    ( ModelPrimitiveType int int int Int32 )
            value.LineSpacing                               = GetSingle(new IntPtr(p + 0x02C)); // 0x2C LineSpacing                 ( ModelPrimitiveType float float float Single )
            value.RichText                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 RichText                    ( ModelPrimitiveType bool bool bool Bool )
            value.ScaleFactor                               = GetSingle(new IntPtr(p + 0x034)); // 0x34 ScaleFactor                 ( ModelPrimitiveType float float float Single )
            value.FontStyle                                 = (FontStyle)GetInt32(new IntPtr(p + 0x038)); // 0x38 FontStyle                   ( ModelEnumType FontStyle FontStyle FontStyle Int32 )
            value.TextAnchor                                = (TextAnchor)GetInt32(new IntPtr(p + 0x03C)); // 0x3C TextAnchor                  ( ModelEnumType TextAnchor TextAnchor TextAnchor Int32 )
            value.AlignByGeometry                           = GetBool(new IntPtr(p + 0x040)); // 0x40 AlignByGeometry             ( ModelPrimitiveType bool bool bool Bool )
            value.ResizeTextForBestFit                      = GetBool(new IntPtr(p + 0x041)); // 0x41 ResizeTextForBestFit        ( ModelPrimitiveType bool bool bool Bool )
            value.ResizeTextMinSize                         = GetInt32(new IntPtr(p + 0x044)); // 0x44 ResizeTextMinSize           ( ModelPrimitiveType int int int Int32 )
            value.ResizeTextMaxSize                         = GetInt32(new IntPtr(p + 0x048)); // 0x48 ResizeTextMaxSize           ( ModelPrimitiveType int int int Int32 )
            value.UpdateBounds                              = GetBool(new IntPtr(p + 0x04C)); // 0x4C UpdateBounds                ( ModelPrimitiveType bool bool bool Bool )
            value.VerticalOverflow                          = (VerticalWrapMode)GetInt32(new IntPtr(p + 0x050)); // 0x50 VerticalOverflow            ( ModelEnumType VerticalWrapMode VerticalWrapMode VerticalWrapMode Int32 )
            value.HorizontalOverflow                        = (HorizontalWrapMode)GetInt32(new IntPtr(p + 0x054)); // 0x54 HorizontalOverflow          ( ModelEnumType HorizontalWrapMode HorizontalWrapMode HorizontalWrapMode Int32 )
            value.GenerationExtents                         = (Vector2)GetInt32(new IntPtr(p + 0x058)); // 0x58 GenerationExtents           ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Pivot                                     = (Vector2)GetInt32(new IntPtr(p + 0x060)); // 0x60 Pivot                       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.GenerateOutOfBounds                       = GetBool(new IntPtr(p + 0x068)); // 0x68 GenerateOutOfBounds         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

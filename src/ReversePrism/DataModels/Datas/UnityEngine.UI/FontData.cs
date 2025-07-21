using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Font                                   ModelClassType Font Font Font Pointer
    // 018 M_FontSize                               ModelPrimitiveType int int int Int32
    // 01C M_FontStyle                              ModelEnumType FontStyle FontStyle FontStyle Int32
    // 020 M_BestFit                                ModelPrimitiveType bool bool bool Bool
    // 024 M_MinSize                                ModelPrimitiveType int int int Int32
    // 028 M_MaxSize                                ModelPrimitiveType int int int Int32
    // 02C M_Alignment                              ModelEnumType TextAnchor TextAnchor TextAnchor Int32
    // 030 M_AlignByGeometry                        ModelPrimitiveType bool bool bool Bool
    // 031 M_RichText                               ModelPrimitiveType bool bool bool Bool
    // 034 M_HorizontalOverflow                     ModelEnumType HorizontalWrapMode HorizontalWrapMode HorizontalWrapMode Int32
    // 038 M_VerticalOverflow                       ModelEnumType VerticalWrapMode VerticalWrapMode VerticalWrapMode Int32
    // 03C M_LineSpacing                            ModelPrimitiveType float float float Single
    public partial class FontData : DataModel
    {
        public Font?                                    M_Font                                  { get; set; }
        public int                                      M_FontSize                              { get; set; }
        public FontStyle                                M_FontStyle                             { get; set; }
        public bool                                     M_BestFit                               { get; set; }
        public int                                      M_MinSize                               { get; set; }
        public int                                      M_MaxSize                               { get; set; }
        public TextAnchor                               M_Alignment                             { get; set; }
        public bool                                     M_AlignByGeometry                       { get; set; }
        public bool                                     M_RichText                              { get; set; }
        public HorizontalWrapMode                       M_HorizontalOverflow                    { get; set; }
        public VerticalWrapMode                         M_VerticalOverflow                      { get; set; }
        public float                                    M_LineSpacing                           { get; set; }

        public static FontData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontData() { Pointer= p0 };

            value.M_Font                                    = GetObject<Font>(new IntPtr(p + 0x010), ReversePrism.DataModels.Font.FromPointer); // 0x10 M_Font                      ( ModelClassType Font Font Font Pointer )
            value.M_FontSize                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_FontSize                  ( ModelPrimitiveType int int int Int32 )
            value.M_FontStyle                               = (FontStyle)GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_FontStyle                 ( ModelEnumType FontStyle FontStyle FontStyle Int32 )
            value.M_BestFit                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 M_BestFit                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_MinSize                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_MinSize                   ( ModelPrimitiveType int int int Int32 )
            value.M_MaxSize                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_MaxSize                   ( ModelPrimitiveType int int int Int32 )
            value.M_Alignment                               = (TextAnchor)GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_Alignment                 ( ModelEnumType TextAnchor TextAnchor TextAnchor Int32 )
            value.M_AlignByGeometry                         = GetBool(new IntPtr(p + 0x030)); // 0x30 M_AlignByGeometry           ( ModelPrimitiveType bool bool bool Bool )
            value.M_RichText                                = GetBool(new IntPtr(p + 0x031)); // 0x31 M_RichText                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_HorizontalOverflow                      = (HorizontalWrapMode)GetInt32(new IntPtr(p + 0x034)); // 0x34 M_HorizontalOverflow        ( ModelEnumType HorizontalWrapMode HorizontalWrapMode HorizontalWrapMode Int32 )
            value.M_VerticalOverflow                        = (VerticalWrapMode)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_VerticalOverflow          ( ModelEnumType VerticalWrapMode VerticalWrapMode VerticalWrapMode Int32 )
            value.M_LineSpacing                             = GetSingle(new IntPtr(p + 0x03C)); // 0x3C M_LineSpacing               ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}

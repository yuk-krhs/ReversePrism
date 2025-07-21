using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ElementType                            ModelEnumType TextElementType TextElementType TextElementType Int32
    // 014 M_Unicode                                ModelPrimitiveType uint uint uint UInt32
    // 018 M_TextAsset                              ModelClassType TextAsset TextAsset TextAsset Pointer
    // 020 M_Glyph                                  ModelClassType Glyph Glyph Glyph Pointer
    // 028 M_GlyphIndex                             ModelPrimitiveType uint uint uint UInt32
    // 02C M_Scale                                  ModelPrimitiveType float float float Single
    public partial class TextElement : DataModel
    {
        public TextElementType                          M_ElementType                           { get; set; }
        public uint                                     M_Unicode                               { get; set; }
        public TextAsset?                               M_TextAsset                             { get; set; }
        public Glyph?                                   M_Glyph                                 { get; set; }
        public uint                                     M_GlyphIndex                            { get; set; }
        public float                                    M_Scale                                 { get; set; }

        public static TextElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextElement() { Pointer= p0 };

            value.M_ElementType                             = (TextElementType)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_ElementType               ( ModelEnumType TextElementType TextElementType TextElementType Int32 )
            value.M_Unicode                                 = GetUInt32(new IntPtr(p + 0x014)); // 0x14 M_Unicode                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_TextAsset                               = GetObject<TextAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextAsset.FromPointer); // 0x18 M_TextAsset                 ( ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.M_Glyph                                   = GetObject<Glyph>(new IntPtr(p + 0x020), ReversePrism.DataModels.Glyph.FromPointer); // 0x20 M_Glyph                     ( ModelClassType Glyph Glyph Glyph Pointer )
            value.M_GlyphIndex                              = GetUInt32(new IntPtr(p + 0x028)); // 0x28 M_GlyphIndex                ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_Scale                                   = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_Scale                     ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}

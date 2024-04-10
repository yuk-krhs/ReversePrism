using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ElementType                            000186639590 ModelEnumType TextElementType TextElementType TextElementType Int32
    // 014 M_Unicode                                000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 018 M_TextAsset                              00018660A690 ModelClassType TMP_Asset TMP_Asset TMP_Asset Pointer
    // 020 M_Glyph                                  0001865DA1C0 ModelClassType Glyph Glyph Glyph Pointer
    // 028 M_GlyphIndex                             000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 02C M_Scale                                  000186665900 ModelPrimitiveType float float float Single
    public partial class TMP_TextElement : DataModel
    {
        public TextElementType                          M_ElementType                           { get; set; }
        public uint                                     M_Unicode                               { get; set; }
        public TMP_Asset?                               M_TextAsset                             { get; set; }
        public Glyph?                                   M_Glyph                                 { get; set; }
        public uint                                     M_GlyphIndex                            { get; set; }
        public float                                    M_Scale                                 { get; set; }

        public static TMP_TextElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_TextElement() { Pointer= p0 };

            value.M_ElementType                             = (TextElementType)GetInt32(new IntPtr(p + 0x010)); // 0246609AD1B8 0x10 M_ElementType               ( 000186639590 ModelEnumType TextElementType TextElementType TextElementType Int32 )
            value.M_Unicode                                 = GetUInt32(new IntPtr(p + 0x014)); // 0246609AD1D8 0x14 M_Unicode                   ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.M_TextAsset                               = GetObject<TMP_Asset>(new IntPtr(p + 0x018), ReversePrism.DataModels.TMP_Asset.FromPointer); // 0246609AD1F8 0x18 M_TextAsset                 ( 00018660A690 ModelClassType TMP_Asset TMP_Asset TMP_Asset Pointer )
            value.M_Glyph                                   = GetObject<Glyph>(new IntPtr(p + 0x020), ReversePrism.DataModels.Glyph.FromPointer); // 0246609AD218 0x20 M_Glyph                     ( 0001865DA1C0 ModelClassType Glyph Glyph Glyph Pointer )
            value.M_GlyphIndex                              = GetUInt32(new IntPtr(p + 0x028)); // 0246609AD238 0x28 M_GlyphIndex                ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.M_Scale                                   = GetSingle(new IntPtr(p + 0x02C)); // 0246609AD258 0x2C M_Scale                     ( 000186665900 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}

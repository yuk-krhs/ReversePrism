using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_FirstGlyph                             000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 014 M_FirstGlyphAdjustments                  000186683730 ModelEnumType GlyphValueRecord_Legacy GlyphValueRecord_Legacy GlyphValueRecord_Legacy Int32
    // 024 M_SecondGlyph                            000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 028 M_SecondGlyphAdjustments                 000186683730 ModelEnumType GlyphValueRecord_Legacy GlyphValueRecord_Legacy GlyphValueRecord_Legacy Int32
    // 038 XOffset                                  000186666050 ModelPrimitiveType float float float Single
    // 000 empty                                    KerningPair IL2CPP_TYPE_CLASS
    // 03C M_IgnoreSpacingAdjustments               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class KerningPair : DataModel
    {
        public uint                                     M_FirstGlyph                            { get; set; }
        public GlyphValueRecord_Legacy                  M_FirstGlyphAdjustments                 { get; set; }
        public uint                                     M_SecondGlyph                           { get; set; }
        public GlyphValueRecord_Legacy                  M_SecondGlyphAdjustments                { get; set; }
        public float                                    XOffset                                 { get; set; }
        public bool                                     M_IgnoreSpacingAdjustments              { get; set; }

        public static KerningPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KerningPair() { Pointer= p0 };

            value.M_FirstGlyph                              = GetUInt32(new IntPtr(p + 0x010)); // 0246609B5E20 0x10 M_FirstGlyph                ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_FirstGlyphAdjustments                   = (GlyphValueRecord_Legacy)GetInt32(new IntPtr(p + 0x014)); // 0246609B5E40 0x14 M_FirstGlyphAdjustments     ( 000186683730 ModelEnumType GlyphValueRecord_Legacy GlyphValueRecord_Legacy GlyphValueRecord_Legacy Int32 )
            value.M_SecondGlyph                             = GetUInt32(new IntPtr(p + 0x024)); // 0246609B5E60 0x24 M_SecondGlyph               ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_SecondGlyphAdjustments                  = (GlyphValueRecord_Legacy)GetInt32(new IntPtr(p + 0x028)); // 0246609B5E80 0x28 M_SecondGlyphAdjustments    ( 000186683730 ModelEnumType GlyphValueRecord_Legacy GlyphValueRecord_Legacy GlyphValueRecord_Legacy Int32 )
            value.XOffset                                   = GetSingle(new IntPtr(p + 0x038)); // 0246609B5EA0 0x38 XOffset                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_IgnoreSpacingAdjustments                = GetBool(new IntPtr(p + 0x03C)); // 0246609B5EE0 0x3C M_IgnoreSpacingAdjustments  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

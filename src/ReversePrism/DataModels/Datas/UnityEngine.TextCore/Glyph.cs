using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Index                                  ModelPrimitiveType uint uint uint UInt32
    // 014 M_Metrics                                ModelEnumType GlyphMetrics GlyphMetrics GlyphMetrics Int32
    // 028 M_GlyphRect                              ModelEnumType GlyphRect GlyphRect GlyphRect Int32
    // 038 M_Scale                                  ModelPrimitiveType float float float Single
    // 03C M_AtlasIndex                             ModelPrimitiveType int int int Int32
    // 040 M_ClassDefinitionType                    ModelEnumType GlyphClassDefinitionType GlyphClassDefinitionType GlyphClassDefinitionType Int32
    public partial class Glyph : DataModel
    {
        public uint                                     M_Index                                 { get; set; }
        public GlyphMetrics                             M_Metrics                               { get; set; }
        public GlyphRect                                M_GlyphRect                             { get; set; }
        public float                                    M_Scale                                 { get; set; }
        public int                                      M_AtlasIndex                            { get; set; }
        public GlyphClassDefinitionType                 M_ClassDefinitionType                   { get; set; }

        public static Glyph? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Glyph() { Pointer= p0 };

            value.M_Index                                   = GetUInt32(new IntPtr(p + 0x010)); // 0x10 M_Index                     ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_Metrics                                 = (GlyphMetrics)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_Metrics                   ( ModelEnumType GlyphMetrics GlyphMetrics GlyphMetrics Int32 )
            value.M_GlyphRect                               = (GlyphRect)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_GlyphRect                 ( ModelEnumType GlyphRect GlyphRect GlyphRect Int32 )
            value.M_Scale                                   = GetSingle(new IntPtr(p + 0x038)); // 0x38 M_Scale                     ( ModelPrimitiveType float float float Single )
            value.M_AtlasIndex                              = GetInt32(new IntPtr(p + 0x03C)); // 0x3C M_AtlasIndex                ( ModelPrimitiveType int int int Int32 )
            value.M_ClassDefinitionType                     = (GlyphClassDefinitionType)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_ClassDefinitionType       ( ModelEnumType GlyphClassDefinitionType GlyphClassDefinitionType GlyphClassDefinitionType Int32 )

            return value;
        }
    }
}

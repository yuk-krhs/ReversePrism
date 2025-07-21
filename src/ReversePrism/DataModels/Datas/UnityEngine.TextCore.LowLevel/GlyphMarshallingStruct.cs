using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    ModelPrimitiveType uint uint uint UInt32
    // 014 Metrics                                  ModelEnumType GlyphMetrics GlyphMetrics GlyphMetrics Int32
    // 028 GlyphRect                                ModelEnumType GlyphRect GlyphRect GlyphRect Int32
    // 038 Scale                                    ModelPrimitiveType float float float Single
    // 03C AtlasIndex                               ModelPrimitiveType int int int Int32
    // 040 ClassDefinitionType                      ModelEnumType GlyphClassDefinitionType GlyphClassDefinitionType GlyphClassDefinitionType Int32
    public partial class GlyphMarshallingStruct : DataModel
    {
        public uint                                     Index                                   { get; set; }
        public GlyphMetrics                             Metrics                                 { get; set; }
        public GlyphRect                                GlyphRect                               { get; set; }
        public float                                    Scale                                   { get; set; }
        public int                                      AtlasIndex                              { get; set; }
        public GlyphClassDefinitionType                 ClassDefinitionType                     { get; set; }

        public static GlyphMarshallingStruct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlyphMarshallingStruct() { Pointer= p0 };

            value.Index                                     = GetUInt32(new IntPtr(p + 0x010)); // 0x10 Index                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.Metrics                                   = (GlyphMetrics)GetInt32(new IntPtr(p + 0x014)); // 0x14 Metrics                     ( ModelEnumType GlyphMetrics GlyphMetrics GlyphMetrics Int32 )
            value.GlyphRect                                 = (GlyphRect)GetInt32(new IntPtr(p + 0x028)); // 0x28 GlyphRect                   ( ModelEnumType GlyphRect GlyphRect GlyphRect Int32 )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x038)); // 0x38 Scale                       ( ModelPrimitiveType float float float Single )
            value.AtlasIndex                                = GetInt32(new IntPtr(p + 0x03C)); // 0x3C AtlasIndex                  ( ModelPrimitiveType int int int Int32 )
            value.ClassDefinitionType                       = (GlyphClassDefinitionType)GetInt32(new IntPtr(p + 0x040)); // 0x40 ClassDefinitionType         ( ModelEnumType GlyphClassDefinitionType GlyphClassDefinitionType GlyphClassDefinitionType Int32 )

            return value;
        }
    }
}

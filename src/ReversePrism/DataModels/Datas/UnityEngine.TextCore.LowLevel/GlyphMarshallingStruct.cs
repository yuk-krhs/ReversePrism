using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 Metrics                                  000186681510 ModelEnumType GlyphMetrics GlyphMetrics GlyphMetrics Int32
    // 028 GlyphRect                                0001866823C0 ModelEnumType GlyphRect GlyphRect GlyphRect Int32
    // 038 Scale                                    000186666050 ModelPrimitiveType float float float Single
    // 03C AtlasIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 ClassDefinitionType                      0001866806E0 ModelEnumType GlyphClassDefinitionType GlyphClassDefinitionType GlyphClassDefinitionType Int32
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

            value.Index                                     = GetUInt32(new IntPtr(p + 0x010)); // 0245A2168630 0x10 Index                       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Metrics                                   = (GlyphMetrics)GetInt32(new IntPtr(p + 0x014)); // 0245A2168650 0x14 Metrics                     ( 000186681510 ModelEnumType GlyphMetrics GlyphMetrics GlyphMetrics Int32 )
            value.GlyphRect                                 = (GlyphRect)GetInt32(new IntPtr(p + 0x028)); // 0245A2168670 0x28 GlyphRect                   ( 0001866823C0 ModelEnumType GlyphRect GlyphRect GlyphRect Int32 )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x038)); // 0245A2168690 0x38 Scale                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.AtlasIndex                                = GetInt32(new IntPtr(p + 0x03C)); // 0245A21686B0 0x3C AtlasIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ClassDefinitionType                       = (GlyphClassDefinitionType)GetInt32(new IntPtr(p + 0x040)); // 0245A21686D0 0x40 ClassDefinitionType         ( 0001866806E0 ModelEnumType GlyphClassDefinitionType GlyphClassDefinitionType GlyphClassDefinitionType Int32 )

            return value;
        }
    }
}

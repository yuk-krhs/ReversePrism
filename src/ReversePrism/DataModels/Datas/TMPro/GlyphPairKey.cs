using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstGlyphIndex                          ModelPrimitiveType uint uint uint UInt32
    // 014 SecondGlyphIndex                         ModelPrimitiveType uint uint uint UInt32
    // 018 Key                                      ModelPrimitiveType uint uint uint UInt32
    public partial class GlyphPairKey : DataModel
    {
        public uint                                     FirstGlyphIndex                         { get; set; }
        public uint                                     SecondGlyphIndex                        { get; set; }
        public uint                                     Key                                     { get; set; }

        public static GlyphPairKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlyphPairKey() { Pointer= p0 };

            value.FirstGlyphIndex                           = GetUInt32(new IntPtr(p + 0x010)); // 0x10 FirstGlyphIndex             ( ModelPrimitiveType uint uint uint UInt32 )
            value.SecondGlyphIndex                          = GetUInt32(new IntPtr(p + 0x014)); // 0x14 SecondGlyphIndex            ( ModelPrimitiveType uint uint uint UInt32 )
            value.Key                                       = GetUInt32(new IntPtr(p + 0x018)); // 0x18 Key                         ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}

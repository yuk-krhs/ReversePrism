using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FirstGlyphIndex                          0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 SecondGlyphIndex                         0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 Key                                      0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class GlyphPairKey
    {
        public uint                                     FirstGlyphIndex                         { get; set; }
        public uint                                     SecondGlyphIndex                        { get; set; }
        public uint                                     Key                                     { get; set; }

        public static GlyphPairKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlyphPairKey();

            value.FirstGlyphIndex                           = GetUInt32(new IntPtr(p + 0x010)); // 0270DA631B08 0x10 FirstGlyphIndex             ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.SecondGlyphIndex                          = GetUInt32(new IntPtr(p + 0x014)); // 0270DA631B28 0x14 SecondGlyphIndex            ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.Key                                       = GetUInt32(new IntPtr(p + 0x018)); // 0270DA631B48 0x18 Key                         ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}

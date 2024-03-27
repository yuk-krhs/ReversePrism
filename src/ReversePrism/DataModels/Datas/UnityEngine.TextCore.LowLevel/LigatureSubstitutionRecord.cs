using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ComponentGlyphIDs                      000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 018 M_LigatureGlyphID                        000186698B70 ModelPrimitiveType uint uint uint UInt32
    public partial class LigatureSubstitutionRecord
    {
        public List<uint>?                              M_ComponentGlyphIDs                     { get; set; }
        public uint                                     M_LigatureGlyphID                       { get; set; }

        public static LigatureSubstitutionRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LigatureSubstitutionRecord();

            value.M_ComponentGlyphIDs                       = GetUInt32List(new IntPtr(p + 0x010)); // 02700216FE20 0x10 M_ComponentGlyphIDs         ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.M_LigatureGlyphID                         = GetUInt32(new IntPtr(p + 0x018)); // 02700216FE40 0x18 M_LigatureGlyphID           ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}

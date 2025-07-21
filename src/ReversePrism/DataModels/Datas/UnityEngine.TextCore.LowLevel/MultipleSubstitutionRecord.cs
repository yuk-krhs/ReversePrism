using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_TargetGlyphID                          ModelPrimitiveType uint uint uint UInt32
    // 018 M_SubstituteGlyphIDs                     ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class MultipleSubstitutionRecord : DataModel
    {
        public uint                                     M_TargetGlyphID                         { get; set; }
        public List<uint>?                              M_SubstituteGlyphIDs                    { get; set; }

        public static MultipleSubstitutionRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultipleSubstitutionRecord() { Pointer= p0 };

            value.M_TargetGlyphID                           = GetUInt32(new IntPtr(p + 0x010)); // 0x10 M_TargetGlyphID             ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_SubstituteGlyphIDs                      = GetUInt32List(new IntPtr(p + 0x018)); // 0x18 M_SubstituteGlyphIDs        ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}

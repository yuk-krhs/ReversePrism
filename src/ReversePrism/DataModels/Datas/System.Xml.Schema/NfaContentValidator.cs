using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Firstpos                                 ModelClassType BitSet BitSet BitSet Pointer
    // 020 Followpos                                ModelClassListType BitSet[] BitSet[] List<BitSet> Pointer
    // 028 Symbols                                  ModelClassType SymbolsDictionary SymbolsDictionary SymbolsDictionary Pointer
    // 030 Positions                                ModelClassType Positions Positions Positions Pointer
    // 038 EndMarkerPos                             ModelPrimitiveType int int int Int32
    public partial class NfaContentValidator : DataModel
    {
        public BitSet?                                  Firstpos                                { get; set; }
        public List<BitSet>?                            Followpos                               { get; set; }
        public SymbolsDictionary?                       Symbols                                 { get; set; }
        public Positions?                               Positions                               { get; set; }
        public int                                      EndMarkerPos                            { get; set; }

        public static NfaContentValidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NfaContentValidator() { Pointer= p0 };

            value.Firstpos                                  = GetObject<BitSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.BitSet.FromPointer); // 0x18 Firstpos                    ( ModelClassType BitSet BitSet BitSet Pointer )
            value.Followpos                                 = GetObjectList<BitSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.BitSet.FromPointer); // 0x20 Followpos                   ( ModelClassListType BitSet[] BitSet[] List<BitSet> Pointer )
            value.Symbols                                   = GetObject<SymbolsDictionary>(new IntPtr(p + 0x028), ReversePrism.DataModels.SymbolsDictionary.FromPointer); // 0x28 Symbols                     ( ModelClassType SymbolsDictionary SymbolsDictionary SymbolsDictionary Pointer )
            value.Positions                                 = GetObject<Positions>(new IntPtr(p + 0x030), ReversePrism.DataModels.Positions.FromPointer); // 0x30 Positions                   ( ModelClassType Positions Positions Positions Pointer )
            value.EndMarkerPos                              = GetInt32(new IntPtr(p + 0x038)); // 0x38 EndMarkerPos                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

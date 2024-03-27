using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Firstpos                                 000186593A90 ModelClassType BitSet BitSet BitSet Pointer
    // 020 Followpos                                000185B71E20 ModelClassListType BitSet[] BitSet[] List<BitSet> Pointer
    // 028 Symbols                                  0001866005F0 ModelClassType SymbolsDictionary SymbolsDictionary SymbolsDictionary Pointer
    // 030 Positions                                000186768E20 ModelClassType Positions Positions Positions Pointer
    // 038 EndMarkerPos                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class NfaContentValidator
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
            var value   = new NfaContentValidator();

            value.Firstpos                                  = GetObject<BitSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74FEEA8 0x18 Firstpos                    ( 000186593A90 ModelClassType BitSet BitSet BitSet Pointer )
            value.Followpos                                 = GetObjectList<BitSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74FEEC8 0x20 Followpos                   ( 000185B71E20 ModelClassListType BitSet[] BitSet[] List<BitSet> Pointer )
            value.Symbols                                   = GetObject<SymbolsDictionary>(new IntPtr(p + 0x028), ReversePrism.DataModels.SymbolsDictionary.FromPointer); // 0270D74FEEE8 0x28 Symbols                     ( 0001866005F0 ModelClassType SymbolsDictionary SymbolsDictionary SymbolsDictionary Pointer )
            value.Positions                                 = GetObject<Positions>(new IntPtr(p + 0x030), ReversePrism.DataModels.Positions.FromPointer); // 0270D74FEF08 0x30 Positions                   ( 000186768E20 ModelClassType Positions Positions Positions Pointer )
            value.EndMarkerPos                              = GetInt32(new IntPtr(p + 0x038)); // 0270D74FEF28 0x38 EndMarkerPos                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

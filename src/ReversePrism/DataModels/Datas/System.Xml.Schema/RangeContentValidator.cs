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
    // 028 PositionsWithRangeTerminals              000186593A90 ModelClassType BitSet BitSet BitSet Pointer
    // 030 Symbols                                  0001866005F0 ModelClassType SymbolsDictionary SymbolsDictionary SymbolsDictionary Pointer
    // 038 Positions                                000186768E20 ModelClassType Positions Positions Positions Pointer
    // 040 MinMaxNodesCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 044 EndMarkerPos                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class RangeContentValidator
    {
        public BitSet?                                  Firstpos                                { get; set; }
        public List<BitSet>?                            Followpos                               { get; set; }
        public BitSet?                                  PositionsWithRangeTerminals             { get; set; }
        public SymbolsDictionary?                       Symbols                                 { get; set; }
        public Positions?                               Positions                               { get; set; }
        public int                                      MinMaxNodesCount                        { get; set; }
        public int                                      EndMarkerPos                            { get; set; }

        public static RangeContentValidator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RangeContentValidator();

            value.Firstpos                                  = GetObject<BitSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74FF258 0x18 Firstpos                    ( 000186593A90 ModelClassType BitSet BitSet BitSet Pointer )
            value.Followpos                                 = GetObjectList<BitSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74FF278 0x20 Followpos                   ( 000185B71E20 ModelClassListType BitSet[] BitSet[] List<BitSet> Pointer )
            value.PositionsWithRangeTerminals               = GetObject<BitSet>(new IntPtr(p + 0x028), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74FF298 0x28 PositionsWithRangeTerminals ( 000186593A90 ModelClassType BitSet BitSet BitSet Pointer )
            value.Symbols                                   = GetObject<SymbolsDictionary>(new IntPtr(p + 0x030), ReversePrism.DataModels.SymbolsDictionary.FromPointer); // 0270D74FF2B8 0x30 Symbols                     ( 0001866005F0 ModelClassType SymbolsDictionary SymbolsDictionary SymbolsDictionary Pointer )
            value.Positions                                 = GetObject<Positions>(new IntPtr(p + 0x038), ReversePrism.DataModels.Positions.FromPointer); // 0270D74FF2D8 0x38 Positions                   ( 000186768E20 ModelClassType Positions Positions Positions Pointer )
            value.MinMaxNodesCount                          = GetInt32(new IntPtr(p + 0x040)); // 0270D74FF2F8 0x40 MinMaxNodesCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndMarkerPos                              = GetInt32(new IntPtr(p + 0x044)); // 0270D74FF318 0x44 EndMarkerPos                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 This                                     0001867275A0 ModelClassType SequenceNode SequenceNode SequenceNode Pointer
    // 018 Firstpos                                 000186593D40 ModelClassType BitSet BitSet BitSet Pointer
    // 020 Lastpos                                  000186593D40 ModelClassType BitSet BitSet BitSet Pointer
    // 028 LastposLeft                              000186593D40 ModelClassType BitSet BitSet BitSet Pointer
    // 030 FirstposRight                            000186593D40 ModelClassType BitSet BitSet BitSet Pointer
    public partial class SequenceConstructPosContext
    {
        public SequenceNode?                            This                                    { get; set; }
        public BitSet?                                  Firstpos                                { get; set; }
        public BitSet?                                  Lastpos                                 { get; set; }
        public BitSet?                                  LastposLeft                             { get; set; }
        public BitSet?                                  FirstposRight                           { get; set; }

        public static SequenceConstructPosContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SequenceConstructPosContext();

            value.This                                      = GetObject<SequenceNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.SequenceNode.FromPointer); // 0270D74FDD28 0x10 This                        ( 0001867275A0 ModelClassType SequenceNode SequenceNode SequenceNode Pointer )
            value.Firstpos                                  = GetObject<BitSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74FDD48 0x18 Firstpos                    ( 000186593D40 ModelClassType BitSet BitSet BitSet Pointer )
            value.Lastpos                                   = GetObject<BitSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74FDD68 0x20 Lastpos                     ( 000186593D40 ModelClassType BitSet BitSet BitSet Pointer )
            value.LastposLeft                               = GetObject<BitSet>(new IntPtr(p + 0x028), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74FDD88 0x28 LastposLeft                 ( 000186593D40 ModelClassType BitSet BitSet BitSet Pointer )
            value.FirstposRight                             = GetObject<BitSet>(new IntPtr(p + 0x030), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74FDDA8 0x30 FirstposRight               ( 000186593D40 ModelClassType BitSet BitSet BitSet Pointer )

            return value;
        }
    }
}

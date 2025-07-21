using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 This                                     ModelClassType SequenceNode SequenceNode SequenceNode Pointer
    // 018 Firstpos                                 ModelClassType BitSet BitSet BitSet Pointer
    // 020 Lastpos                                  ModelClassType BitSet BitSet BitSet Pointer
    // 028 LastposLeft                              ModelClassType BitSet BitSet BitSet Pointer
    // 030 FirstposRight                            ModelClassType BitSet BitSet BitSet Pointer
    public partial class SequenceConstructPosContext : DataModel
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
            var value   = new SequenceConstructPosContext() { Pointer= p0 };

            value.This                                      = GetObject<SequenceNode>(new IntPtr(p + 0x010), ReversePrism.DataModels.SequenceNode.FromPointer); // 0x10 This                        ( ModelClassType SequenceNode SequenceNode SequenceNode Pointer )
            value.Firstpos                                  = GetObject<BitSet>(new IntPtr(p + 0x018), ReversePrism.DataModels.BitSet.FromPointer); // 0x18 Firstpos                    ( ModelClassType BitSet BitSet BitSet Pointer )
            value.Lastpos                                   = GetObject<BitSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.BitSet.FromPointer); // 0x20 Lastpos                     ( ModelClassType BitSet BitSet BitSet Pointer )
            value.LastposLeft                               = GetObject<BitSet>(new IntPtr(p + 0x028), ReversePrism.DataModels.BitSet.FromPointer); // 0x28 LastposLeft                 ( ModelClassType BitSet BitSet BitSet Pointer )
            value.FirstposRight                             = GetObject<BitSet>(new IntPtr(p + 0x030), ReversePrism.DataModels.BitSet.FromPointer); // 0x30 FirstposRight               ( ModelClassType BitSet BitSet BitSet Pointer )

            return value;
        }
    }
}

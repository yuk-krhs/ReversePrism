using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Min                                      0001865C0970 ModelEnumType Decimal Decimal Decimal Int32
    // 028 Max                                      0001865C0970 ModelEnumType Decimal Decimal Decimal Int32
    // 038 NextIteration                            000186593A90 ModelClassType BitSet BitSet BitSet Pointer
    public partial class LeafRangeNode
    {
        public Decimal                                  Min                                     { get; set; }
        public Decimal                                  Max                                     { get; set; }
        public BitSet?                                  NextIteration                           { get; set; }

        public static LeafRangeNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LeafRangeNode();

            value.Min                                       = (Decimal)GetInt32(new IntPtr(p + 0x018)); // 0270D74FE698 0x18 Min                         ( 0001865C0970 ModelEnumType Decimal Decimal Decimal Int32 )
            value.Max                                       = (Decimal)GetInt32(new IntPtr(p + 0x028)); // 0270D74FE6B8 0x28 Max                         ( 0001865C0970 ModelEnumType Decimal Decimal Decimal Int32 )
            value.NextIteration                             = GetObject<BitSet>(new IntPtr(p + 0x038), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74FE6D8 0x38 NextIteration               ( 000186593A90 ModelClassType BitSet BitSet BitSet Pointer )

            return value;
        }
    }
}

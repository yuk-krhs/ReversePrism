using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Curpos                                   ModelClassType BitSet BitSet BitSet Pointer
    // 018 RangeCounters                            ModelEnumListType Decimal[] Decimal[] List<Decimal> Pointer
    public partial class RangePositionInfo : DataModel
    {
        public BitSet?                                  Curpos                                  { get; set; }
        public List<Decimal>?                           RangeCounters                           { get; set; }

        public static RangePositionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RangePositionInfo() { Pointer= p0 };

            value.Curpos                                    = GetObject<BitSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.BitSet.FromPointer); // 0x10 Curpos                      ( ModelClassType BitSet BitSet BitSet Pointer )
            value.RangeCounters                             = GetEnumList<Decimal>(new IntPtr(p + 0x018)); // 0x18 RangeCounters               ( ModelEnumListType Decimal[] Decimal[] List<Decimal> Pointer )

            return value;
        }
    }
}

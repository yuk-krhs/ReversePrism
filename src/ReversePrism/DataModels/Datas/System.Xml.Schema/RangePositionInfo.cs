using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Curpos                                   000186593D40 ModelClassType BitSet BitSet BitSet Pointer
    // 018 RangeCounters                            000185B7C5E0 ModelEnumListType Decimal[] Decimal[] List<Decimal> Pointer
    public partial class RangePositionInfo
    {
        public BitSet?                                  Curpos                                  { get; set; }
        public List<Decimal>?                           RangeCounters                           { get; set; }

        public static RangePositionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RangePositionInfo();

            value.Curpos                                    = GetObject<BitSet>(new IntPtr(p + 0x010), ReversePrism.DataModels.BitSet.FromPointer); // 0270D74FF218 0x10 Curpos                      ( 000186593D40 ModelClassType BitSet BitSet BitSet Pointer )
            value.RangeCounters                             = GetEnumList<Decimal>(new IntPtr(p + 0x018)); // 0270D74FF238 0x18 RangeCounters               ( 000185B7C5E0 ModelEnumListType Decimal[] Decimal[] List<Decimal> Pointer )

            return value;
        }
    }
}

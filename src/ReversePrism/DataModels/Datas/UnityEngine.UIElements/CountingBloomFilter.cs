using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Counters                               ModelEnumType <m_Counters>e__FixedBuffer <m_Counters>e__FixedBuffer <m_Counters>e__FixedBuffer Int32
    public partial class CountingBloomFilter : DataModel
    {
        public <m_Counters>e__FixedBuffer               M_Counters                              { get; set; }

        public static CountingBloomFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CountingBloomFilter() { Pointer= p0 };

            value.M_Counters                                = (<m_Counters>e__FixedBuffer)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Counters                  ( ModelEnumType <m_Counters>e__FixedBuffer <m_Counters>e__FixedBuffer <m_Counters>e__FixedBuffer Int32 )

            return value;
        }
    }
}

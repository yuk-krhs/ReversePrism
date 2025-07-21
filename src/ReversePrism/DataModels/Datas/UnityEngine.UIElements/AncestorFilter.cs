using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_CountingBloomFilter                    ModelEnumType CountingBloomFilter CountingBloomFilter CountingBloomFilter Int32
    // 4010 m_HashStack                              Stack`1<int> IL2CPP_TYPE_GENERICINST
    public partial class AncestorFilter : DataModel
    {
        public CountingBloomFilter                      M_CountingBloomFilter                   { get; set; }

        public static AncestorFilter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AncestorFilter() { Pointer= p0 };

            value.M_CountingBloomFilter                     = (CountingBloomFilter)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_CountingBloomFilter       ( ModelEnumType CountingBloomFilter CountingBloomFilter CountingBloomFilter Int32 )

            return value;
        }
    }
}

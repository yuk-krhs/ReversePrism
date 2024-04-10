using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 primes                                   int[] IL2CPP_TYPE_SZARRAY
    // 008 s_serializationInfoTable                 ConditionalWeakTable`2<<object>, SerializationInfo> IL2CPP_TYPE_GENERICINST
    public partial class HashHelpers : DataModel
    {

        public static HashHelpers? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HashHelpers() { Pointer= p0 };


            return value;
        }
    }
}

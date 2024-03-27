using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   000185B71900 ModelEnumListType BigInteger[] BigInteger[] List<BigInteger> Pointer
    public partial class BigIntegerStorage
    {
        public List<BigInteger>?                        Values                                  { get; set; }

        public static BigIntegerStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BigIntegerStorage();

            value.Values                                    = GetEnumList<BigInteger>(new IntPtr(p + 0x050)); // 0270D89A68C8 0x50 Values                      ( 000185B71900 ModelEnumListType BigInteger[] BigInteger[] List<BigInteger> Pointer )

            return value;
        }
    }
}

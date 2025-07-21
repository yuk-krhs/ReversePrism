using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Values                                   ModelEnumListType BigInteger[] BigInteger[] List<BigInteger> Pointer
    public partial class BigIntegerStorage : DataModel
    {
        public List<BigInteger>?                        Values                                  { get; set; }

        public static BigIntegerStorage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BigIntegerStorage() { Pointer= p0 };

            value.Values                                    = GetEnumList<BigInteger>(new IntPtr(p + 0x050)); // 0x50 Values                      ( ModelEnumListType BigInteger[] BigInteger[] List<BigInteger> Pointer )

            return value;
        }
    }
}

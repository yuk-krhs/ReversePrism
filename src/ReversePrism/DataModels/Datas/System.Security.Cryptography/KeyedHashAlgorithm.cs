using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 KeyValue                                 000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class KeyedHashAlgorithm
    {
        public List<sbyte>?                             KeyValue                                { get; set; }

        public static KeyedHashAlgorithm? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyedHashAlgorithm();

            value.KeyValue                                  = GetSByteList(new IntPtr(p + 0x028)); // 027003D043B8 0x28 KeyValue                    ( 000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NullableFlags                            000185B7A1A0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class NullableAttribute
    {
        public List<sbyte>?                             NullableFlags                           { get; set; }

        public static NullableAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NullableAttribute();

            value.NullableFlags                             = GetSByteList(new IntPtr(p + 0x010)); // 02700692D018 0x10 NullableFlags               ( 000185B7A1A0 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}

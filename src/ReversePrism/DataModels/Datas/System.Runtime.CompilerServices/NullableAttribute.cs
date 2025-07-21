using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NullableFlags                            ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class NullableAttribute : DataModel
    {
        public List<sbyte>?                             NullableFlags                           { get; set; }

        public static NullableAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NullableAttribute() { Pointer= p0 };

            value.NullableFlags                             = GetSByteList(new IntPtr(p + 0x010)); // 0x10 NullableFlags               ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}

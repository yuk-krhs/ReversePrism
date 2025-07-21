using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 000 Null                                     SqlBinary IL2CPP_TYPE_VALUETYPE
    public partial class SqlBinary : DataModel
    {
        public List<sbyte>?                             Value                                   { get; set; }

        public static SqlBinary? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SqlBinary() { Pointer= p0 };

            value.Value                                     = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}

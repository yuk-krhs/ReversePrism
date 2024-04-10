using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 char2val                                 sbyte[] IL2CPP_TYPE_SZARRAY
    // 008 val2char                                 string IL2CPP_TYPE_STRING
    // 010 Val2byte                                 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class Base64Encoding : DataModel
    {
        public List<sbyte>?                             Val2byte                                { get; set; }

        public static Base64Encoding? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Base64Encoding() { Pointer= p0 };

            value.Val2byte                                  = GetSByteList(new IntPtr(p + 0x010)); // 024667C65340 0x10 Val2byte                    ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}

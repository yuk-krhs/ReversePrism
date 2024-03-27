using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Bytes                                    000185B79F90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 StatusCode                               0001865F8300 ModelPrimitiveType long long long Int64
    // 020 <ResponseHeaders>k__BackingField         Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class ResponseContext
    {
        public List<sbyte>?                             Bytes                                   { get; set; }
        public long                                     StatusCode                              { get; set; }

        public static ResponseContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResponseContext();

            value.Bytes                                     = GetSByteList(new IntPtr(p + 0x010)); // 027004E1B980 0x10 Bytes                       ( 000185B79F90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StatusCode                                = GetInt64(new IntPtr(p + 0x018)); // 027004E1B9A0 0x18 StatusCode                  ( 0001865F8300 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}

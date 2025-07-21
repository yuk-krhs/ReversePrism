using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Count                                    ModelPrimitiveType long long long Int64
    // 038 StateSHA256                              ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 040 W                                        ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 000 _K                                       uint[] IL2CPP_TYPE_SZARRAY
    public partial class SHA256Managed : DataModel
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public long                                     Count                                   { get; set; }
        public List<uint>?                              StateSHA256                             { get; set; }
        public List<uint>?                              W                                       { get; set; }

        public static SHA256Managed? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SHA256Managed() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Count                                     = GetInt64(new IntPtr(p + 0x030)); // 0x30 Count                       ( ModelPrimitiveType long long long Int64 )
            value.StateSHA256                               = GetUInt32List(new IntPtr(p + 0x038)); // 0x38 StateSHA256                 ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.W                                         = GetUInt32List(new IntPtr(p + 0x040)); // 0x40 W                           ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}

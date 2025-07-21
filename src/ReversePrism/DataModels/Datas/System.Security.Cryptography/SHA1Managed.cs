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
    // 038 StateSHA1                                ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 040 ExpandedBuffer                           ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class SHA1Managed : DataModel
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public long                                     Count                                   { get; set; }
        public List<uint>?                              StateSHA1                               { get; set; }
        public List<uint>?                              ExpandedBuffer                          { get; set; }

        public static SHA1Managed? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SHA1Managed() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Count                                     = GetInt64(new IntPtr(p + 0x030)); // 0x30 Count                       ( ModelPrimitiveType long long long Int64 )
            value.StateSHA1                                 = GetUInt32List(new IntPtr(p + 0x038)); // 0x38 StateSHA1                   ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.ExpandedBuffer                            = GetUInt32List(new IntPtr(p + 0x040)); // 0x40 ExpandedBuffer              ( ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}

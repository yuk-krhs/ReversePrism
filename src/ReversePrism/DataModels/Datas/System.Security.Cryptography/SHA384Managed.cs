using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 Count                                    00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 038 StateSHA384                              000185B84460 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer
    // 040 W                                        000185B84460 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer
    // 000 _K                                       ulong[] IL2CPP_TYPE_SZARRAY
    public partial class SHA384Managed : DataModel
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public ulong                                    Count                                   { get; set; }
        public List<ulong>?                             StateSHA384                             { get; set; }
        public List<ulong>?                             W                                       { get; set; }

        public static SHA384Managed? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SHA384Managed() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x028)); // 024661938E78 0x28 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Count                                     = GetUInt64(new IntPtr(p + 0x030)); // 024661938E98 0x30 Count                       ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.StateSHA384                               = GetUInt64List(new IntPtr(p + 0x038)); // 024661938EB8 0x38 StateSHA384                 ( 000185B84460 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer )
            value.W                                         = GetUInt64List(new IntPtr(p + 0x040)); // 024661938ED8 0x40 W                           ( 000185B84460 ModelPrimitiveListType ulong[] ulong[] List<ulong> Pointer )

            return value;
        }
    }
}

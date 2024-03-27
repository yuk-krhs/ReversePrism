using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buffer                                   000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Offset                                   0001865F2F90 ModelPrimitiveType int int int Int32
    // 01C Count                                    0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class ReadWriteParameters
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }

        public static ReadWriteParameters? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadWriteParameters();

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 0270D6E3BDB0 0x10 Buffer                      ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D6E3BDD0 0x18 Offset                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D6E3BDF0 0x1C Count                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

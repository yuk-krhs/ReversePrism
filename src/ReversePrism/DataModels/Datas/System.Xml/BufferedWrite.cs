using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class BufferedWrite
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Offset                                  { get; set; }

        public static BufferedWrite? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferedWrite();

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 0270D7CB0400 0x10 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D7CB0420 0x18 Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

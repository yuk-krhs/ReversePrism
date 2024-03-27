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
    // 01C Size                                     0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class BufferOffsetSize
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Size                                    { get; set; }

        public static BufferOffsetSize? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferOffsetSize();

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 0270D7A310C8 0x10 Buffer                      ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D7A310E8 0x18 Offset                      ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x01C)); // 0270D7A31108 0x1C Size                        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

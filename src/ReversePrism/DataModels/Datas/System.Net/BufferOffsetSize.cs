using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Offset                                   ModelPrimitiveType int int int Int32
    // 01C Size                                     ModelPrimitiveType int int int Int32
    public partial class BufferOffsetSize : DataModel
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Size                                    { get; set; }

        public static BufferOffsetSize? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferOffsetSize() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 Offset                      ( ModelPrimitiveType int int int Int32 )
            value.Size                                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Size                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

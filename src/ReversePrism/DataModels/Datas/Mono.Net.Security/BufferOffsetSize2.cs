using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 InitialSize                              0001865F4940 ModelPrimitiveType int int int Int32
    public partial class BufferOffsetSize2 : DataModel
    {
        public int                                      InitialSize                             { get; set; }

        public static BufferOffsetSize2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BufferOffsetSize2() { Pointer= p0 };

            value.InitialSize                               = GetInt32(new IntPtr(p + 0x028)); // 024667974610 0x28 InitialSize                 ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

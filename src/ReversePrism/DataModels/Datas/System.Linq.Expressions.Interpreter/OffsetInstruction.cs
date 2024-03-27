using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Offset                                   0001865F3220 ModelPrimitiveType int int int Int32
    public partial class OffsetInstruction
    {
        public int                                      Offset                                  { get; set; }

        public static OffsetInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OffsetInstruction();

            value.Offset                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D9FA0CA0 0x10 Offset                      ( 0001865F3220 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

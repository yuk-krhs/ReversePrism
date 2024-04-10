using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExecutionStackCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StackGuard : DataModel
    {
        public int                                      ExecutionStackCount                     { get; set; }

        public static StackGuard? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StackGuard() { Pointer= p0 };

            value.ExecutionStackCount                       = GetInt32(new IntPtr(p + 0x010)); // 024669FEC330 0x10 ExecutionStackCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

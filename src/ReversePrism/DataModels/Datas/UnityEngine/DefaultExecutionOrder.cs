using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Order                                  ModelPrimitiveType int int int Int32
    public partial class DefaultExecutionOrder : DataModel
    {
        public int                                      M_Order                                 { get; set; }

        public static DefaultExecutionOrder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultExecutionOrder() { Pointer= p0 };

            value.M_Order                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Order                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

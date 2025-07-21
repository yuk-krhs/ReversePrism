using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ErrorCode                              ModelPrimitiveType int int int Int32
    public partial class ErrorWrapper : DataModel
    {
        public int                                      M_ErrorCode                             { get; set; }

        public static ErrorWrapper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ErrorWrapper() { Pointer= p0 };

            value.M_ErrorCode                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_ErrorCode                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

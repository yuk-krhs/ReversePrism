using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 ErrorCode                                0001865F4260 ModelPrimitiveType int int int Int32
    public partial class RequestFailedException
    {
        public int                                      ErrorCode                               { get; set; }

        public static RequestFailedException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RequestFailedException();

            value.ErrorCode                                 = GetInt32(new IntPtr(p + 0x090)); // 0270DB7B7A68 0x90 ErrorCode                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

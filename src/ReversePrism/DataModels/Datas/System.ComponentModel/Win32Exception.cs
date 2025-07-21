using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 NativeErrorCode                          ModelPrimitiveType int int int Int32
    public partial class Win32Exception : DataModel
    {
        public int                                      NativeErrorCode                         { get; set; }

        public static Win32Exception? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Win32Exception() { Pointer= p0 };

            value.NativeErrorCode                           = GetInt32(new IntPtr(p + 0x090)); // 0x90 NativeErrorCode             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

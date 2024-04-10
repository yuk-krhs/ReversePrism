using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 PermissionState                          000186671910 ModelPrimitiveType string string string String
    public partial class SecurityException : DataModel
    {
        public string                                   PermissionState                         { get; set; }

        public static SecurityException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SecurityException() { Pointer= p0 };

            value.PermissionState                           = GetString(new IntPtr(p + 0x090)); // 024666BE1D38 0x90 PermissionState             ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}

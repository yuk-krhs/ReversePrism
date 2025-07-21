using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _FsrEasuConstants0                       int IL2CPP_TYPE_I4
    // 004 _FsrEasuConstants1                       int IL2CPP_TYPE_I4
    // 008 _FsrEasuConstants2                       int IL2CPP_TYPE_I4
    // 00C _FsrEasuConstants3                       int IL2CPP_TYPE_I4
    // 010 FsrRcasConstants                         ModelPrimitiveType int int int Int32
    public partial class ShaderConstants : DataModel
    {
        public int                                      FsrRcasConstants                        { get; set; }

        public static ShaderConstants? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderConstants() { Pointer= p0 };

            value.FsrRcasConstants                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 FsrRcasConstants            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

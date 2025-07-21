using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 p8                                       IntPtr IL2CPP_TYPE_PTR
    // 010 p32                                      IntPtr IL2CPP_TYPE_PTR
    // 010 p64                                      IntPtr IL2CPP_TYPE_PTR
    // 010 I                                        ModelPrimitiveType ulong ulong ulong UInt64
    public partial class U : DataModel
    {
        public ulong                                    I                                       { get; set; }

        public static U? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new U() { Pointer= p0 };

            value.I                                         = GetUInt64(new IntPtr(p + 0x010)); // 0x10 I                           ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}

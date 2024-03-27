using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handle                                   00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64
    public partial class unitytls_key_ref
    {
        public ulong                                    Handle                                  { get; set; }

        public static unitytls_key_ref? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new unitytls_key_ref();

            value.Handle                                    = GetUInt64(new IntPtr(p + 0x010)); // 0270D78EA068 0x10 Handle                      ( 00018669BD60 ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}

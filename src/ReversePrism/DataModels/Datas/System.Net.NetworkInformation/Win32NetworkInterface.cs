using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 fixedInfo                                Win32_FIXED_INFO IL2CPP_TYPE_VALUETYPE
    // 058 Initialized                              000186595C30 ModelPrimitiveType bool bool bool Bool
    public partial class Win32NetworkInterface
    {
        public bool                                     Initialized                             { get; set; }

        public static Win32NetworkInterface? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Win32NetworkInterface();

            value.Initialized                               = GetBool(new IntPtr(p + 0x058)); // 0270D7AE3770 0x58 Initialized                 ( 000186595C30 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

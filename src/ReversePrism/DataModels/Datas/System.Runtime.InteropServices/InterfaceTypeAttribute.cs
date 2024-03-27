using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Val                                      0001865D8B40 ModelEnumType ComInterfaceType ComInterfaceType ComInterfaceType Int32
    public partial class InterfaceTypeAttribute
    {
        public ComInterfaceType                         Val                                     { get; set; }

        public static InterfaceTypeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InterfaceTypeAttribute();

            value.Val                                       = (ComInterfaceType)GetInt32(new IntPtr(p + 0x010)); // 0270D6C82488 0x10 Val                         ( 0001865D8B40 ModelEnumType ComInterfaceType ComInterfaceType ComInterfaceType Int32 )

            return value;
        }
    }
}

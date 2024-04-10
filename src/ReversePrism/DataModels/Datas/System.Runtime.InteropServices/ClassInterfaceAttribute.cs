using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Val                                      0001865B0A90 ModelEnumType ClassInterfaceType ClassInterfaceType ClassInterfaceType Int32
    public partial class ClassInterfaceAttribute : DataModel
    {
        public ClassInterfaceType                       Val                                     { get; set; }

        public static ClassInterfaceAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ClassInterfaceAttribute() { Pointer= p0 };

            value.Val                                       = (ClassInterfaceType)GetInt32(new IntPtr(p + 0x010)); // 0245A5FE73B0 0x10 Val                         ( 0001865B0A90 ModelEnumType ClassInterfaceType ClassInterfaceType ClassInterfaceType Int32 )

            return value;
        }
    }
}

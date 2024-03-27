using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SubMenuPath                              000186672F10 ModelPrimitiveType string string string String
    public partial class DropdownMenuSeparator
    {
        public string                                   SubMenuPath                             { get; set; }

        public static DropdownMenuSeparator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DropdownMenuSeparator();

            value.SubMenuPath                               = GetString(new IntPtr(p + 0x010)); // 027006757D80 0x10 SubMenuPath                 ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}

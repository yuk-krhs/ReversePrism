using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Tooltip                                  0001866736C0 ModelPrimitiveType string string string String
    public partial class TooltipAttribute : DataModel
    {
        public string                                   Tooltip                                 { get; set; }

        public static TooltipAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TooltipAttribute() { Pointer= p0 };

            value.Tooltip                                   = GetString(new IntPtr(p + 0x010)); // 0245A687AA88 0x10 Tooltip                     ( 0001866736C0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}

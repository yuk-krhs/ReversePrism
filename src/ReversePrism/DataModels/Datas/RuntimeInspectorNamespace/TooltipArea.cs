using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TooltipListener                          00018668C630 ModelClassType TooltipListener TooltipListener TooltipListener Pointer
    // 028 TooltipContent                           000186677380 ModelClassType ITooltipContent ITooltipContent ITooltipContent Pointer
    public partial class TooltipArea
    {
        public TooltipListener?                         TooltipListener                         { get; set; }
        public ITooltipContent?                         TooltipContent                          { get; set; }

        public static TooltipArea? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TooltipArea();

            value.TooltipListener                           = GetObject<TooltipListener>(new IntPtr(p + 0x020), ReversePrism.DataModels.TooltipListener.FromPointer); // 0270DB232140 0x20 TooltipListener             ( 00018668C630 ModelClassType TooltipListener TooltipListener TooltipListener Pointer )
            value.TooltipContent                            = GetObject<ITooltipContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ITooltipContent.FromPointer); // 0270DB232160 0x28 TooltipContent              ( 000186677380 ModelClassType ITooltipContent ITooltipContent ITooltipContent Pointer )

            return value;
        }
    }
}

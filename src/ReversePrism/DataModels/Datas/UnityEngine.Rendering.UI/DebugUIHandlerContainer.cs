using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentHolder                            000186630900 ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class DebugUIHandlerContainer
    {
        public RectTransform?                           ContentHolder                           { get; set; }

        public static DebugUIHandlerContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerContainer();

            value.ContentHolder                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D931B090 0x20 ContentHolder               ( 000186630900 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}

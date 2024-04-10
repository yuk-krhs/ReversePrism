using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentHolder                            000186630900 ModelClassType RectTransform RectTransform RectTransform Pointer
    public partial class DebugUIHandlerContainer : DataModel
    {
        public RectTransform?                           ContentHolder                           { get; set; }

        public static DebugUIHandlerContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugUIHandlerContainer() { Pointer= p0 };

            value.ContentHolder                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 024669374528 0x20 ContentHolder               ( 000186630900 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}

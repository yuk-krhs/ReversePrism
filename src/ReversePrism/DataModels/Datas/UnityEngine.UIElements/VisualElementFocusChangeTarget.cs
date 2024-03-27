using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Pool                                     ObjectPool`1<VisualElementFocusChangeTarget> IL2CPP_TYPE_GENERICINST
    // 018 Target                                   0001865D3CE0 ModelClassType Focusable Focusable Focusable Pointer
    public partial class VisualElementFocusChangeTarget
    {
        public Focusable?                               Target                                  { get; set; }

        public static VisualElementFocusChangeTarget? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VisualElementFocusChangeTarget();

            value.Target                                    = GetObject<Focusable>(new IntPtr(p + 0x018), ReversePrism.DataModels.Focusable.FromPointer); // 02700685B300 0x18 Target                      ( 0001865D3CE0 ModelClassType Focusable Focusable Focusable Pointer )

            return value;
        }
    }
}

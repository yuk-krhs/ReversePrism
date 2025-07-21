using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 110 IsHandledByDraggable                     ModelPrimitiveType bool bool bool Bool
    public partial class PointerMoveEvent : DataModel
    {
        public bool                                     IsHandledByDraggable                    { get; set; }

        public static PointerMoveEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerMoveEvent() { Pointer= p0 };

            value.IsHandledByDraggable                      = GetBool(new IntPtr(p + 0x110)); // 0x110 IsHandledByDraggable        ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

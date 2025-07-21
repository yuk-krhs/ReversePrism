using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_TrackedButtons                         ModelClassListType List`1<ButtonState> List`1<ButtonState> List<ButtonState> Pointer
    public partial class MouseState : DataModel
    {
        public List<ButtonState>?                       M_TrackedButtons                        { get; set; }

        public static MouseState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MouseState() { Pointer= p0 };

            value.M_TrackedButtons                          = GetObjectList<ButtonState>(new IntPtr(p + 0x010), ReversePrism.DataModels.ButtonState.FromPointer); // 0x10 M_TrackedButtons            ( ModelClassListType List`1<ButtonState> List`1<ButtonState> List<ButtonState> Pointer )

            return value;
        }
    }
}

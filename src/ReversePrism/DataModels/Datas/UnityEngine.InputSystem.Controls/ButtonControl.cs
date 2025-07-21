using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 130 PressPoint                               ModelPrimitiveType float float float Single
    // 000 s_GlobalDefaultButtonPressPoint          float IL2CPP_TYPE_R4
    // 004 s_GlobalDefaultButtonReleaseThreshold    float IL2CPP_TYPE_R4
    // 000 kMinButtonPressPoint                     float IL2CPP_TYPE_R4
    public partial class ButtonControl : DataModel
    {
        public float                                    PressPoint                              { get; set; }

        public static ButtonControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonControl() { Pointer= p0 };

            value.PressPoint                                = GetSingle(new IntPtr(p + 0x130)); // 0x130 PressPoint                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}

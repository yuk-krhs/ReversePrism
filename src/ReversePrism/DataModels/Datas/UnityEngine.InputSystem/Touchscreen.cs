using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1A0 PrimaryTouch                             00018668E310 ModelClassType TouchControl TouchControl TouchControl Pointer
    // 1A8 <touches>k__BackingField                 ReadOnlyArray`1<TouchControl> IL2CPP_TYPE_GENERICINST
    // 000 <current>k__BackingField                 Touchscreen IL2CPP_TYPE_CLASS
    // 008 s_TapTime                                float IL2CPP_TYPE_R4
    // 00C s_TapDelayTime                           float IL2CPP_TYPE_R4
    // 010 S_TapRadiusSquared                       000186666530 ModelPrimitiveType float float float Single
    public partial class Touchscreen
    {
        public TouchControl?                            PrimaryTouch                            { get; set; }
        public float                                    S_TapRadiusSquared                      { get; set; }

        public static Touchscreen? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Touchscreen();

            value.PrimaryTouch                              = GetObject<TouchControl>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.TouchControl.FromPointer); // 0270033ADDF0 0x1A0 PrimaryTouch                ( 00018668E310 ModelClassType TouchControl TouchControl TouchControl Pointer )
            value.S_TapRadiusSquared                        = GetSingle(new IntPtr(p + 0x010)); // 0270033ADE90 0x10 S_TapRadiusSquared          ( 000186666530 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}

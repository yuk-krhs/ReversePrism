using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1A0 PrimaryTouch                             ModelClassType TouchControl TouchControl TouchControl Pointer
    // 1A8 <touches>k__BackingField                 ReadOnlyArray`1<TouchControl> IL2CPP_TYPE_GENERICINST
    // 000 <current>k__BackingField                 Touchscreen IL2CPP_TYPE_CLASS
    // 008 s_TapTime                                float IL2CPP_TYPE_R4
    // 00C s_TapDelayTime                           float IL2CPP_TYPE_R4
    // 010 S_TapRadiusSquared                       ModelPrimitiveType float float float Single
    public partial class Touchscreen : DataModel
    {
        public TouchControl?                            PrimaryTouch                            { get; set; }
        public float                                    S_TapRadiusSquared                      { get; set; }

        public static Touchscreen? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Touchscreen() { Pointer= p0 };

            value.PrimaryTouch                              = GetObject<TouchControl>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.TouchControl.FromPointer); // 0x1A0 PrimaryTouch                ( ModelClassType TouchControl TouchControl TouchControl Pointer )
            value.S_TapRadiusSquared                        = GetSingle(new IntPtr(p + 0x010)); // 0x10 S_TapRadiusSquared          ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 028 intParams                                Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 030 floatParams                              Dictionary`2<int, float> IL2CPP_TYPE_GENERICINST
    // 038 boolParams                               Dictionary`2<int, bool> IL2CPP_TYPE_GENERICINST
    // 040 triggerParams                            HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ParamRememberableAnimator
    {
        public Animator?                                Animator                                { get; set; }

        public static ParamRememberableAnimator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParamRememberableAnimator();

            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 027005AFF4B0 0x20 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}

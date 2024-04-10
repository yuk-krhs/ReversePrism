using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Anim                                     0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    public partial class ScreenTransitionCurtain : DataModel
    {
        public Animator?                                Anim                                    { get; set; }

        public static ScreenTransitionCurtain? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenTransitionCurtain() { Pointer= p0 };

            value.Anim                                      = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 02466BC96410 0x20 Anim                        ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TransitonAnimator                        ModelClassType Animator Animator Animator Pointer
    public partial class HomeTransitionView : DataModel
    {
        public Animator?                                TransitonAnimator                       { get; set; }

        public static HomeTransitionView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeTransitionView() { Pointer= p0 };

            value.TransitonAnimator                         = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0x20 TransitonAnimator           ( ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}

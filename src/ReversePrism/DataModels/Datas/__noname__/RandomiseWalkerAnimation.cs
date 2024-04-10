using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Animator                                 0001866B92A0 ModelClassType Animator Animator Animator Pointer
    public partial class RandomiseWalkerAnimation : DataModel
    {
        public Animator?                                Animator                                { get; set; }

        public static RandomiseWalkerAnimation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RandomiseWalkerAnimation() { Pointer= p0 };

            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 024664B71258 0x20 Animator                    ( 0001866B92A0 ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}

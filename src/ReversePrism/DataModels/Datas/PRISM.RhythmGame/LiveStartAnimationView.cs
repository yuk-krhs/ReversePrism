using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StartAnimators                           000185B701C0 ModelClassListType Animator[] Animator[] List<Animator> Pointer
    public partial class LiveStartAnimationView
    {
        public List<Animator>?                          StartAnimators                          { get; set; }

        public static LiveStartAnimationView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveStartAnimationView();

            value.StartAnimators                            = GetObjectList<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0270D50546C8 0x20 StartAnimators              ( 000185B701C0 ModelClassListType Animator[] Animator[] List<Animator> Pointer )

            return value;
        }
    }
}

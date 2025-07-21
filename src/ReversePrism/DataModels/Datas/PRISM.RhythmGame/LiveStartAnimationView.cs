using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StartAnimators                           ModelClassListType Animator[] Animator[] List<Animator> Pointer
    public partial class LiveStartAnimationView : DataModel
    {
        public List<Animator>?                          StartAnimators                          { get; set; }

        public static LiveStartAnimationView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveStartAnimationView() { Pointer= p0 };

            value.StartAnimators                            = GetObjectList<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0x20 StartAnimators              ( ModelClassListType Animator[] Animator[] List<Animator> Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScoreRankAnimator                        ModelClassType Animator Animator Animator Pointer
    public partial class ScoreRankIcon : DataModel
    {
        public Animator?                                ScoreRankAnimator                       { get; set; }

        public static ScoreRankIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScoreRankIcon() { Pointer= p0 };

            value.ScoreRankAnimator                         = GetObject<Animator>(new IntPtr(p + 0x020), ReversePrism.DataModels.Animator.FromPointer); // 0x20 ScoreRankAnimator           ( ModelClassType Animator Animator Animator Pointer )

            return value;
        }
    }
}

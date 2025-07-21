using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType IntroductionRewardView IntroductionRewardView IntroductionRewardView Pointer
    public partial class IntroductionRewardBuilder : DataModel
    {
        public IntroductionRewardView?                  View                                    { get; set; }

        public static IntroductionRewardBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionRewardBuilder() { Pointer= p0 };

            value.View                                      = GetObject<IntroductionRewardView>(new IntPtr(p + 0x020), ReversePrism.DataModels.IntroductionRewardView.FromPointer); // 0x20 View                        ( ModelClassType IntroductionRewardView IntroductionRewardView IntroductionRewardView Pointer )

            return value;
        }
    }
}

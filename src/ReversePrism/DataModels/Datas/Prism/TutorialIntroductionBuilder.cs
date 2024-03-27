using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     0001866BB500 ModelClassType TutorialIntroductionView TutorialIntroductionView TutorialIntroductionView Pointer
    public partial class TutorialIntroductionBuilder
    {
        public TutorialIntroductionView?                View                                    { get; set; }

        public static TutorialIntroductionBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialIntroductionBuilder();

            value.View                                      = GetObject<TutorialIntroductionView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TutorialIntroductionView.FromPointer); // 0270DB61FA70 0x20 View                        ( 0001866BB500 ModelClassType TutorialIntroductionView TutorialIntroductionView TutorialIntroductionView Pointer )

            return value;
        }
    }
}

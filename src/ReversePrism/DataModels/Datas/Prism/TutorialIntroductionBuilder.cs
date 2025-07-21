using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     ModelClassType TutorialIntroductionView TutorialIntroductionView TutorialIntroductionView Pointer
    public partial class TutorialIntroductionBuilder : DataModel
    {
        public TutorialIntroductionView?                View                                    { get; set; }

        public static TutorialIntroductionBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialIntroductionBuilder() { Pointer= p0 };

            value.View                                      = GetObject<TutorialIntroductionView>(new IntPtr(p + 0x020), ReversePrism.DataModels.TutorialIntroductionView.FromPointer); // 0x20 View                        ( ModelClassType TutorialIntroductionView TutorialIntroductionView TutorialIntroductionView Pointer )

            return value;
        }
    }
}

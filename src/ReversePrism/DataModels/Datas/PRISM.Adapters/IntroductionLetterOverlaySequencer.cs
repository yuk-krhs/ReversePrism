using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 factory                                  IOverlayViewFactory`1<IIntroductionLetterOverlayView> IL2CPP_TYPE_GENERICINST
    // 018 ViewModel                                000186730E20 ModelClassType IntroductionViewModel IntroductionViewModel IntroductionViewModel Pointer
    public partial class IntroductionLetterOverlaySequencer : DataModel
    {
        public IntroductionViewModel?                   ViewModel                               { get; set; }

        public static IntroductionLetterOverlaySequencer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionLetterOverlaySequencer() { Pointer= p0 };

            value.ViewModel                                 = GetObject<IntroductionViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntroductionViewModel.FromPointer); // 02466640D4B8 0x18 ViewModel                   ( 000186730E20 ModelClassType IntroductionViewModel IntroductionViewModel IntroductionViewModel Pointer )

            return value;
        }
    }
}

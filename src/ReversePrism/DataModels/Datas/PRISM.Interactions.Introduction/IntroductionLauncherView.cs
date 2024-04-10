using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 letterOverlayFactory                     OverlayViewFactory`1<IIntroductionLetterOverlayView> IL2CPP_TYPE_GENERICINST
    public partial class IntroductionLauncherView : DataModel
    {

        public static IntroductionLauncherView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionLauncherView() { Pointer= p0 };


            return value;
        }
    }
}

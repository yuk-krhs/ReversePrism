using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186586500 ModelClassType IIntroductionLauncherView IIntroductionLauncherView IIntroductionLauncherView Pointer
    // 018 Argument                                 000186726340 ModelClassType IntroductionLauncherArgument IntroductionLauncherArgument IntroductionLauncherArgument Pointer
    // 020 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class IntroductionLauncherPresenter : DataModel
    {
        public IIntroductionLauncherView?               View                                    { get; set; }
        public IntroductionLauncherArgument?            Argument                                { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }

        public static IntroductionLauncherPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionLauncherPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IIntroductionLauncherView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IIntroductionLauncherView.FromPointer); // 02466640CF88 0x10 View                        ( 000186586500 ModelClassType IIntroductionLauncherView IIntroductionLauncherView IIntroductionLauncherView Pointer )
            value.Argument                                  = GetObject<IntroductionLauncherArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntroductionLauncherArgument.FromPointer); // 02466640CFA8 0x18 Argument                    ( 000186726340 ModelClassType IntroductionLauncherArgument IntroductionLauncherArgument IntroductionLauncherArgument Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466640CFC8 0x20 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}

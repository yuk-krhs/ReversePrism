using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018667FD20 ModelClassType ITutorialIntroductionView ITutorialIntroductionView ITutorialIntroductionView Pointer
    // 018 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 IntroductionPhase                        0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class TutorialIntroductionPresenter
    {
        public ITutorialIntroductionView?               View                                    { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public int                                      IntroductionPhase                       { get; set; }

        public static TutorialIntroductionPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TutorialIntroductionPresenter();

            value.View                                      = GetObject<ITutorialIntroductionView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITutorialIntroductionView.FromPointer); // 0270D676EF48 0x10 View                        ( 00018667FD20 ModelClassType ITutorialIntroductionView ITutorialIntroductionView ITutorialIntroductionView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D676EF68 0x18 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IntroductionPhase                         = GetInt32(new IntPtr(p + 0x020)); // 0270D676EF88 0x20 IntroductionPhase           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186586F40 ModelClassType IIntroductionRewardView IIntroductionRewardView IIntroductionRewardView Pointer
    // 018 ViewModel                                000186730E20 ModelClassType IntroductionViewModel IntroductionViewModel IntroductionViewModel Pointer
    // 020 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class IntroductionRewardPresenter : DataModel
    {
        public IIntroductionRewardView?                 View                                    { get; set; }
        public IntroductionViewModel?                   ViewModel                               { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static IntroductionRewardPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionRewardPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IIntroductionRewardView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IIntroductionRewardView.FromPointer); // 02466640DF08 0x10 View                        ( 000186586F40 ModelClassType IIntroductionRewardView IIntroductionRewardView IIntroductionRewardView Pointer )
            value.ViewModel                                 = GetObject<IntroductionViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntroductionViewModel.FromPointer); // 02466640DF28 0x18 ViewModel                   ( 000186730E20 ModelClassType IntroductionViewModel IntroductionViewModel IntroductionViewModel Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466640DF48 0x20 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466640DF68 0x28 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}

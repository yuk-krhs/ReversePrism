using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Argument                                 000186579EE0 ModelClassType ChallengeTourResultArgument ChallengeTourResultArgument ChallengeTourResultArgument Pointer
    // 018 View                                     000186724E40 ModelClassType IChallengeTourResultView IChallengeTourResultView IChallengeTourResultView Pointer
    // 020 OverlayManager                           0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer
    // 028 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 ViewModel                                00018657D540 ModelClassType ChallengeTourResultViewModel ChallengeTourResultViewModel ChallengeTourResultViewModel Pointer
    public partial class ChallengeTourResultPresenter
    {
        public ChallengeTourResultArgument?             Argument                                { get; set; }
        public IChallengeTourResultView?                View                                    { get; set; }
        public OverlayManager?                          OverlayManager                          { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ChallengeTourResultViewModel?            ViewModel                               { get; set; }

        public static ChallengeTourResultPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourResultPresenter();

            value.Argument                                  = GetObject<ChallengeTourResultArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChallengeTourResultArgument.FromPointer); // 0270D64B0C60 0x10 Argument                    ( 000186579EE0 ModelClassType ChallengeTourResultArgument ChallengeTourResultArgument ChallengeTourResultArgument Pointer )
            value.View                                      = GetObject<IChallengeTourResultView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChallengeTourResultView.FromPointer); // 0270D64B0C80 0x18 View                        ( 000186724E40 ModelClassType IChallengeTourResultView IChallengeTourResultView IChallengeTourResultView Pointer )
            value.OverlayManager                            = GetObject<OverlayManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.OverlayManager.FromPointer); // 0270D64B0CA0 0x20 OverlayManager              ( 0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D64B0CC0 0x28 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D64B0CE0 0x30 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourResultViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ChallengeTourResultViewModel.FromPointer); // 0270D64B0D00 0x38 ViewModel                   ( 00018657D540 ModelClassType ChallengeTourResultViewModel ChallengeTourResultViewModel ChallengeTourResultViewModel Pointer )

            return value;
        }
    }
}

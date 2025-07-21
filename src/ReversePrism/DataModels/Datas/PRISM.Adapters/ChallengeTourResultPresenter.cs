using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Argument                                 ModelClassType ChallengeTourResultArgument ChallengeTourResultArgument ChallengeTourResultArgument Pointer
    // 018 View                                     ModelClassType IChallengeTourResultView IChallengeTourResultView IChallengeTourResultView Pointer
    // 020 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 ViewModel                                ModelClassType ChallengeTourResultViewModel ChallengeTourResultViewModel ChallengeTourResultViewModel Pointer
    public partial class ChallengeTourResultPresenter : DataModel
    {
        public ChallengeTourResultArgument?             Argument                                { get; set; }
        public IChallengeTourResultView?                View                                    { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ChallengeTourResultViewModel?            ViewModel                               { get; set; }

        public static ChallengeTourResultPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourResultPresenter() { Pointer= p0 };

            value.Argument                                  = GetObject<ChallengeTourResultArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChallengeTourResultArgument.FromPointer); // 0x10 Argument                    ( ModelClassType ChallengeTourResultArgument ChallengeTourResultArgument ChallengeTourResultArgument Pointer )
            value.View                                      = GetObject<IChallengeTourResultView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChallengeTourResultView.FromPointer); // 0x18 View                        ( ModelClassType IChallengeTourResultView IChallengeTourResultView IChallengeTourResultView Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x28 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourResultViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourResultViewModel.FromPointer); // 0x30 ViewModel                   ( ModelClassType ChallengeTourResultViewModel ChallengeTourResultViewModel ChallengeTourResultViewModel Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IChallengeTourUnitEditView IChallengeTourUnitEditView IChallengeTourUnitEditView Pointer
    // 018 Argument                                 ModelClassType ChallengeTourUnitEditArgument ChallengeTourUnitEditArgument ChallengeTourUnitEditArgument Pointer
    // 020 ViewModel                                ModelClassType ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel Pointer
    // 028 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ChallengeTourUnitEditPresenter : DataModel
    {
        public IChallengeTourUnitEditView?              View                                    { get; set; }
        public ChallengeTourUnitEditArgument?           Argument                                { get; set; }
        public ChallengeTourUnitEditViewModel?          ViewModel                               { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static ChallengeTourUnitEditPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitEditPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IChallengeTourUnitEditView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourUnitEditView.FromPointer); // 0x10 View                        ( ModelClassType IChallengeTourUnitEditView IChallengeTourUnitEditView IChallengeTourUnitEditView Pointer )
            value.Argument                                  = GetObject<ChallengeTourUnitEditArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourUnitEditArgument.FromPointer); // 0x18 Argument                    ( ModelClassType ChallengeTourUnitEditArgument ChallengeTourUnitEditArgument ChallengeTourUnitEditArgument Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourUnitEditViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourUnitEditViewModel.FromPointer); // 0x20 ViewModel                   ( ModelClassType ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}

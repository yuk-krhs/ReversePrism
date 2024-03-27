using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186728B50 ModelClassType IChallengeTourUnitEditView IChallengeTourUnitEditView IChallengeTourUnitEditView Pointer
    // 018 Argument                                 000186588FE0 ModelClassType ChallengeTourUnitEditArgument ChallengeTourUnitEditArgument ChallengeTourUnitEditArgument Pointer
    // 020 ViewModel                                00018658B6C0 ModelClassType ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel Pointer
    // 028 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 FuFavoriteDisposable                     0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ChallengeTourUnitEditPresenter
    {
        public IChallengeTourUnitEditView?              View                                    { get; set; }
        public ChallengeTourUnitEditArgument?           Argument                                { get; set; }
        public ChallengeTourUnitEditViewModel?          ViewModel                               { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public IDisposable?                             FuFavoriteDisposable                    { get; set; }

        public static ChallengeTourUnitEditPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourUnitEditPresenter();

            value.View                                      = GetObject<IChallengeTourUnitEditView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourUnitEditView.FromPointer); // 0270D64BA7C8 0x10 View                        ( 000186728B50 ModelClassType IChallengeTourUnitEditView IChallengeTourUnitEditView IChallengeTourUnitEditView Pointer )
            value.Argument                                  = GetObject<ChallengeTourUnitEditArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourUnitEditArgument.FromPointer); // 0270D64BA7E8 0x18 Argument                    ( 000186588FE0 ModelClassType ChallengeTourUnitEditArgument ChallengeTourUnitEditArgument ChallengeTourUnitEditArgument Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourUnitEditViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourUnitEditViewModel.FromPointer); // 0270D64BA808 0x20 ViewModel                   ( 00018658B6C0 ModelClassType ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel ChallengeTourUnitEditViewModel Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D64BA828 0x28 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D64BA848 0x30 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.FuFavoriteDisposable                      = GetObject<IDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D64BA868 0x38 FuFavoriteDisposable        ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}

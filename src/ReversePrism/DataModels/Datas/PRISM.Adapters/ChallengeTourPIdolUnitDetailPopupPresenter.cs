using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186724220 ModelClassType IChallengeTourPIdolUnitDetailPopupView IChallengeTourPIdolUnitDetailPopupView IChallengeTourPIdolUnitDetailPopupView Pointer
    // 018 ViewModel                                00018658DE50 ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer
    // 020 UnitIndex                                0001865F4260 ModelPrimitiveType int int int Int32
    // 028 OverlayManager                           0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer
    // 030 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class ChallengeTourPIdolUnitDetailPopupPresenter
    {
        public IChallengeTourPIdolUnitDetailPopupView?  View                                    { get; set; }
        public ChallengeTourUnitViewModel?              ViewModel                               { get; set; }
        public int                                      UnitIndex                               { get; set; }
        public OverlayManager?                          OverlayManager                          { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }

        public static ChallengeTourPIdolUnitDetailPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolUnitDetailPopupPresenter();

            value.View                                      = GetObject<IChallengeTourPIdolUnitDetailPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourPIdolUnitDetailPopupView.FromPointer); // 0270D64A1728 0x10 View                        ( 000186724220 ModelClassType IChallengeTourPIdolUnitDetailPopupView IChallengeTourPIdolUnitDetailPopupView IChallengeTourPIdolUnitDetailPopupView Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourUnitViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourUnitViewModel.FromPointer); // 0270D64A1748 0x18 ViewModel                   ( 00018658DE50 ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer )
            value.UnitIndex                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D64A1768 0x20 UnitIndex                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.OverlayManager                            = GetObject<OverlayManager>(new IntPtr(p + 0x028), ReversePrism.DataModels.OverlayManager.FromPointer); // 0270D64A1788 0x28 OverlayManager              ( 0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D64A17A8 0x30 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D64A17C8 0x38 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}

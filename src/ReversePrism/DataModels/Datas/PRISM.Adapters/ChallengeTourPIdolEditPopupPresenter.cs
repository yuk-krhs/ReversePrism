using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186723860 ModelClassType IChallengeTourPIdolEditPopupView IChallengeTourPIdolEditPopupView IChallengeTourPIdolEditPopupView Pointer
    // 018 OverlayManager                           0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer
    // 020 PIdolUnitViewModels                      000185B74420 ModelClassListType ChallengeTourPIdolUnitViewModel[] ChallengeTourPIdolUnitViewModel[] List<ChallengeTourPIdolUnitViewModel> Pointer
    // 028 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 ChallengeTourId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C UnitIndex                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 StageIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ChallengeTourPIdolEditPopupPresenter
    {
        public IChallengeTourPIdolEditPopupView?        View                                    { get; set; }
        public OverlayManager?                          OverlayManager                          { get; set; }
        public List<ChallengeTourPIdolUnitViewModel>?   PIdolUnitViewModels                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public int                                      ChallengeTourId                         { get; set; }
        public int                                      UnitIndex                               { get; set; }
        public int                                      StageIndex                              { get; set; }

        public static ChallengeTourPIdolEditPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolEditPopupPresenter();

            value.View                                      = GetObject<IChallengeTourPIdolEditPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourPIdolEditPopupView.FromPointer); // 0270D6499A68 0x10 View                        ( 000186723860 ModelClassType IChallengeTourPIdolEditPopupView IChallengeTourPIdolEditPopupView IChallengeTourPIdolEditPopupView Pointer )
            value.OverlayManager                            = GetObject<OverlayManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.OverlayManager.FromPointer); // 0270D6499A88 0x18 OverlayManager              ( 0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer )
            value.PIdolUnitViewModels                       = GetObjectList<ChallengeTourPIdolUnitViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourPIdolUnitViewModel.FromPointer); // 0270D6499AA8 0x20 PIdolUnitViewModels         ( 000185B74420 ModelClassListType ChallengeTourPIdolUnitViewModel[] ChallengeTourPIdolUnitViewModel[] List<ChallengeTourPIdolUnitViewModel> Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D6499AC8 0x28 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D6499AE8 0x30 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ChallengeTourId                           = GetInt32(new IntPtr(p + 0x038)); // 0270D6499B08 0x38 ChallengeTourId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitIndex                                 = GetInt32(new IntPtr(p + 0x03C)); // 0270D6499B28 0x3C UnitIndex                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StageIndex                                = GetInt32(new IntPtr(p + 0x040)); // 0270D6499B48 0x40 StageIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

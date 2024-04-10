using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186726700 ModelClassType IChallengeTourStageFilterPopupView IChallengeTourStageFilterPopupView IChallengeTourStageFilterPopupView Pointer
    // 018 OverlayManager                           0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer
    // 020 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 IsFilters                                000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 038 onUpdateFilter                           Action`1<bool[]> IL2CPP_TYPE_GENERICINST
    public partial class ChallengeTourStageFilterPopupPresenter : DataModel
    {
        public IChallengeTourStageFilterPopupView?      View                                    { get; set; }
        public OverlayManager?                          OverlayManager                          { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public List<bool>?                              IsFilters                               { get; set; }

        public static ChallengeTourStageFilterPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageFilterPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IChallengeTourStageFilterPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourStageFilterPopupView.FromPointer); // 024666511040 0x10 View                        ( 000186726700 ModelClassType IChallengeTourStageFilterPopupView IChallengeTourStageFilterPopupView IChallengeTourStageFilterPopupView Pointer )
            value.OverlayManager                            = GetObject<OverlayManager>(new IntPtr(p + 0x018), ReversePrism.DataModels.OverlayManager.FromPointer); // 024666511060 0x18 OverlayManager              ( 0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 024666511080 0x20 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246665110A0 0x28 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IsFilters                                 = GetBoolList(new IntPtr(p + 0x030)); // 0246665110C0 0x30 IsFilters                   ( 000185B78CA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}

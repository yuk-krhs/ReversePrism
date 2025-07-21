using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IChallengeTourStageDetailOverlayView IChallengeTourStageDetailOverlayView IChallengeTourStageDetailOverlayView Pointer
    // 018 ViewModel                                ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer
    // 020 selectSaveData                           SavableJsonObject`1<ChallengeTourSelectUnitStageSaveData> IL2CPP_TYPE_GENERICINST
    // 028 OverlayManager                           ModelClassType OverlayManager OverlayManager OverlayManager Pointer
    // 030 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 040 onChangeStage                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 StageIndex                               ModelPrimitiveType int int int Int32
    // 04C UnitIndex                                ModelPrimitiveType int int int Int32
    // 050 IsAnimation                              ModelPrimitiveType bool bool bool Bool
    public partial class ChallengeTourStageDetailOverlayPresenter : DataModel
    {
        public IChallengeTourStageDetailOverlayView?    View                                    { get; set; }
        public ChallengeTourUnitViewModel?              ViewModel                               { get; set; }
        public OverlayManager?                          OverlayManager                          { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public int                                      StageIndex                              { get; set; }
        public int                                      UnitIndex                               { get; set; }
        public bool                                     IsAnimation                             { get; set; }

        public static ChallengeTourStageDetailOverlayPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourStageDetailOverlayPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IChallengeTourStageDetailOverlayView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourStageDetailOverlayView.FromPointer); // 0x10 View                        ( ModelClassType IChallengeTourStageDetailOverlayView IChallengeTourStageDetailOverlayView IChallengeTourStageDetailOverlayView Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourUnitViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourUnitViewModel.FromPointer); // 0x18 ViewModel                   ( ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer )
            value.OverlayManager                            = GetObject<OverlayManager>(new IntPtr(p + 0x028), ReversePrism.DataModels.OverlayManager.FromPointer); // 0x28 OverlayManager              ( ModelClassType OverlayManager OverlayManager OverlayManager Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x38 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.StageIndex                                = GetInt32(new IntPtr(p + 0x048)); // 0x48 StageIndex                  ( ModelPrimitiveType int int int Int32 )
            value.UnitIndex                                 = GetInt32(new IntPtr(p + 0x04C)); // 0x4C UnitIndex                   ( ModelPrimitiveType int int int Int32 )
            value.IsAnimation                               = GetBool(new IntPtr(p + 0x050)); // 0x50 IsAnimation                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

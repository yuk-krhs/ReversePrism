using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186725FD0 ModelClassType IChallengeTourStageDetailOverlayView IChallengeTourStageDetailOverlayView IChallengeTourStageDetailOverlayView Pointer
    // 018 ViewModel                                00018658DE50 ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer
    // 020 selectSaveData                           SavableJsonObject`1<ChallengeTourSelectUnitStageSaveData> IL2CPP_TYPE_GENERICINST
    // 028 OverlayManager                           0001866FE7B0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer
    // 030 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 040 onChangeStage                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 048 StageIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C UnitIndex                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 IsAnimation                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ChallengeTourStageDetailOverlayPresenter
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
            var value   = new ChallengeTourStageDetailOverlayPresenter();

            value.View                                      = GetObject<IChallengeTourStageDetailOverlayView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourStageDetailOverlayView.FromPointer); // 0270D648AAC0 0x10 View                        ( 000186725FD0 ModelClassType IChallengeTourStageDetailOverlayView IChallengeTourStageDetailOverlayView IChallengeTourStageDetailOverlayView Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourUnitViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourUnitViewModel.FromPointer); // 0270D648AAE0 0x18 ViewModel                   ( 00018658DE50 ModelClassType ChallengeTourUnitViewModel ChallengeTourUnitViewModel ChallengeTourUnitViewModel Pointer )
            value.OverlayManager                            = GetObject<OverlayManager>(new IntPtr(p + 0x028), ReversePrism.DataModels.OverlayManager.FromPointer); // 0270D648AB20 0x28 OverlayManager              ( 0001866FE7B0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D648AB40 0x30 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D648AB60 0x38 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.StageIndex                                = GetInt32(new IntPtr(p + 0x048)); // 0270D648ABA0 0x48 StageIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitIndex                                 = GetInt32(new IntPtr(p + 0x04C)); // 0270D648ABC0 0x4C UnitIndex                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsAnimation                               = GetBool(new IntPtr(p + 0x050)); // 0270D648ABE0 0x50 IsAnimation                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Argument                                 ModelClassType ChallengeTourTopArgument ChallengeTourTopArgument ChallengeTourTopArgument Pointer
    // 018 View                                     ModelClassType IChallengeTourTopView IChallengeTourTopView IChallengeTourTopView Pointer
    // 020 ViewModel                                ModelClassType ChallengeTourTopViewModel ChallengeTourTopViewModel ChallengeTourTopViewModel Pointer
    // 028 permanentData                            SavableJsonObject`1<ChallengeTourStageFilterPermanentData> IL2CPP_TYPE_GENERICINST
    // 030 selectSaveData                           SavableJsonObject`1<ChallengeTourSelectUnitStageSaveData> IL2CPP_TYPE_GENERICINST
    // 038 MessagePopupSequencer                    ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer
    // 040 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 050 ChangeStageDisposable                    ModelClassType IDisposable IDisposable IDisposable Pointer
    // 058 UnitIndex                                ModelPrimitiveType int int int Int32
    // 05C StageIndex                               ModelPrimitiveType int int int Int32
    public partial class ChallengeTourTopPresenter : DataModel
    {
        public ChallengeTourTopArgument?                Argument                                { get; set; }
        public IChallengeTourTopView?                   View                                    { get; set; }
        public ChallengeTourTopViewModel?               ViewModel                               { get; set; }
        public ICommonSequencerContainer?               MessagePopupSequencer                   { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public IDisposable?                             ChangeStageDisposable                   { get; set; }
        public int                                      UnitIndex                               { get; set; }
        public int                                      StageIndex                              { get; set; }

        public static ChallengeTourTopPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourTopPresenter() { Pointer= p0 };

            value.Argument                                  = GetObject<ChallengeTourTopArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChallengeTourTopArgument.FromPointer); // 0x10 Argument                    ( ModelClassType ChallengeTourTopArgument ChallengeTourTopArgument ChallengeTourTopArgument Pointer )
            value.View                                      = GetObject<IChallengeTourTopView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IChallengeTourTopView.FromPointer); // 0x18 View                        ( ModelClassType IChallengeTourTopView IChallengeTourTopView IChallengeTourTopView Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourTopViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ChallengeTourTopViewModel.FromPointer); // 0x20 ViewModel                   ( ModelClassType ChallengeTourTopViewModel ChallengeTourTopViewModel ChallengeTourTopViewModel Pointer )
            value.MessagePopupSequencer                     = GetObject<ICommonSequencerContainer>(new IntPtr(p + 0x038), ReversePrism.DataModels.ICommonSequencerContainer.FromPointer); // 0x38 MessagePopupSequencer       ( ModelClassType ICommonSequencerContainer ICommonSequencerContainer ICommonSequencerContainer Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x40 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x48 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ChangeStageDisposable                     = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0x50 ChangeStageDisposable       ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.UnitIndex                                 = GetInt32(new IntPtr(p + 0x058)); // 0x58 UnitIndex                   ( ModelPrimitiveType int int int Int32 )
            value.StageIndex                                = GetInt32(new IntPtr(p + 0x05C)); // 0x5C StageIndex                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 FadeTime                                 float IL2CPP_TYPE_R4
    // 000 RetryFadeOutTime                         float IL2CPP_TYPE_R4
    // 010 ProduceBaseView                          ModelClassType ProduceBaseView ProduceBaseView ProduceBaseView Pointer
    // 018 ProduceBaseModel                         ModelClassType ProduceBaseModel ProduceBaseModel ProduceBaseModel Pointer
    // 020 ViewModel                                ModelClassType ProduceIngameViewModel ProduceIngameViewModel ProduceIngameViewModel Pointer
    // 028 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 030 onPlayBGMSubject                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onEndCountDownSubject                    Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onTapCardSubject                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onInGameEndSubject                       Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 050 SuccessJinglePlayback                    ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 058 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 060 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 068 ShowEnemyPCardState                      ModelClassType ShowEnemyPCardState ShowEnemyPCardState ShowEnemyPCardState Pointer
    // 070 IsStopTapIngameContent                   ModelPrimitiveType bool bool bool Bool
    // 078 <OnConfirmInGameFinishAsync>k__BackingField Func`2<CancellationToken, UniTask`1<bool>> IL2CPP_TYPE_GENERICINST
    public partial class BasePresenter : DataModel
    {
        public ProduceBaseView?                         ProduceBaseView                         { get; set; }
        public ProduceBaseModel?                        ProduceBaseModel                        { get; set; }
        public ProduceIngameViewModel?                  ViewModel                               { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public CriAtomExPlayback                        SuccessJinglePlayback                   { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ShowEnemyPCardState?                     ShowEnemyPCardState                     { get; set; }
        public bool                                     IsStopTapIngameContent                  { get; set; }

        public static BasePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BasePresenter() { Pointer= p0 };

            value.ProduceBaseView                           = GetObject<ProduceBaseView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceBaseView.FromPointer); // 0x10 ProduceBaseView             ( ModelClassType ProduceBaseView ProduceBaseView ProduceBaseView Pointer )
            value.ProduceBaseModel                          = GetObject<ProduceBaseModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseModel.FromPointer); // 0x18 ProduceBaseModel            ( ModelClassType ProduceBaseModel ProduceBaseModel ProduceBaseModel Pointer )
            value.ViewModel                                 = GetObject<ProduceIngameViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceIngameViewModel.FromPointer); // 0x20 ViewModel                   ( ModelClassType ProduceIngameViewModel ProduceIngameViewModel ProduceIngameViewModel Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x028)); // 0x28 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.SuccessJinglePlayback                     = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x050)); // 0x50 SuccessJinglePlayback       ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x058), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x58 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x60 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ShowEnemyPCardState                       = GetObject<ShowEnemyPCardState>(new IntPtr(p + 0x068), ReversePrism.DataModels.ShowEnemyPCardState.FromPointer); // 0x68 ShowEnemyPCardState         ( ModelClassType ShowEnemyPCardState ShowEnemyPCardState ShowEnemyPCardState Pointer )
            value.IsStopTapIngameContent                    = GetBool(new IntPtr(p + 0x070)); // 0x70 IsStopTapIngameContent      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

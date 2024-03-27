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
    // 010 ProduceBaseView                          000186534730 ModelClassType ProduceBaseView ProduceBaseView ProduceBaseView Pointer
    // 018 ProduceBaseModel                         000186533F60 ModelClassType ProduceBaseModel ProduceBaseModel ProduceBaseModel Pointer
    // 020 ViewModel                                00018655BC00 ModelClassType ProduceIngameViewModel ProduceIngameViewModel ProduceIngameViewModel Pointer
    // 028 IsInitialized                            000186595480 ModelPrimitiveType bool bool bool Bool
    // 030 onPlayBGMSubject                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 onEndCountDownSubject                    Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onTapCardSubject                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onInGameEndSubject                       Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 050 SuccessJinglePlayback                    0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 054 DifficultyType                           00018660BEF0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 058 TokenSource                              0001865A3BB0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 060 Disposables                              0001865F3410 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 068 <OnConfirmInGameFinishAsync>k__BackingField Func`2<CancellationToken, UniTask`1<bool>> IL2CPP_TYPE_GENERICINST
    public partial class BasePresenter
    {
        public ProduceBaseView?                         ProduceBaseView                         { get; set; }
        public ProduceBaseModel?                        ProduceBaseModel                        { get; set; }
        public ProduceIngameViewModel?                  ViewModel                               { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public CriAtomExPlayback                        SuccessJinglePlayback                   { get; set; }
        public ProduceDifficultyType                    DifficultyType                          { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static BasePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BasePresenter();

            value.ProduceBaseView                           = GetObject<ProduceBaseView>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceBaseView.FromPointer); // 0270D5078AD0 0x10 ProduceBaseView             ( 000186534730 ModelClassType ProduceBaseView ProduceBaseView ProduceBaseView Pointer )
            value.ProduceBaseModel                          = GetObject<ProduceBaseModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceBaseModel.FromPointer); // 0270D5078AF0 0x18 ProduceBaseModel            ( 000186533F60 ModelClassType ProduceBaseModel ProduceBaseModel ProduceBaseModel Pointer )
            value.ViewModel                                 = GetObject<ProduceIngameViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceIngameViewModel.FromPointer); // 0270D5078B10 0x20 ViewModel                   ( 00018655BC00 ModelClassType ProduceIngameViewModel ProduceIngameViewModel ProduceIngameViewModel Pointer )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x028)); // 0270D5078B30 0x28 IsInitialized               ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.SuccessJinglePlayback                     = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x050)); // 0270D5078BD0 0x50 SuccessJinglePlayback       ( 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.DifficultyType                            = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x054)); // 0270D5078BF0 0x54 DifficultyType              ( 00018660BEF0 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x058), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D5078C10 0x58 TokenSource                 ( 0001865A3BB0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x060), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D5078C30 0x60 Disposables                 ( 0001865F3410 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}

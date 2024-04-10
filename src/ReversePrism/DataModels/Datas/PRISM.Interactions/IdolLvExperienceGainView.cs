using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolView                                 0001865706D0 ModelClassType LiveResultIdolView LiveResultIdolView LiveResultIdolView Pointer
    // 028 BaseViewAnimator                         0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 030 IdolViewAnimator                         0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 038 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 SkipAnimationButton                      0001865140C0 ModelClassType Button Button Button Pointer
    // 048 BtnNext                                  000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 Cts                                      0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 058 Reward                                   0001865718A0 ModelClassType IIdolBaseRewardStatus IIdolBaseRewardStatus IIdolBaseRewardStatus Pointer
    // 060 LiveResultIdolViewModel                  000186570D10 ModelClassType LiveResultIdolViewModel LiveResultIdolViewModel LiveResultIdolViewModel Pointer
    // 068 IsSkip                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class IdolLvExperienceGainView : DataModel
    {
        public LiveResultIdolView?                      IdolView                                { get; set; }
        public Animator?                                BaseViewAnimator                        { get; set; }
        public Animator?                                IdolViewAnimator                        { get; set; }
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public Button?                                  SkipAnimationButton                     { get; set; }
        public ButtonBase?                              BtnNext                                 { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public IIdolBaseRewardStatus?                   Reward                                  { get; set; }
        public LiveResultIdolViewModel?                 LiveResultIdolViewModel                 { get; set; }
        public bool                                     IsSkip                                  { get; set; }

        public static IdolLvExperienceGainView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolLvExperienceGainView() { Pointer= p0 };

            value.IdolView                                  = GetObject<LiveResultIdolView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveResultIdolView.FromPointer); // 02466A3B8040 0x20 IdolView                    ( 0001865706D0 ModelClassType LiveResultIdolView LiveResultIdolView LiveResultIdolView Pointer )
            value.BaseViewAnimator                          = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 02466A3B8060 0x28 BaseViewAnimator            ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.IdolViewAnimator                          = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 02466A3B8080 0x30 IdolViewAnimator            ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3B80A0 0x38 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.SkipAnimationButton                       = GetObject<Button>(new IntPtr(p + 0x040), ReversePrism.DataModels.Button.FromPointer); // 02466A3B80C0 0x40 SkipAnimationButton         ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.BtnNext                                   = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466A3B80E0 0x48 BtnNext                     ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x050), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466A3B8100 0x50 Cts                         ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Reward                                    = GetObject<IIdolBaseRewardStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IIdolBaseRewardStatus.FromPointer); // 02466A3B8120 0x58 Reward                      ( 0001865718A0 ModelClassType IIdolBaseRewardStatus IIdolBaseRewardStatus IIdolBaseRewardStatus Pointer )
            value.LiveResultIdolViewModel                   = GetObject<LiveResultIdolViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveResultIdolViewModel.FromPointer); // 02466A3B8140 0x60 LiveResultIdolViewModel     ( 000186570D10 ModelClassType LiveResultIdolViewModel LiveResultIdolViewModel LiveResultIdolViewModel Pointer )
            value.IsSkip                                    = GetBool(new IntPtr(p + 0x068)); // 02466A3B8160 0x68 IsSkip                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolView                                 ModelClassType LiveResultIdolView LiveResultIdolView LiveResultIdolView Pointer
    // 028 BaseViewAnimator                         ModelClassType Animator Animator Animator Pointer
    // 030 IdolViewAnimator                         ModelClassType Animator Animator Animator Pointer
    // 038 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 SkipAnimationButton                      ModelClassType Button Button Button Pointer
    // 048 BtnNext                                  ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 058 Reward                                   ModelClassType IIdolBaseRewardStatus IIdolBaseRewardStatus IIdolBaseRewardStatus Pointer
    // 060 LiveResultIdolViewModel                  ModelClassType LiveResultIdolViewModel LiveResultIdolViewModel LiveResultIdolViewModel Pointer
    // 068 IsSkip                                   ModelPrimitiveType bool bool bool Bool
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

            value.IdolView                                  = GetObject<LiveResultIdolView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveResultIdolView.FromPointer); // 0x20 IdolView                    ( ModelClassType LiveResultIdolView LiveResultIdolView LiveResultIdolView Pointer )
            value.BaseViewAnimator                          = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0x28 BaseViewAnimator            ( ModelClassType Animator Animator Animator Pointer )
            value.IdolViewAnimator                          = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0x30 IdolViewAnimator            ( ModelClassType Animator Animator Animator Pointer )
            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.SkipAnimationButton                       = GetObject<Button>(new IntPtr(p + 0x040), ReversePrism.DataModels.Button.FromPointer); // 0x40 SkipAnimationButton         ( ModelClassType Button Button Button Pointer )
            value.BtnNext                                   = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x48 BtnNext                     ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x050), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x50 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Reward                                    = GetObject<IIdolBaseRewardStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IIdolBaseRewardStatus.FromPointer); // 0x58 Reward                      ( ModelClassType IIdolBaseRewardStatus IIdolBaseRewardStatus IIdolBaseRewardStatus Pointer )
            value.LiveResultIdolViewModel                   = GetObject<LiveResultIdolViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveResultIdolViewModel.FromPointer); // 0x60 LiveResultIdolViewModel     ( ModelClassType LiveResultIdolViewModel LiveResultIdolViewModel LiveResultIdolViewModel Pointer )
            value.IsSkip                                    = GetBool(new IntPtr(p + 0x068)); // 0x68 IsSkip                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

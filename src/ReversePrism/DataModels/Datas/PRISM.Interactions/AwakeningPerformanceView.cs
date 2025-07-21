using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 028 TrCharaImageParent                       ModelClassType Transform Transform Transform Pointer
    // 030 PerformanceAnimator                      ModelClassType Animator Animator Animator Pointer
    // 038 ColorBg                                  ModelClassType UIImage UIImage UIImage Pointer
    // 040 TxtBeforeLv                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtAfterLv                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 IdolLvExperienceGainView                 ModelClassType IdolLvExperienceGainView IdolLvExperienceGainView IdolLvExperienceGainView Pointer
    // 058 Vm                                       ModelClassType AwakeningPerformanceViewModel AwakeningPerformanceViewModel AwakeningPerformanceViewModel Pointer
    // 060 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 070 AdditionalLoadedCueSheets                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 078 VoiceMotion                              ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer
    public partial class AwakeningPerformanceView : DataModel
    {
        public UIButton?                                Btn                                     { get; set; }
        public Transform?                               TrCharaImageParent                      { get; set; }
        public Animator?                                PerformanceAnimator                     { get; set; }
        public UIImage?                                 ColorBg                                 { get; set; }
        public UITextMeshProUGUI?                       TxtBeforeLv                             { get; set; }
        public UITextMeshProUGUI?                       TxtAfterLv                              { get; set; }
        public IdolLvExperienceGainView?                IdolLvExperienceGainView                { get; set; }
        public AwakeningPerformanceViewModel?           Vm                                      { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public List<string>?                            AdditionalLoadedCueSheets               { get; set; }
        public MstOutgameVoiceMotion?                   VoiceMotion                             { get; set; }

        public static AwakeningPerformanceView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AwakeningPerformanceView() { Pointer= p0 };

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.TrCharaImageParent                        = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 TrCharaImageParent          ( ModelClassType Transform Transform Transform Pointer )
            value.PerformanceAnimator                       = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0x30 PerformanceAnimator         ( ModelClassType Animator Animator Animator Pointer )
            value.ColorBg                                   = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0x38 ColorBg                     ( ModelClassType UIImage UIImage UIImage Pointer )
            value.TxtBeforeLv                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtBeforeLv                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 TxtAfterLv                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolLvExperienceGainView                  = GetObject<IdolLvExperienceGainView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolLvExperienceGainView.FromPointer); // 0x50 IdolLvExperienceGainView    ( ModelClassType IdolLvExperienceGainView IdolLvExperienceGainView IdolLvExperienceGainView Pointer )
            value.Vm                                        = GetObject<AwakeningPerformanceViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.AwakeningPerformanceViewModel.FromPointer); // 0x58 Vm                          ( ModelClassType AwakeningPerformanceViewModel AwakeningPerformanceViewModel AwakeningPerformanceViewModel Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x068)); // 0x68 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.AdditionalLoadedCueSheets                 = GetStringList(new IntPtr(p + 0x070)); // 0x70 AdditionalLoadedCueSheets   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.VoiceMotion                               = GetObject<MstOutgameVoiceMotion>(new IntPtr(p + 0x078), ReversePrism.DataModels.MstOutgameVoiceMotion.FromPointer); // 0x78 VoiceMotion                 ( ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 TrCharaImageParent                       0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 PerformanceAnimator                      0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 038 ColorBg                                  0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 040 TxtBeforeLv                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 TxtAfterLv                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 IdolLvExperienceGainView                 0001866B56F0 ModelClassType IdolLvExperienceGainView IdolLvExperienceGainView IdolLvExperienceGainView Pointer
    // 058 Vm                                       00018672ED70 ModelClassType AwakeningPerformanceViewModel AwakeningPerformanceViewModel AwakeningPerformanceViewModel Pointer
    // 060 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 070 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 078 AdditionalLoadedCueSheets                000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 080 VoiceMotion                              0001866264F0 ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer
    public partial class AwakeningPerformanceView
    {
        public UIButton?                                Btn                                     { get; set; }
        public Transform?                               TrCharaImageParent                      { get; set; }
        public Animator?                                PerformanceAnimator                     { get; set; }
        public UIImage?                                 ColorBg                                 { get; set; }
        public UITextMeshProUGUI?                       TxtBeforeLv                             { get; set; }
        public UITextMeshProUGUI?                       TxtAfterLv                              { get; set; }
        public IdolLvExperienceGainView?                IdolLvExperienceGainView                { get; set; }
        public AwakeningPerformanceViewModel?           Vm                                      { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public List<string>?                            AdditionalLoadedCueSheets               { get; set; }
        public MstOutgameVoiceMotion?                   VoiceMotion                             { get; set; }

        public static AwakeningPerformanceView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AwakeningPerformanceView();

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA344C98 0x20 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TrCharaImageParent                        = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DA344CB8 0x28 TrCharaImageParent          ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.PerformanceAnimator                       = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0270DA344CD8 0x30 PerformanceAnimator         ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ColorBg                                   = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 0270DA344CF8 0x38 ColorBg                     ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.TxtBeforeLv                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA344D18 0x40 TxtBeforeLv                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA344D38 0x48 TxtAfterLv                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolLvExperienceGainView                  = GetObject<IdolLvExperienceGainView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolLvExperienceGainView.FromPointer); // 0270DA344D58 0x50 IdolLvExperienceGainView    ( 0001866B56F0 ModelClassType IdolLvExperienceGainView IdolLvExperienceGainView IdolLvExperienceGainView Pointer )
            value.Vm                                        = GetObject<AwakeningPerformanceViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.AwakeningPerformanceViewModel.FromPointer); // 0270DA344D78 0x58 Vm                          ( 00018672ED70 ModelClassType AwakeningPerformanceViewModel AwakeningPerformanceViewModel AwakeningPerformanceViewModel Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x068), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DA344DB8 0x68 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x070)); // 0270DA344DD8 0x70 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.AdditionalLoadedCueSheets                 = GetStringList(new IntPtr(p + 0x078)); // 0270DA344DF8 0x78 AdditionalLoadedCueSheets   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.VoiceMotion                               = GetObject<MstOutgameVoiceMotion>(new IntPtr(p + 0x080), ReversePrism.DataModels.MstOutgameVoiceMotion.FromPointer); // 0270DA344E18 0x80 VoiceMotion                 ( 0001866264F0 ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer )

            return value;
        }
    }
}

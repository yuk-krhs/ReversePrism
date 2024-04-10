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
    // 040 BeforeStarObjs                           000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 AfterStarObjs                            000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 IdolLvExperienceGainView                 0001866B56F0 ModelClassType IdolLvExperienceGainView IdolLvExperienceGainView IdolLvExperienceGainView Pointer
    // 058 Vm                                       000186707CB0 ModelClassType PITrainingPerformanceViewModel PITrainingPerformanceViewModel PITrainingPerformanceViewModel Pointer
    // 060 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 070 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 078 AdditionalLoadedCueSheets                000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 080 VoiceMotion                              0001866264F0 ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer
    public partial class PITrainingPerformanceView : DataModel
    {
        public UIButton?                                Btn                                     { get; set; }
        public Transform?                               TrCharaImageParent                      { get; set; }
        public Animator?                                PerformanceAnimator                     { get; set; }
        public UIImage?                                 ColorBg                                 { get; set; }
        public List<GameObject>?                        BeforeStarObjs                          { get; set; }
        public List<GameObject>?                        AfterStarObjs                           { get; set; }
        public IdolLvExperienceGainView?                IdolLvExperienceGainView                { get; set; }
        public PITrainingPerformanceViewModel?          Vm                                      { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public List<string>?                            AdditionalLoadedCueSheets               { get; set; }
        public MstOutgameVoiceMotion?                   VoiceMotion                             { get; set; }

        public static PITrainingPerformanceView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PITrainingPerformanceView() { Pointer= p0 };

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3BBDA0 0x20 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TrCharaImageParent                        = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 02466A3BBDC0 0x28 TrCharaImageParent          ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.PerformanceAnimator                       = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 02466A3BBDE0 0x30 PerformanceAnimator         ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ColorBg                                   = GetObject<UIImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIImage.FromPointer); // 02466A3BBE00 0x38 ColorBg                     ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.BeforeStarObjs                            = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3BBE20 0x40 BeforeStarObjs              ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.AfterStarObjs                             = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3BBE40 0x48 AfterStarObjs               ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.IdolLvExperienceGainView                  = GetObject<IdolLvExperienceGainView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IdolLvExperienceGainView.FromPointer); // 02466A3BBE60 0x50 IdolLvExperienceGainView    ( 0001866B56F0 ModelClassType IdolLvExperienceGainView IdolLvExperienceGainView IdolLvExperienceGainView Pointer )
            value.Vm                                        = GetObject<PITrainingPerformanceViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.PITrainingPerformanceViewModel.FromPointer); // 02466A3BBE80 0x58 Vm                          ( 000186707CB0 ModelClassType PITrainingPerformanceViewModel PITrainingPerformanceViewModel PITrainingPerformanceViewModel Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x068), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A3BBEC0 0x68 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x070)); // 02466A3BBEE0 0x70 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.AdditionalLoadedCueSheets                 = GetStringList(new IntPtr(p + 0x078)); // 02466A3BBF00 0x78 AdditionalLoadedCueSheets   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.VoiceMotion                               = GetObject<MstOutgameVoiceMotion>(new IntPtr(p + 0x080), ReversePrism.DataModels.MstOutgameVoiceMotion.FromPointer); // 02466A3BBF20 0x80 VoiceMotion                 ( 0001866264F0 ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer )

            return value;
        }
    }
}

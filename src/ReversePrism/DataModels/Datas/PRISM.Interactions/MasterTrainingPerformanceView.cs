using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 SCharaIconRectView                       0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 030 PerformanceAnimator                      0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 038 BeforeDiaObjs                            000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 AfterDiaObjs                             000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 IdolLvExperienceGainView                 0001866B56F0 ModelClassType IdolLvExperienceGainView IdolLvExperienceGainView IdolLvExperienceGainView Pointer
    // 050 Vm                                       0001865DB7B0 ModelClassType MasterTrainingPerformanceViewModel MasterTrainingPerformanceViewModel MasterTrainingPerformanceViewModel Pointer
    // 058 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 Ct                                       00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 068 AdditionalLoadedCueSheets                000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 070 VoiceMotion                              0001866264F0 ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer
    public partial class MasterTrainingPerformanceView : DataModel
    {
        public UIButton?                                Btn                                     { get; set; }
        public SCharaIconRectView?                      SCharaIconRectView                      { get; set; }
        public Animator?                                PerformanceAnimator                     { get; set; }
        public List<GameObject>?                        BeforeDiaObjs                           { get; set; }
        public List<GameObject>?                        AfterDiaObjs                            { get; set; }
        public IdolLvExperienceGainView?                IdolLvExperienceGainView                { get; set; }
        public MasterTrainingPerformanceViewModel?      Vm                                      { get; set; }
        public CancellationToken                        Ct                                      { get; set; }
        public List<string>?                            AdditionalLoadedCueSheets               { get; set; }
        public MstOutgameVoiceMotion?                   VoiceMotion                             { get; set; }

        public static MasterTrainingPerformanceView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MasterTrainingPerformanceView() { Pointer= p0 };

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3C4DC0 0x20 Btn                         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SCharaIconRectView                        = GetObject<SCharaIconRectView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 02466A3C4DE0 0x28 SCharaIconRectView          ( 0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.PerformanceAnimator                       = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 02466A3C4E00 0x30 PerformanceAnimator         ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.BeforeDiaObjs                             = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3C4E20 0x38 BeforeDiaObjs               ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.AfterDiaObjs                              = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466A3C4E40 0x40 AfterDiaObjs                ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.IdolLvExperienceGainView                  = GetObject<IdolLvExperienceGainView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolLvExperienceGainView.FromPointer); // 02466A3C4E60 0x48 IdolLvExperienceGainView    ( 0001866B56F0 ModelClassType IdolLvExperienceGainView IdolLvExperienceGainView IdolLvExperienceGainView Pointer )
            value.Vm                                        = GetObject<MasterTrainingPerformanceViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.MasterTrainingPerformanceViewModel.FromPointer); // 02466A3C4E80 0x50 Vm                          ( 0001865DB7B0 ModelClassType MasterTrainingPerformanceViewModel MasterTrainingPerformanceViewModel MasterTrainingPerformanceViewModel Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x060)); // 02466A3C4EC0 0x60 Ct                          ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.AdditionalLoadedCueSheets                 = GetStringList(new IntPtr(p + 0x068)); // 02466A3C4EE0 0x68 AdditionalLoadedCueSheets   ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.VoiceMotion                               = GetObject<MstOutgameVoiceMotion>(new IntPtr(p + 0x070), ReversePrism.DataModels.MstOutgameVoiceMotion.FromPointer); // 02466A3C4F00 0x70 VoiceMotion                 ( 0001866264F0 ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer )

            return value;
        }
    }
}

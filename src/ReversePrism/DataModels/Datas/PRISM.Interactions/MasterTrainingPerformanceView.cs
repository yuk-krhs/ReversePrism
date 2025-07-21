using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Btn                                      ModelClassType UIButton UIButton UIButton Pointer
    // 028 SCharaIconRectView                       ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 030 PerformanceAnimator                      ModelClassType Animator Animator Animator Pointer
    // 038 BeforeDiaObjs                            ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 AfterDiaObjs                             ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 IdolLvExperienceGainView                 ModelClassType IdolLvExperienceGainView IdolLvExperienceGainView IdolLvExperienceGainView Pointer
    // 050 Vm                                       ModelClassType MasterTrainingPerformanceViewModel MasterTrainingPerformanceViewModel MasterTrainingPerformanceViewModel Pointer
    // 058 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 Ct                                       ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 068 AdditionalLoadedCueSheets                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 070 VoiceMotion                              ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer
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

            value.Btn                                       = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Btn                         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SCharaIconRectView                        = GetObject<SCharaIconRectView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x28 SCharaIconRectView          ( ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.PerformanceAnimator                       = GetObject<Animator>(new IntPtr(p + 0x030), ReversePrism.DataModels.Animator.FromPointer); // 0x30 PerformanceAnimator         ( ModelClassType Animator Animator Animator Pointer )
            value.BeforeDiaObjs                             = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 BeforeDiaObjs               ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.AfterDiaObjs                              = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 AfterDiaObjs                ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.IdolLvExperienceGainView                  = GetObject<IdolLvExperienceGainView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolLvExperienceGainView.FromPointer); // 0x48 IdolLvExperienceGainView    ( ModelClassType IdolLvExperienceGainView IdolLvExperienceGainView IdolLvExperienceGainView Pointer )
            value.Vm                                        = GetObject<MasterTrainingPerformanceViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.MasterTrainingPerformanceViewModel.FromPointer); // 0x50 Vm                          ( ModelClassType MasterTrainingPerformanceViewModel MasterTrainingPerformanceViewModel MasterTrainingPerformanceViewModel Pointer )
            value.Ct                                        = (CancellationToken)GetInt32(new IntPtr(p + 0x060)); // 0x60 Ct                          ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.AdditionalLoadedCueSheets                 = GetStringList(new IntPtr(p + 0x068)); // 0x68 AdditionalLoadedCueSheets   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.VoiceMotion                               = GetObject<MstOutgameVoiceMotion>(new IntPtr(p + 0x070), ReversePrism.DataModels.MstOutgameVoiceMotion.FromPointer); // 0x70 VoiceMotion                 ( ModelClassType MstOutgameVoiceMotion MstOutgameVoiceMotion MstOutgameVoiceMotion Pointer )

            return value;
        }
    }
}

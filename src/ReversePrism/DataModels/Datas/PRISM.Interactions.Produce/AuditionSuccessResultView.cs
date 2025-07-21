using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 TitleText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ClearTimeCount                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RankIcon                                 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 040 RankTextImage                            ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 048 GreatEffect                              ModelClassType GameObject GameObject GameObject Pointer
    // 050 AcquireProduceFan                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 FanUpAnimatorEvent                       ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 060 WaitFanUpAnimationFrame                  ModelPrimitiveType int int int Int32
    // 068 ParameterContent                         ModelClassType ParameterContent ParameterContent ParameterContent Pointer
    // 070 AnimatorWithEvent                        ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 078 WaitParameterAnimationFrame              ModelPrimitiveType int int int Int32
    // 080 AnimationPlayer                          ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 088 NextButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 090 onClickNextButtonSubject                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 098 ScriptController                         ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer
    public partial class AuditionSuccessResultView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UITextMeshProUGUI?                       TitleText                               { get; set; }
        public UITextMeshProUGUI?                       ClearTimeCount                          { get; set; }
        public UIRawImage?                              RankIcon                                { get; set; }
        public UIRawImage?                              RankTextImage                           { get; set; }
        public GameObject?                              GreatEffect                             { get; set; }
        public UITextMeshProUGUI?                       AcquireProduceFan                       { get; set; }
        public AnimatorWithEvent?                       FanUpAnimatorEvent                      { get; set; }
        public int                                      WaitFanUpAnimationFrame                 { get; set; }
        public ParameterContent?                        ParameterContent                        { get; set; }
        public AnimatorWithEvent?                       AnimatorWithEvent                       { get; set; }
        public int                                      WaitParameterAnimationFrame             { get; set; }
        public ScreenTapSkipAnimationPlayer?            AnimationPlayer                         { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public InGameResultScriptController?            ScriptController                        { get; set; }

        public static AuditionSuccessResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionSuccessResultView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TitleText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClearTimeCount                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ClearTimeCount              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RankIcon                                  = GetObject<UIRawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x38 RankIcon                    ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.RankTextImage                             = GetObject<UIRawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x40 RankTextImage               ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.GreatEffect                               = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 GreatEffect                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AcquireProduceFan                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 AcquireProduceFan           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FanUpAnimatorEvent                        = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x058), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x58 FanUpAnimatorEvent          ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitFanUpAnimationFrame                   = GetInt32(new IntPtr(p + 0x060)); // 0x60 WaitFanUpAnimationFrame     ( ModelPrimitiveType int int int Int32 )
            value.ParameterContent                          = GetObject<ParameterContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ParameterContent.FromPointer); // 0x68 ParameterContent            ( ModelClassType ParameterContent ParameterContent ParameterContent Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x070), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x70 AnimatorWithEvent           ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitParameterAnimationFrame               = GetInt32(new IntPtr(p + 0x078)); // 0x78 WaitParameterAnimationFrame ( ModelPrimitiveType int int int Int32 )
            value.AnimationPlayer                           = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x080), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 0x80 AnimationPlayer             ( ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0x88 NextButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ScriptController                          = GetObject<InGameResultScriptController>(new IntPtr(p + 0x098), ReversePrism.DataModels.InGameResultScriptController.FromPointer); // 0x98 ScriptController            ( ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer )

            return value;
        }
    }
}

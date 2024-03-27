using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 TitleText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ClearTimeCount                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RankIcon                                 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 040 RankTextImage                            0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 048 GreatEffect                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 AcquireProduceFan                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 FanUpAnimatorEvent                       0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 060 WaitFanUpAnimationFrame                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 ParameterContent                         00018671BD80 ModelClassType ParameterContent ParameterContent ParameterContent Pointer
    // 070 AnimatorWithEvent                        0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 078 WaitParameterAnimationFrame              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 AnimationPlayer                          0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 088 NextButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 090 onClickNextButtonSubject                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 098 ScriptController                         0001866D8C40 ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer
    // 0A0 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class AuditionSuccessResultView
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
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static AuditionSuccessResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionSuccessResultView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA1D3878 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TitleText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1D3898 0x28 TitleText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ClearTimeCount                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1D38B8 0x30 ClearTimeCount              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RankIcon                                  = GetObject<UIRawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA1D38D8 0x38 RankIcon                    ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.RankTextImage                             = GetObject<UIRawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIRawImage.FromPointer); // 0270DA1D38F8 0x40 RankTextImage               ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.GreatEffect                               = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA1D3918 0x48 GreatEffect                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AcquireProduceFan                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1D3938 0x50 AcquireProduceFan           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FanUpAnimatorEvent                        = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x058), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0270DA1D3958 0x58 FanUpAnimatorEvent          ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitFanUpAnimationFrame                   = GetInt32(new IntPtr(p + 0x060)); // 0270DA1D3978 0x60 WaitFanUpAnimationFrame     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ParameterContent                          = GetObject<ParameterContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ParameterContent.FromPointer); // 0270DA1D3998 0x68 ParameterContent            ( 00018671BD80 ModelClassType ParameterContent ParameterContent ParameterContent Pointer )
            value.AnimatorWithEvent                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x070), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0270DA1D39B8 0x70 AnimatorWithEvent           ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.WaitParameterAnimationFrame               = GetInt32(new IntPtr(p + 0x078)); // 0270DA1D39D8 0x78 WaitParameterAnimationFrame ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AnimationPlayer                           = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x080), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 0270DA1D39F8 0x80 AnimationPlayer             ( 0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1D3A18 0x88 NextButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ScriptController                          = GetObject<InGameResultScriptController>(new IntPtr(p + 0x098), ReversePrism.DataModels.InGameResultScriptController.FromPointer); // 0270DA1D3A58 0x98 ScriptController            ( 0001866D8C40 ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DA1D3A78 0xA0 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}

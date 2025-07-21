using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 RewardView                               ModelClassType ProduceResultRewardView ProduceResultRewardView ProduceResultRewardView Pointer
    // 030 IdolBaseRewardContentView                ModelClassType ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView Pointer
    // 038 NextButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 040 AnimationPlayer                          ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 048 HowToPlayConfigRefKey                    ModelPrimitiveType string string string String
    // 050 onClickNextButtonSubject                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onDetermineProduceResultSubject          Subject`1<ValueTuple`2<ProduceResultFUnitDetailResult, UniTaskCompletionSource>> IL2CPP_TYPE_GENERICINST
    // 060 ScriptController                         ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer
    // 068 FesUnitRank                              ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    public partial class ProduceResultView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public ProduceResultRewardView?                 RewardView                              { get; set; }
        public ResultIdolBaseRewardContentView?         IdolBaseRewardContentView               { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public ScreenTapSkipAnimationPlayer?            AnimationPlayer                         { get; set; }
        public string                                   HowToPlayConfigRefKey                   { get; set; }
        public InGameResultScriptController?            ScriptController                        { get; set; }
        public ProduceParameterRank                     FesUnitRank                             { get; set; }

        public static ProduceResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.RewardView                                = GetObject<ProduceResultRewardView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceResultRewardView.FromPointer); // 0x28 RewardView                  ( ModelClassType ProduceResultRewardView ProduceResultRewardView ProduceResultRewardView Pointer )
            value.IdolBaseRewardContentView                 = GetObject<ResultIdolBaseRewardContentView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ResultIdolBaseRewardContentView.FromPointer); // 0x30 IdolBaseRewardContentView   ( ModelClassType ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 NextButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.AnimationPlayer                           = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 0x40 AnimationPlayer             ( ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.HowToPlayConfigRefKey                     = GetString(new IntPtr(p + 0x048)); // 0x48 HowToPlayConfigRefKey       ( ModelPrimitiveType string string string String )
            value.ScriptController                          = GetObject<InGameResultScriptController>(new IntPtr(p + 0x060), ReversePrism.DataModels.InGameResultScriptController.FromPointer); // 0x60 ScriptController            ( ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer )
            value.FesUnitRank                               = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x068)); // 0x68 FesUnitRank                 ( ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 RewardView                               ModelClassType ProduceFailureResultRewardView ProduceFailureResultRewardView ProduceFailureResultRewardView Pointer
    // 030 IdolBaseRewardContentView                ModelClassType ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView Pointer
    // 038 NextButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 040 onClickNextButtonSubject                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 AnimationPlayer                          ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 050 ScriptController                         ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer
    // 058 ScheduleDetailType                       ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    public partial class ProduceFailureResultView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public ProduceFailureResultRewardView?          RewardView                              { get; set; }
        public ResultIdolBaseRewardContentView?         IdolBaseRewardContentView               { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public ScreenTapSkipAnimationPlayer?            AnimationPlayer                         { get; set; }
        public InGameResultScriptController?            ScriptController                        { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }

        public static ProduceFailureResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFailureResultView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.RewardView                                = GetObject<ProduceFailureResultRewardView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceFailureResultRewardView.FromPointer); // 0x28 RewardView                  ( ModelClassType ProduceFailureResultRewardView ProduceFailureResultRewardView ProduceFailureResultRewardView Pointer )
            value.IdolBaseRewardContentView                 = GetObject<ResultIdolBaseRewardContentView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ResultIdolBaseRewardContentView.FromPointer); // 0x30 IdolBaseRewardContentView   ( ModelClassType ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 NextButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.AnimationPlayer                           = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 0x48 AnimationPlayer             ( ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.ScriptController                          = GetObject<InGameResultScriptController>(new IntPtr(p + 0x050), ReversePrism.DataModels.InGameResultScriptController.FromPointer); // 0x50 ScriptController            ( ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x058)); // 0x58 ScheduleDetailType          ( ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )

            return value;
        }
    }
}

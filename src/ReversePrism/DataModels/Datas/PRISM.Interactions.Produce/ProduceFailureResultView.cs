using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 RewardView                               000186540DA0 ModelClassType ProduceFailureResultRewardView ProduceFailureResultRewardView ProduceFailureResultRewardView Pointer
    // 030 IdolBaseRewardContentView                000186675B30 ModelClassType ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView Pointer
    // 038 NextButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 onClickNextButtonSubject                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 AnimationPlayer                          0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 050 ScriptController                         0001866D8C40 ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer
    // 058 ScheduleDetailType                       000186614E40 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32
    // 060 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class ProduceFailureResultView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public ProduceFailureResultRewardView?          RewardView                              { get; set; }
        public ResultIdolBaseRewardContentView?         IdolBaseRewardContentView               { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public ScreenTapSkipAnimationPlayer?            AnimationPlayer                         { get; set; }
        public InGameResultScriptController?            ScriptController                        { get; set; }
        public ScheduleDetailType                       ScheduleDetailType                      { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ProduceFailureResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFailureResultView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A242B88 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.RewardView                                = GetObject<ProduceFailureResultRewardView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceFailureResultRewardView.FromPointer); // 02466A242BA8 0x28 RewardView                  ( 000186540DA0 ModelClassType ProduceFailureResultRewardView ProduceFailureResultRewardView ProduceFailureResultRewardView Pointer )
            value.IdolBaseRewardContentView                 = GetObject<ResultIdolBaseRewardContentView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ResultIdolBaseRewardContentView.FromPointer); // 02466A242BC8 0x30 IdolBaseRewardContentView   ( 000186675B30 ModelClassType ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466A242BE8 0x38 NextButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AnimationPlayer                           = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 02466A242C28 0x48 AnimationPlayer             ( 0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.ScriptController                          = GetObject<InGameResultScriptController>(new IntPtr(p + 0x050), ReversePrism.DataModels.InGameResultScriptController.FromPointer); // 02466A242C48 0x50 ScriptController            ( 0001866D8C40 ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer )
            value.ScheduleDetailType                        = (ScheduleDetailType)GetInt32(new IntPtr(p + 0x058)); // 02466A242C68 0x58 ScheduleDetailType          ( 000186614E40 ModelEnumType ScheduleDetailType ScheduleDetailType ScheduleDetailType Int32 )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A242C88 0x60 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}

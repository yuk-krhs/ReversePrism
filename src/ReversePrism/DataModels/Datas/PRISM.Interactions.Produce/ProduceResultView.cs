using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 RewardView                               000186575FC0 ModelClassType ProduceResultRewardView ProduceResultRewardView ProduceResultRewardView Pointer
    // 030 IdolBaseRewardContentView                000186675B30 ModelClassType ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView Pointer
    // 038 NextButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 AnimationPlayer                          0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer
    // 048 HowToPlayConfigRefKey                    000186671910 ModelPrimitiveType string string string String
    // 050 TransferRewardPopupFactory               000186577F80 ModelClassType ProduceResultTransferRewardPopupViewFactory ProduceResultTransferRewardPopupViewFactory ProduceResultTransferRewardPopupViewFactory Pointer
    // 058 onClickNextButtonSubject                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onDetermineProduceResultSubject          Subject`1<ValueTuple`2<ProduceResultFUnitDetailResult, UniTaskCompletionSource>> IL2CPP_TYPE_GENERICINST
    // 068 ScriptController                         0001866D8C40 ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer
    // 070 FesUnitRank                              00018660D900 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 078 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class ProduceResultView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public ProduceResultRewardView?                 RewardView                              { get; set; }
        public ResultIdolBaseRewardContentView?         IdolBaseRewardContentView               { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public ScreenTapSkipAnimationPlayer?            AnimationPlayer                         { get; set; }
        public string                                   HowToPlayConfigRefKey                   { get; set; }
        public ProduceResultTransferRewardPopupViewFactory? TransferRewardPopupFactory              { get; set; }
        public InGameResultScriptController?            ScriptController                        { get; set; }
        public ProduceParameterRank                     FesUnitRank                             { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ProduceResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResultView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A2443D0 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.RewardView                                = GetObject<ProduceResultRewardView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceResultRewardView.FromPointer); // 02466A2443F0 0x28 RewardView                  ( 000186575FC0 ModelClassType ProduceResultRewardView ProduceResultRewardView ProduceResultRewardView Pointer )
            value.IdolBaseRewardContentView                 = GetObject<ResultIdolBaseRewardContentView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ResultIdolBaseRewardContentView.FromPointer); // 02466A244410 0x30 IdolBaseRewardContentView   ( 000186675B30 ModelClassType ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView ResultIdolBaseRewardContentView Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466A244430 0x38 NextButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AnimationPlayer                           = GetObject<ScreenTapSkipAnimationPlayer>(new IntPtr(p + 0x040), ReversePrism.DataModels.ScreenTapSkipAnimationPlayer.FromPointer); // 02466A244450 0x40 AnimationPlayer             ( 0001866F3450 ModelClassType ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer ScreenTapSkipAnimationPlayer Pointer )
            value.HowToPlayConfigRefKey                     = GetString(new IntPtr(p + 0x048)); // 02466A244470 0x48 HowToPlayConfigRefKey       ( 000186671910 ModelPrimitiveType string string string String )
            value.TransferRewardPopupFactory                = GetObject<ProduceResultTransferRewardPopupViewFactory>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceResultTransferRewardPopupViewFactory.FromPointer); // 02466A244490 0x50 TransferRewardPopupFactory  ( 000186577F80 ModelClassType ProduceResultTransferRewardPopupViewFactory ProduceResultTransferRewardPopupViewFactory ProduceResultTransferRewardPopupViewFactory Pointer )
            value.ScriptController                          = GetObject<InGameResultScriptController>(new IntPtr(p + 0x068), ReversePrism.DataModels.InGameResultScriptController.FromPointer); // 02466A2444F0 0x68 ScriptController            ( 0001866D8C40 ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer )
            value.FesUnitRank                               = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x070)); // 02466A244510 0x70 FesUnitRank                 ( 00018660D900 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x078), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A244530 0x78 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}

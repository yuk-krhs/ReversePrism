using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StageTitleText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 FunPanelView                             00018657A940 ModelClassType ChallengeTourResultFunPanelView ChallengeTourResultFunPanelView ChallengeTourResultFunPanelView Pointer
    // 030 RewardPanelView                          00018657B590 ModelClassType ChallengeTourResultRewardPanelView ChallengeTourResultRewardPanelView ChallengeTourResultRewardPanelView Pointer
    // 038 NextButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 rewardReceivePopupFactory                PopupViewFactory`1<IChallengeTourResultRewardReceivePopupView> IL2CPP_TYPE_GENERICINST
    // 048 ViewModel                                00018657D540 ModelClassType ChallengeTourResultViewModel ChallengeTourResultViewModel ChallengeTourResultViewModel Pointer
    // 050 ScriptController                         0001866D8C40 ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer
    public partial class ChallengeTourResultView
    {
        public UITextMeshProUGUI?                       StageTitleText                          { get; set; }
        public ChallengeTourResultFunPanelView?         FunPanelView                            { get; set; }
        public ChallengeTourResultRewardPanelView?      RewardPanelView                         { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public ChallengeTourResultViewModel?            ViewModel                               { get; set; }
        public InGameResultScriptController?            ScriptController                        { get; set; }

        public static ChallengeTourResultView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourResultView();

            value.StageTitleText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA1CAE38 0x20 StageTitleText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FunPanelView                              = GetObject<ChallengeTourResultFunPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourResultFunPanelView.FromPointer); // 0270DA1CAE58 0x28 FunPanelView                ( 00018657A940 ModelClassType ChallengeTourResultFunPanelView ChallengeTourResultFunPanelView ChallengeTourResultFunPanelView Pointer )
            value.RewardPanelView                           = GetObject<ChallengeTourResultRewardPanelView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourResultRewardPanelView.FromPointer); // 0270DA1CAE78 0x30 RewardPanelView             ( 00018657B590 ModelClassType ChallengeTourResultRewardPanelView ChallengeTourResultRewardPanelView ChallengeTourResultRewardPanelView Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA1CAE98 0x38 NextButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourResultViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ChallengeTourResultViewModel.FromPointer); // 0270DA1CAED8 0x48 ViewModel                   ( 00018657D540 ModelClassType ChallengeTourResultViewModel ChallengeTourResultViewModel ChallengeTourResultViewModel Pointer )
            value.ScriptController                          = GetObject<InGameResultScriptController>(new IntPtr(p + 0x050), ReversePrism.DataModels.InGameResultScriptController.FromPointer); // 0270DA1CAEF8 0x50 ScriptController            ( 0001866D8C40 ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer )

            return value;
        }
    }
}

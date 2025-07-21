using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StageTitleText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 FunPanelView                             ModelClassType ChallengeTourResultFunPanelView ChallengeTourResultFunPanelView ChallengeTourResultFunPanelView Pointer
    // 030 RewardPanelView                          ModelClassType ChallengeTourResultRewardPanelView ChallengeTourResultRewardPanelView ChallengeTourResultRewardPanelView Pointer
    // 038 NextButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 040 ViewModel                                ModelClassType ChallengeTourResultViewModel ChallengeTourResultViewModel ChallengeTourResultViewModel Pointer
    // 048 ScriptController                         ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer
    public partial class ChallengeTourResultView : DataModel
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
            var value   = new ChallengeTourResultView() { Pointer= p0 };

            value.StageTitleText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 StageTitleText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FunPanelView                              = GetObject<ChallengeTourResultFunPanelView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ChallengeTourResultFunPanelView.FromPointer); // 0x28 FunPanelView                ( ModelClassType ChallengeTourResultFunPanelView ChallengeTourResultFunPanelView ChallengeTourResultFunPanelView Pointer )
            value.RewardPanelView                           = GetObject<ChallengeTourResultRewardPanelView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChallengeTourResultRewardPanelView.FromPointer); // 0x30 RewardPanelView             ( ModelClassType ChallengeTourResultRewardPanelView ChallengeTourResultRewardPanelView ChallengeTourResultRewardPanelView Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 NextButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<ChallengeTourResultViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.ChallengeTourResultViewModel.FromPointer); // 0x40 ViewModel                   ( ModelClassType ChallengeTourResultViewModel ChallengeTourResultViewModel ChallengeTourResultViewModel Pointer )
            value.ScriptController                          = GetObject<InGameResultScriptController>(new IntPtr(p + 0x048), ReversePrism.DataModels.InGameResultScriptController.FromPointer); // 0x48 ScriptController            ( ModelClassType InGameResultScriptController InGameResultScriptController InGameResultScriptController Pointer )

            return value;
        }
    }
}

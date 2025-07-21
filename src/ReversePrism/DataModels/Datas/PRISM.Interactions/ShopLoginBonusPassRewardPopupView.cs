using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MessageText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 RewardItem                               ModelClassType RewardItem RewardItem RewardItem Pointer
    // 030 ValidPeriodLabel                         ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ValidPeriodText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 PopupCheckToggleButton                   ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 048 PopupOpenCheckLabel                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 IsOn                                     ModelPrimitiveType bool bool bool Bool
    // 058 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopLoginBonusPassRewardPopupView : DataModel
    {
        public UITextMeshProUGUI?                       MessageText                             { get; set; }
        public RewardItem?                              RewardItem                              { get; set; }
        public UITextMeshProUGUI?                       ValidPeriodLabel                        { get; set; }
        public UITextMeshProUGUI?                       ValidPeriodText                         { get; set; }
        public ToggleButton?                            PopupCheckToggleButton                  { get; set; }
        public UITextMeshProUGUI?                       PopupOpenCheckLabel                     { get; set; }
        public bool                                     IsOn                                    { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ShopLoginBonusPassRewardPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopLoginBonusPassRewardPopupView() { Pointer= p0 };

            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 MessageText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardItem                                = GetObject<RewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItem.FromPointer); // 0x28 RewardItem                  ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ValidPeriodLabel                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ValidPeriodLabel            ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValidPeriodText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 ValidPeriodText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PopupCheckToggleButton                    = GetObject<ToggleButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x40 PopupCheckToggleButton      ( ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.PopupOpenCheckLabel                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 PopupOpenCheckLabel         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IsOn                                      = GetBool(new IntPtr(p + 0x050)); // 0x50 IsOn                        ( ModelPrimitiveType bool bool bool Bool )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x60 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

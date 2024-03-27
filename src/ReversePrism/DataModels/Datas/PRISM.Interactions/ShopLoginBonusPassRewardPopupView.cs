using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MessageText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 RewardItem                               00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 030 ValidPeriodLabel                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ValidPeriodText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 PopupCheckToggleButton                   000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer
    // 048 PopupOpenCheckLabel                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 IsOn                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopLoginBonusPassRewardPopupView
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
            var value   = new ShopLoginBonusPassRewardPopupView();

            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB7BDAD0 0x20 MessageText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardItem                                = GetObject<RewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DB7BDAF0 0x28 RewardItem                  ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ValidPeriodLabel                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB7BDB10 0x30 ValidPeriodLabel            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ValidPeriodText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB7BDB30 0x38 ValidPeriodText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PopupCheckToggleButton                    = GetObject<ToggleButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270DB7BDB50 0x40 PopupCheckToggleButton      ( 000186683C40 ModelClassType ToggleButton ToggleButton ToggleButton Pointer )
            value.PopupOpenCheckLabel                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB7BDB70 0x48 PopupOpenCheckLabel         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IsOn                                      = GetBool(new IntPtr(p + 0x050)); // 0270DB7BDB90 0x50 IsOn                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB7BDBD0 0x60 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

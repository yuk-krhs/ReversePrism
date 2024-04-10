using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PurchasedDateText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemTitleText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 UseProductCountText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ExchangeProductCountText                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 RewardItem                               00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 048 RightIcon                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 CellButton                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 UseProductIconRewardItem                 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 060 PIdolDetail                              000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer
    // 068 SCharaDetail                             0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer
    // 070 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ExchangeHistoryItemView : DataModel
    {
        public UITextMeshProUGUI?                       PurchasedDateText                       { get; set; }
        public UITextMeshProUGUI?                       ItemTitleText                           { get; set; }
        public UITextMeshProUGUI?                       UseProductCountText                     { get; set; }
        public UITextMeshProUGUI?                       ExchangeProductCountText                { get; set; }
        public RewardItemIcon?                          RewardItem                              { get; set; }
        public GameObject?                              RightIcon                               { get; set; }
        public UIButton?                                CellButton                              { get; set; }
        public RewardItem?                              UseProductIconRewardItem                { get; set; }
        public PIdolDetailPopupCaller?                  PIdolDetail                             { get; set; }
        public SCharaDetailPopupCaller?                 SCharaDetail                            { get; set; }

        public static ExchangeHistoryItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeHistoryItemView() { Pointer= p0 };

            value.PurchasedDateText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B972C38 0x20 PurchasedDateText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemTitleText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B972C58 0x28 ItemTitleText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UseProductCountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B972C78 0x30 UseProductCountText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeProductCountText                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B972C98 0x38 ExchangeProductCountText    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardItem                                = GetObject<RewardItemIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 02466B972CB8 0x40 RewardItem                  ( 00018667FAC0 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.RightIcon                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466B972CD8 0x48 RightIcon                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CellButton                                = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 02466B972CF8 0x50 CellButton                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.UseProductIconRewardItem                  = GetObject<RewardItem>(new IntPtr(p + 0x058), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B972D18 0x58 UseProductIconRewardItem    ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PIdolDetail                               = GetObject<PIdolDetailPopupCaller>(new IntPtr(p + 0x060), ReversePrism.DataModels.PIdolDetailPopupCaller.FromPointer); // 02466B972D38 0x60 PIdolDetail                 ( 000186709050 ModelClassType PIdolDetailPopupCaller PIdolDetailPopupCaller PIdolDetailPopupCaller Pointer )
            value.SCharaDetail                              = GetObject<SCharaDetailPopupCaller>(new IntPtr(p + 0x068), ReversePrism.DataModels.SCharaDetailPopupCaller.FromPointer); // 02466B972D58 0x68 SCharaDetail                ( 0001866A33D0 ModelClassType SCharaDetailPopupCaller SCharaDetailPopupCaller SCharaDetailPopupCaller Pointer )

            return value;
        }
    }
}

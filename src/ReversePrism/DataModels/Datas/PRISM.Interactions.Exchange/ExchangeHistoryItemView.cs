using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 PurchasedDateText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemTitleText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 UseProductCountText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ExchangeProductCountText                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 RewardItem                               ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 048 RightIcon                                ModelClassType GameObject GameObject GameObject Pointer
    // 050 CellButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 058 UseProductIconRewardItem                 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 060 onClick                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
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

        public static ExchangeHistoryItemView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeHistoryItemView() { Pointer= p0 };

            value.PurchasedDateText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 PurchasedDateText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemTitleText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 ItemTitleText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UseProductCountText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 UseProductCountText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeProductCountText                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 ExchangeProductCountText    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RewardItem                                = GetObject<RewardItemIcon>(new IntPtr(p + 0x040), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x40 RewardItem                  ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.RightIcon                                 = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 RightIcon                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CellButton                                = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 CellButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.UseProductIconRewardItem                  = GetObject<RewardItem>(new IntPtr(p + 0x058), ReversePrism.DataModels.RewardItem.FromPointer); // 0x58 UseProductIconRewardItem    ( ModelClassType RewardItem RewardItem RewardItem Pointer )

            return value;
        }
    }
}

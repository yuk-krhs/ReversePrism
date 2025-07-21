using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ExchangeProductRewardIcon                ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 030 ExchangeProductNameText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ExchangeCountProductIcon                 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 040 ExchangeCountText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 PurchaseProductIcon                      ModelClassType RewardItem RewardItem RewardItem Pointer
    // 050 PurchaseProductCountTextPair             ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 058 ExchangeCountFluctionObject              ModelClassType GameObject GameObject GameObject Pointer
    // 060 ExchangeCountBeforeText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ExchangeCountAfterText                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ExchangeCountNoneText                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 CautionText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 088 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeSimpleConfirmPopupView : DataModel
    {
        public UITextMeshProUGUI?                       HeaderText                              { get; set; }
        public RewardItemIcon?                          ExchangeProductRewardIcon               { get; set; }
        public UITextMeshProUGUI?                       ExchangeProductNameText                 { get; set; }
        public RewardItem?                              ExchangeCountProductIcon                { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountText                       { get; set; }
        public RewardItem?                              PurchaseProductIcon                     { get; set; }
        public ValueFluctionTextPair?                   PurchaseProductCountTextPair            { get; set; }
        public GameObject?                              ExchangeCountFluctionObject             { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountBeforeText                 { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountAfterText                  { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountNoneText                   { get; set; }
        public UITextMeshProUGUI?                       CautionText                             { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeSimpleConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSimpleConfirmPopupView() { Pointer= p0 };

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 HeaderText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeProductRewardIcon                 = GetObject<RewardItemIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x28 ExchangeProductRewardIcon   ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.ExchangeProductNameText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 ExchangeProductNameText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountProductIcon                  = GetObject<RewardItem>(new IntPtr(p + 0x038), ReversePrism.DataModels.RewardItem.FromPointer); // 0x38 ExchangeCountProductIcon    ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ExchangeCountText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 ExchangeCountText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x048), ReversePrism.DataModels.RewardItem.FromPointer); // 0x48 PurchaseProductIcon         ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PurchaseProductCountTextPair              = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x050), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x50 PurchaseProductCountTextPair ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeCountFluctionObject               = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 ExchangeCountFluctionObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeCountBeforeText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 ExchangeCountBeforeText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountAfterText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 ExchangeCountAfterText      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountNoneText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 ExchangeCountNoneText       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 CautionText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x088), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x88 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

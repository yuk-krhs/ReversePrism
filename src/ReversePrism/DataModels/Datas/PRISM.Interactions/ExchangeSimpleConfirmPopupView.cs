using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderText                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ExchangeProductIcon                      000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer
    // 030 ExchangeProductCmnItem                   0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer
    // 038 ExchangeProductNameText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 ExchangeCountProductIcon                 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 048 ExchangeCountText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 PurchaseProductIcon                      00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 058 PurchaseProductCountTextPair             000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 060 ExchangeCountFluctionObject              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 ExchangeCountBeforeText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 070 ExchangeCountAfterText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 ExchangeCountNoneText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 CautionText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 090 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeSimpleConfirmPopupView : DataModel
    {
        public UITextMeshProUGUI?                       HeaderText                              { get; set; }
        public GashaProductItemPresenter?               ExchangeProductIcon                     { get; set; }
        public CmnItem?                                 ExchangeProductCmnItem                  { get; set; }
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

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B989B30 0x20 HeaderText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeProductIcon                       = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 02466B989B50 0x28 ExchangeProductIcon         ( 000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.ExchangeProductCmnItem                    = GetObject<CmnItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.CmnItem.FromPointer); // 02466B989B70 0x30 ExchangeProductCmnItem      ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.ExchangeProductNameText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B989B90 0x38 ExchangeProductNameText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountProductIcon                  = GetObject<RewardItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B989BB0 0x40 ExchangeCountProductIcon    ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ExchangeCountText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B989BD0 0x48 ExchangeCountText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x050), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B989BF0 0x50 PurchaseProductIcon         ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PurchaseProductCountTextPair              = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x058), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 02466B989C10 0x58 PurchaseProductCountTextPair ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeCountFluctionObject               = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466B989C30 0x60 ExchangeCountFluctionObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeCountBeforeText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B989C50 0x68 ExchangeCountBeforeText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountAfterText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B989C70 0x70 ExchangeCountAfterText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountNoneText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B989C90 0x78 ExchangeCountNoneText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B989CB0 0x80 CautionText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x090), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B989CF0 0x90 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

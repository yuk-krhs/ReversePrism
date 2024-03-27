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
    // 038 DetailButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 ExchangeProductNameText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 PieceProductRootObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 PieceLabelText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 PieceProductIcon                         00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 060 PieceProductNameText                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 ExchangeCountProductIcon                 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 070 ExchangeCountText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 PurchaseProductIcon                      00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 080 PurchaseProductCountTextPair             000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 088 StarCountRootObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 StarCountProductIcon                     00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 098 StarCountTextPair                        000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0A0 PieceCountRootObject                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 PieceCountProductIcon                    00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 0B0 PieceCountTextPair                       000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0B8 ExchangeCountRootObject                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C0 ExchangeCountFluctionObject              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0C8 ExchangeCountBeforeText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D0 ExchangeCountAfterText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D8 ExchangeCountNoneText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0E0 CostumeDetailPopupCaller                 00018662B0A0 ModelClassType CostumeDetailPopupCaller CostumeDetailPopupCaller CostumeDetailPopupCaller Pointer
    // 0E8 onClick                                  Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 0F0 onDetail                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0F8 ViewModel                                0001865190D0 ModelClassType ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel Pointer
    // 100 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeSelectionConfirmPopupView
    {
        public UITextMeshProUGUI?                       HeaderText                              { get; set; }
        public GashaProductItemPresenter?               ExchangeProductIcon                     { get; set; }
        public CmnItem?                                 ExchangeProductCmnItem                  { get; set; }
        public UIButton?                                DetailButton                            { get; set; }
        public UITextMeshProUGUI?                       ExchangeProductNameText                 { get; set; }
        public GameObject?                              PieceProductRootObject                  { get; set; }
        public UITextMeshProUGUI?                       PieceLabelText                          { get; set; }
        public RewardItem?                              PieceProductIcon                        { get; set; }
        public UITextMeshProUGUI?                       PieceProductNameText                    { get; set; }
        public RewardItem?                              ExchangeCountProductIcon                { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountText                       { get; set; }
        public RewardItem?                              PurchaseProductIcon                     { get; set; }
        public ValueFluctionTextPair?                   PurchaseProductCountTextPair            { get; set; }
        public GameObject?                              StarCountRootObject                     { get; set; }
        public RewardItem?                              StarCountProductIcon                    { get; set; }
        public ValueFluctionTextPair?                   StarCountTextPair                       { get; set; }
        public GameObject?                              PieceCountRootObject                    { get; set; }
        public RewardItem?                              PieceCountProductIcon                   { get; set; }
        public ValueFluctionTextPair?                   PieceCountTextPair                      { get; set; }
        public GameObject?                              ExchangeCountRootObject                 { get; set; }
        public GameObject?                              ExchangeCountFluctionObject             { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountBeforeText                 { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountAfterText                  { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountNoneText                   { get; set; }
        public CostumeDetailPopupCaller?                CostumeDetailPopupCaller                { get; set; }
        public ExchangeSelectionListItemViewModel?      ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeSelectionConfirmPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionConfirmPopupView();

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8EC780 0x20 HeaderText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeProductIcon                       = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 0270DB8EC7A0 0x28 ExchangeProductIcon         ( 000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.ExchangeProductCmnItem                    = GetObject<CmnItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.CmnItem.FromPointer); // 0270DB8EC7C0 0x30 ExchangeProductCmnItem      ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.DetailButton                              = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB8EC7E0 0x38 DetailButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ExchangeProductNameText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8EC800 0x40 ExchangeProductNameText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PieceProductRootObject                    = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8EC820 0x48 PieceProductRootObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceLabelText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8EC840 0x50 PieceLabelText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PieceProductIcon                          = GetObject<RewardItem>(new IntPtr(p + 0x058), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DB8EC860 0x58 PieceProductIcon            ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PieceProductNameText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8EC880 0x60 PieceProductNameText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountProductIcon                  = GetObject<RewardItem>(new IntPtr(p + 0x068), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DB8EC8A0 0x68 ExchangeCountProductIcon    ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ExchangeCountText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8EC8C0 0x70 ExchangeCountText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x078), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DB8EC8E0 0x78 PurchaseProductIcon         ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PurchaseProductCountTextPair              = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x080), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0270DB8EC900 0x80 PurchaseProductCountTextPair ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.StarCountRootObject                       = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8EC920 0x88 StarCountRootObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.StarCountProductIcon                      = GetObject<RewardItem>(new IntPtr(p + 0x090), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DB8EC940 0x90 StarCountProductIcon        ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.StarCountTextPair                         = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x098), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0270DB8EC960 0x98 StarCountTextPair           ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.PieceCountRootObject                      = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8EC980 0xA0 PieceCountRootObject        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceCountProductIcon                     = GetObject<RewardItem>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DB8EC9A0 0xA8 PieceCountProductIcon       ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PieceCountTextPair                        = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0270DB8EC9C0 0xB0 PieceCountTextPair          ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeCountRootObject                   = GetObject<GameObject>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8EC9E0 0xB8 ExchangeCountRootObject     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeCountFluctionObject               = GetObject<GameObject>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8ECA00 0xC0 ExchangeCountFluctionObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeCountBeforeText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8ECA20 0xC8 ExchangeCountBeforeText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountAfterText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8ECA40 0xD0 ExchangeCountAfterText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountNoneText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8ECA60 0xD8 ExchangeCountNoneText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeDetailPopupCaller                  = GetObject<CostumeDetailPopupCaller>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CostumeDetailPopupCaller.FromPointer); // 0270DB8ECA80 0xE0 CostumeDetailPopupCaller    ( 00018662B0A0 ModelClassType CostumeDetailPopupCaller CostumeDetailPopupCaller CostumeDetailPopupCaller Pointer )
            value.ViewModel                                 = GetObject<ExchangeSelectionListItemViewModel>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ExchangeSelectionListItemViewModel.FromPointer); // 0270DB8ECAE0 0xF8 ViewModel                   ( 0001865190D0 ModelClassType ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x100), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB8ECB00 0x100 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

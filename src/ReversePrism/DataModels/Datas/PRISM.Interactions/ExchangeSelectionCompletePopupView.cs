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
    // 068 PurchaseProductIcon                      00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 070 PurchaseProductCountTextPair             000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 078 StarCountRootObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 StarCountProductIcon                     00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 088 StarCountTextPair                        000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 090 PieceCountRootObject                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 098 PieceCountProductIcon                    00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 0A0 PieceCountTextPair                       000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0A8 ExchangeCountRootObject                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 ExchangeCountFluctionObject              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 0B8 ExchangeCountBeforeText                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 ExchangeCountAfterText                   0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 ExchangeCountNoneText                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0D0 CostumeDetailPopupCaller                 00018662B0A0 ModelClassType CostumeDetailPopupCaller CostumeDetailPopupCaller CostumeDetailPopupCaller Pointer
    // 0D8 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0E0 onDetail                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0E8 ViewModel                                0001865190D0 ModelClassType ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel Pointer
    // 0F0 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeSelectionCompletePopupView : DataModel
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

        public static ExchangeSelectionCompletePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionCompletePopupView() { Pointer= p0 };

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9734E8 0x20 HeaderText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeProductIcon                       = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 02466B973508 0x28 ExchangeProductIcon         ( 000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.ExchangeProductCmnItem                    = GetObject<CmnItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.CmnItem.FromPointer); // 02466B973528 0x30 ExchangeProductCmnItem      ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.DetailButton                              = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466B973548 0x38 DetailButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ExchangeProductNameText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B973568 0x40 ExchangeProductNameText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PieceProductRootObject                    = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466B973588 0x48 PieceProductRootObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceLabelText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9735A8 0x50 PieceLabelText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PieceProductIcon                          = GetObject<RewardItem>(new IntPtr(p + 0x058), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B9735C8 0x58 PieceProductIcon            ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PieceProductNameText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B9735E8 0x60 PieceProductNameText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x068), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B973608 0x68 PurchaseProductIcon         ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PurchaseProductCountTextPair              = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x070), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 02466B973628 0x70 PurchaseProductCountTextPair ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.StarCountRootObject                       = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 02466B973648 0x78 StarCountRootObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.StarCountProductIcon                      = GetObject<RewardItem>(new IntPtr(p + 0x080), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B973668 0x80 StarCountProductIcon        ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.StarCountTextPair                         = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x088), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 02466B973688 0x88 StarCountTextPair           ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.PieceCountRootObject                      = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 02466B9736A8 0x90 PieceCountRootObject        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceCountProductIcon                     = GetObject<RewardItem>(new IntPtr(p + 0x098), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B9736C8 0x98 PieceCountProductIcon       ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PieceCountTextPair                        = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 02466B9736E8 0xA0 PieceCountTextPair          ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeCountRootObject                   = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 02466B973708 0xA8 ExchangeCountRootObject     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeCountFluctionObject               = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 02466B973728 0xB0 ExchangeCountFluctionObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeCountBeforeText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B973748 0xB8 ExchangeCountBeforeText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountAfterText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B973768 0xC0 ExchangeCountAfterText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountNoneText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B973788 0xC8 ExchangeCountNoneText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeDetailPopupCaller                  = GetObject<CostumeDetailPopupCaller>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CostumeDetailPopupCaller.FromPointer); // 02466B9737A8 0xD0 CostumeDetailPopupCaller    ( 00018662B0A0 ModelClassType CostumeDetailPopupCaller CostumeDetailPopupCaller CostumeDetailPopupCaller Pointer )
            value.ViewModel                                 = GetObject<ExchangeSelectionListItemViewModel>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ExchangeSelectionListItemViewModel.FromPointer); // 02466B973808 0xE8 ViewModel                   ( 0001865190D0 ModelClassType ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B973828 0xF0 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

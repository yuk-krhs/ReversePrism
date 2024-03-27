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
    public partial class ExchangeSelectionCompletePopupView
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
            var value   = new ExchangeSelectionCompletePopupView();

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8EB9E0 0x20 HeaderText                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeProductIcon                       = GetObject<GashaProductItemPresenter>(new IntPtr(p + 0x028), ReversePrism.DataModels.GashaProductItemPresenter.FromPointer); // 0270DB8EBA00 0x28 ExchangeProductIcon         ( 000186610A30 ModelClassType GashaProductItemPresenter GashaProductItemPresenter GashaProductItemPresenter Pointer )
            value.ExchangeProductCmnItem                    = GetObject<CmnItem>(new IntPtr(p + 0x030), ReversePrism.DataModels.CmnItem.FromPointer); // 0270DB8EBA20 0x30 ExchangeProductCmnItem      ( 0001865BC1A0 ModelClassType CmnItem CmnItem CmnItem Pointer )
            value.DetailButton                              = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB8EBA40 0x38 DetailButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ExchangeProductNameText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8EBA60 0x40 ExchangeProductNameText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PieceProductRootObject                    = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8EBA80 0x48 PieceProductRootObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceLabelText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8EBAA0 0x50 PieceLabelText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PieceProductIcon                          = GetObject<RewardItem>(new IntPtr(p + 0x058), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DB8EBAC0 0x58 PieceProductIcon            ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PieceProductNameText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8EBAE0 0x60 PieceProductNameText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x068), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DB8EBB00 0x68 PurchaseProductIcon         ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PurchaseProductCountTextPair              = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x070), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0270DB8EBB20 0x70 PurchaseProductCountTextPair ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.StarCountRootObject                       = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8EBB40 0x78 StarCountRootObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.StarCountProductIcon                      = GetObject<RewardItem>(new IntPtr(p + 0x080), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DB8EBB60 0x80 StarCountProductIcon        ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.StarCountTextPair                         = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x088), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0270DB8EBB80 0x88 StarCountTextPair           ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.PieceCountRootObject                      = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8EBBA0 0x90 PieceCountRootObject        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceCountProductIcon                     = GetObject<RewardItem>(new IntPtr(p + 0x098), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DB8EBBC0 0x98 PieceCountProductIcon       ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PieceCountTextPair                        = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0270DB8EBBE0 0xA0 PieceCountTextPair          ( 000186768A80 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeCountRootObject                   = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8EBC00 0xA8 ExchangeCountRootObject     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeCountFluctionObject               = GetObject<GameObject>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB8EBC20 0xB0 ExchangeCountFluctionObject ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeCountBeforeText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8EBC40 0xB8 ExchangeCountBeforeText     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountAfterText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8EBC60 0xC0 ExchangeCountAfterText      ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountNoneText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB8EBC80 0xC8 ExchangeCountNoneText       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeDetailPopupCaller                  = GetObject<CostumeDetailPopupCaller>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CostumeDetailPopupCaller.FromPointer); // 0270DB8EBCA0 0xD0 CostumeDetailPopupCaller    ( 00018662B0A0 ModelClassType CostumeDetailPopupCaller CostumeDetailPopupCaller CostumeDetailPopupCaller Pointer )
            value.ViewModel                                 = GetObject<ExchangeSelectionListItemViewModel>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.ExchangeSelectionListItemViewModel.FromPointer); // 0270DB8EBD00 0xE8 ViewModel                   ( 0001865190D0 ModelClassType ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB8EBD20 0xF0 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

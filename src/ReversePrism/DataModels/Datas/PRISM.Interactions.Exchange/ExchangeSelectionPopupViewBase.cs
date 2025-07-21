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
    // 030 DetailButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 038 ExchangeProductNameText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 PieceProductRootObject                   ModelClassType GameObject GameObject GameObject Pointer
    // 048 PieceLabelText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 PieceProductIcon                         ModelClassType RewardItem RewardItem RewardItem Pointer
    // 058 PieceProductNameText                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 PurchaseProductIcon                      ModelClassType RewardItem RewardItem RewardItem Pointer
    // 068 PurchaseProductCountTextPair             ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 070 StarCountRootObject                      ModelClassType GameObject GameObject GameObject Pointer
    // 078 StarCountProductIcon                     ModelClassType RewardItem RewardItem RewardItem Pointer
    // 080 StarCountTextPair                        ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 088 PieceCountRootObject                     ModelClassType GameObject GameObject GameObject Pointer
    // 090 PieceCountProductIcon                    ModelClassType RewardItem RewardItem RewardItem Pointer
    // 098 PieceCountTextPair                       ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0A0 ExchangeCountRootObject                  ModelClassType GameObject GameObject GameObject Pointer
    // 0A8 ExchangeCountFluctionObject              ModelClassType GameObject GameObject GameObject Pointer
    // 0B0 ExchangeCountBeforeText                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B8 ExchangeCountAfterText                   ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C0 ExchangeCountNoneText                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0C8 AmountTextPair                           ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0D0 onDetail                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0D8 ViewModel                                ModelClassType ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel Pointer
    // 0E0 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ExchangeSelectionPopupViewBase : DataModel
    {
        public UITextMeshProUGUI?                       HeaderText                              { get; set; }
        public RewardItemIcon?                          ExchangeProductRewardIcon               { get; set; }
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
        public ValueFluctionTextPair?                   AmountTextPair                          { get; set; }
        public ExchangeSelectionListItemViewModel?      ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ExchangeSelectionPopupViewBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSelectionPopupViewBase() { Pointer= p0 };

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 HeaderText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeProductRewardIcon                 = GetObject<RewardItemIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x28 ExchangeProductRewardIcon   ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.DetailButton                              = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 DetailButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ExchangeProductNameText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 ExchangeProductNameText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PieceProductRootObject                    = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 PieceProductRootObject      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceLabelText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 PieceLabelText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PieceProductIcon                          = GetObject<RewardItem>(new IntPtr(p + 0x050), ReversePrism.DataModels.RewardItem.FromPointer); // 0x50 PieceProductIcon            ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PieceProductNameText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 PieceProductNameText        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x060), ReversePrism.DataModels.RewardItem.FromPointer); // 0x60 PurchaseProductIcon         ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PurchaseProductCountTextPair              = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x068), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x68 PurchaseProductCountTextPair ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.StarCountRootObject                       = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 StarCountRootObject         ( ModelClassType GameObject GameObject GameObject Pointer )
            value.StarCountProductIcon                      = GetObject<RewardItem>(new IntPtr(p + 0x078), ReversePrism.DataModels.RewardItem.FromPointer); // 0x78 StarCountProductIcon        ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.StarCountTextPair                         = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x080), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x80 StarCountTextPair           ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.PieceCountRootObject                      = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 0x88 PieceCountRootObject        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.PieceCountProductIcon                     = GetObject<RewardItem>(new IntPtr(p + 0x090), ReversePrism.DataModels.RewardItem.FromPointer); // 0x90 PieceCountProductIcon       ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PieceCountTextPair                        = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x098), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x98 PieceCountTextPair          ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeCountRootObject                   = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0xA0 ExchangeCountRootObject     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeCountFluctionObject               = GetObject<GameObject>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.GameObject.FromPointer); // 0xA8 ExchangeCountFluctionObject ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeCountBeforeText                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB0 ExchangeCountBeforeText     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountAfterText                    = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xB8 ExchangeCountAfterText      ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountNoneText                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xC0 ExchangeCountNoneText       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.AmountTextPair                            = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0xC8 AmountTextPair              ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ViewModel                                 = GetObject<ExchangeSelectionListItemViewModel>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ExchangeSelectionListItemViewModel.FromPointer); // 0xD8 ViewModel                   ( ModelClassType ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0xE0 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}

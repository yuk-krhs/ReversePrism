using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 PriceViewProductIcon                     ModelClassType RewardItem RewardItem RewardItem Pointer
    // 030 PriceText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RateViewButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 040 CountMinusButton                         ModelClassType UIButton UIButton UIButton Pointer
    // 048 CountMinusJumpButton                     ModelClassType UIButton UIButton UIButton Pointer
    // 050 CountMinButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 058 CountPlusButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 060 CountPlusJumpButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 068 CountMaxButton                           ModelClassType UIButton UIButton UIButton Pointer
    // 070 GoodsIcon                                ModelClassType RewardItem RewardItem RewardItem Pointer
    // 078 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 ExchangeCountText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 PurchaseProductIcon                      ModelClassType RewardItem RewardItem RewardItem Pointer
    // 090 PurchaseProductCountTextPair             ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 098 GoodsCountTextPair                       ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0A0 ExchangeLimmitTextPair                   ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0A8 CautionText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 ViewModel                                ModelClassType ExchangeConfirmationPopupViewModel ExchangeConfirmationPopupViewModel ExchangeConfirmationPopupViewModel Pointer
    // 0B8 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 0C0 minusSubject                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0C8 plusSubject                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0D0 minusJumpSubject                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0D8 plusJumpSubject                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0E0 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeConfirmationPopupView : DataModel
    {
        public UITextMeshProUGUI?                       HeaderText                              { get; set; }
        public RewardItem?                              PriceViewProductIcon                    { get; set; }
        public UITextMeshProUGUI?                       PriceText                               { get; set; }
        public UIButton?                                RateViewButton                          { get; set; }
        public UIButton?                                CountMinusButton                        { get; set; }
        public UIButton?                                CountMinusJumpButton                    { get; set; }
        public UIButton?                                CountMinButton                          { get; set; }
        public UIButton?                                CountPlusButton                         { get; set; }
        public UIButton?                                CountPlusJumpButton                     { get; set; }
        public UIButton?                                CountMaxButton                          { get; set; }
        public RewardItem?                              GoodsIcon                               { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountText                       { get; set; }
        public RewardItem?                              PurchaseProductIcon                     { get; set; }
        public ValueFluctionTextPair?                   PurchaseProductCountTextPair            { get; set; }
        public ValueFluctionTextPair?                   GoodsCountTextPair                      { get; set; }
        public ValueFluctionTextPair?                   ExchangeLimmitTextPair                  { get; set; }
        public UITextMeshProUGUI?                       CautionText                             { get; set; }
        public ExchangeConfirmationPopupViewModel?      ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeConfirmationPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeConfirmationPopupView() { Pointer= p0 };

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 HeaderText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PriceViewProductIcon                      = GetObject<RewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItem.FromPointer); // 0x28 PriceViewProductIcon        ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 PriceText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RateViewButton                            = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 RateViewButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMinusButton                          = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 CountMinusButton            ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMinusJumpButton                      = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 CountMinusJumpButton        ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMinButton                            = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 CountMinButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CountPlusButton                           = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 CountPlusButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CountPlusJumpButton                       = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 0x60 CountPlusJumpButton         ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMaxButton                            = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0x68 CountMaxButton              ( ModelClassType UIButton UIButton UIButton Pointer )
            value.GoodsIcon                                 = GetObject<RewardItem>(new IntPtr(p + 0x070), ReversePrism.DataModels.RewardItem.FromPointer); // 0x70 GoodsIcon                   ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 ExchangeCountText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x088), ReversePrism.DataModels.RewardItem.FromPointer); // 0x88 PurchaseProductIcon         ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PurchaseProductCountTextPair              = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x090), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x90 PurchaseProductCountTextPair ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.GoodsCountTextPair                        = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x098), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x98 GoodsCountTextPair          ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeLimmitTextPair                    = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0xA0 ExchangeLimmitTextPair      ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0xA8 CautionText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<ExchangeConfirmationPopupViewModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ExchangeConfirmationPopupViewModel.FromPointer); // 0xB0 ViewModel                   ( ModelClassType ExchangeConfirmationPopupViewModel ExchangeConfirmationPopupViewModel ExchangeConfirmationPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0xE0 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

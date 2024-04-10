using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderText                               0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 PriceViewProductIcon                     00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 030 PriceText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 RateViewButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 CountMinusButton                         0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 CountMinusJumpButton                     0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 CountMinButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 CountPlusButton                          0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 CountPlusJumpButton                      0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 CountMaxButton                           0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 GoodsIcon                                00018667ECF0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 078 DescriptionText                          0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 ExchangeCountText                        0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 PurchaseProductIcon                      00018667ECF0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 090 PurchaseProductCountTextPair             000186768D00 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 098 GoodsCountTextPair                       000186768D00 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0A0 ExchangeLimmitTextPair                   000186768D00 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0A8 CautionText                              0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0B0 ViewModel                                0001867754C0 ModelClassType ExchangeConfirmationPopupViewModel ExchangeConfirmationPopupViewModel ExchangeConfirmationPopupViewModel Pointer
    // 0B8 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 0C0 minusSubject                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0C8 plusSubject                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0D0 minusJumpSubject                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0D8 plusJumpSubject                          Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 0E0 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B969008 0x20 HeaderText                  ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PriceViewProductIcon                      = GetObject<RewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B969028 0x28 PriceViewProductIcon        ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PriceText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B969048 0x30 PriceText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.RateViewButton                            = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 02466B969068 0x38 RateViewButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMinusButton                          = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 02466B969088 0x40 CountMinusButton            ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMinusJumpButton                      = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466B9690A8 0x48 CountMinusJumpButton        ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMinButton                            = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 02466B9690C8 0x50 CountMinButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CountPlusButton                           = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 02466B9690E8 0x58 CountPlusButton             ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CountPlusJumpButton                       = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 02466B969108 0x60 CountPlusJumpButton         ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CountMaxButton                            = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 02466B969128 0x68 CountMaxButton              ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.GoodsIcon                                 = GetObject<RewardItem>(new IntPtr(p + 0x070), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B969148 0x70 GoodsIcon                   ( 00018667ECF0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B969168 0x78 DescriptionText             ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B969188 0x80 ExchangeCountText           ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x088), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B9691A8 0x88 PurchaseProductIcon         ( 00018667ECF0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PurchaseProductCountTextPair              = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x090), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 02466B9691C8 0x90 PurchaseProductCountTextPair ( 000186768D00 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.GoodsCountTextPair                        = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x098), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 02466B9691E8 0x98 GoodsCountTextPair          ( 000186768D00 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeLimmitTextPair                    = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 02466B969208 0xA0 ExchangeLimmitTextPair      ( 000186768D00 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.CautionText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B969228 0xA8 CautionText                 ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = GetObject<ExchangeConfirmationPopupViewModel>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ExchangeConfirmationPopupViewModel.FromPointer); // 02466B969248 0xB0 ViewModel                   ( 0001867754C0 ModelClassType ExchangeConfirmationPopupViewModel ExchangeConfirmationPopupViewModel ExchangeConfirmationPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B969308 0xE0 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

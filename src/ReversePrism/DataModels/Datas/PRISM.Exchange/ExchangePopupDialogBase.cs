using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 HeaderText                               0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 GoodsIcon                                00018667ECF0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 070 DescriptionText                          0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 ExchangeCountText                        0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 PurchaseProductIcon                      00018667ECF0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 088 PurchaseProductCountTextPair             000186768D00 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 090 GoodsCountTextPair                       000186768D00 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 098 ExchangeLimmitTextPair                   000186768D00 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0A0 ExchangeParam                            0001865118D0 ModelClassType ExchangePopupDialogParam ExchangePopupDialogParam ExchangePopupDialogParam Pointer
    public partial class ExchangePopupDialogBase : DataModel
    {
        public UITextMeshProUGUI?                       HeaderText                              { get; set; }
        public RewardItem?                              GoodsIcon                               { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountText                       { get; set; }
        public RewardItem?                              PurchaseProductIcon                     { get; set; }
        public ValueFluctionTextPair?                   PurchaseProductCountTextPair            { get; set; }
        public ValueFluctionTextPair?                   GoodsCountTextPair                      { get; set; }
        public ValueFluctionTextPair?                   ExchangeLimmitTextPair                  { get; set; }
        public ExchangePopupDialogParam?                ExchangeParam                           { get; set; }

        public static ExchangePopupDialogBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangePopupDialogBase() { Pointer= p0 };

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665571050 0x60 HeaderText                  ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoodsIcon                                 = GetObject<RewardItem>(new IntPtr(p + 0x068), ReversePrism.DataModels.RewardItem.FromPointer); // 024665571070 0x68 GoodsIcon                   ( 00018667ECF0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665571090 0x70 DescriptionText             ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246655710B0 0x78 ExchangeCountText           ( 0001866F9370 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x080), ReversePrism.DataModels.RewardItem.FromPointer); // 0246655710D0 0x80 PurchaseProductIcon         ( 00018667ECF0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PurchaseProductCountTextPair              = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x088), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0246655710F0 0x88 PurchaseProductCountTextPair ( 000186768D00 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.GoodsCountTextPair                        = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x090), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 024665571110 0x90 GoodsCountTextPair          ( 000186768D00 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeLimmitTextPair                    = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x098), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 024665571130 0x98 ExchangeLimmitTextPair      ( 000186768D00 ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeParam                             = GetObject<ExchangePopupDialogParam>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ExchangePopupDialogParam.FromPointer); // 024665571150 0xA0 ExchangeParam               ( 0001865118D0 ModelClassType ExchangePopupDialogParam ExchangePopupDialogParam ExchangePopupDialogParam Pointer )

            return value;
        }
    }
}

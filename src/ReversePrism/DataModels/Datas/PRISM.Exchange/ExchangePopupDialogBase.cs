using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 HeaderText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 GoodsIcon                                ModelClassType RewardItem RewardItem RewardItem Pointer
    // 070 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 078 ExchangeCountText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 PurchaseProductIcon                      ModelClassType RewardItem RewardItem RewardItem Pointer
    // 088 PurchaseProductCountTextPair             ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 090 GoodsCountTextPair                       ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 098 ExchangeLimmitTextPair                   ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 0A0 ExchangeParam                            ModelClassType ExchangePopupDialogParam ExchangePopupDialogParam ExchangePopupDialogParam Pointer
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

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 HeaderText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.GoodsIcon                                 = GetObject<RewardItem>(new IntPtr(p + 0x068), ReversePrism.DataModels.RewardItem.FromPointer); // 0x68 GoodsIcon                   ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x070), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x70 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 ExchangeCountText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x080), ReversePrism.DataModels.RewardItem.FromPointer); // 0x80 PurchaseProductIcon         ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PurchaseProductCountTextPair              = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x088), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x88 PurchaseProductCountTextPair ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.GoodsCountTextPair                        = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x090), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x90 GoodsCountTextPair          ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeLimmitTextPair                    = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x098), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x98 ExchangeLimmitTextPair      ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeParam                             = GetObject<ExchangePopupDialogParam>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ExchangePopupDialogParam.FromPointer); // 0xA0 ExchangeParam               ( ModelClassType ExchangePopupDialogParam ExchangePopupDialogParam ExchangePopupDialogParam Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 HeaderText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ItemIcon                                 ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer
    // 030 DescriptionText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 ExchangeCountText                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 PurchaseProductIcon                      ModelClassType RewardItem RewardItem RewardItem Pointer
    // 048 PurchaseProductCountTextPair             ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 050 GoodsCountTextPair                       ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 058 ConvertProductIcon                       ModelClassType RewardItem RewardItem RewardItem Pointer
    // 060 ConvertCountTextPair                     ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 068 ExchangeLimmitTextPair                   ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer
    // 070 GoToType                                 ModelEnumType ButtonGoToType ButtonGoToType ButtonGoToType Int32
    // 078 ViewModel                                ModelClassType ExchangeResultPopupViewModel ExchangeResultPopupViewModel ExchangeResultPopupViewModel Pointer
    // 080 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 088 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeResultPopupView : DataModel
    {
        public UITextMeshProUGUI?                       HeaderText                              { get; set; }
        public RewardItemIcon?                          ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       DescriptionText                         { get; set; }
        public UITextMeshProUGUI?                       ExchangeCountText                       { get; set; }
        public RewardItem?                              PurchaseProductIcon                     { get; set; }
        public ValueFluctionTextPair?                   PurchaseProductCountTextPair            { get; set; }
        public ValueFluctionTextPair?                   GoodsCountTextPair                      { get; set; }
        public RewardItem?                              ConvertProductIcon                      { get; set; }
        public ValueFluctionTextPair?                   ConvertCountTextPair                    { get; set; }
        public ValueFluctionTextPair?                   ExchangeLimmitTextPair                  { get; set; }
        public ButtonGoToType                           GoToType                                { get; set; }
        public ExchangeResultPopupViewModel?            ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeResultPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeResultPopupView() { Pointer= p0 };

            value.HeaderText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 HeaderText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ItemIcon                                  = GetObject<RewardItemIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.RewardItemIcon.FromPointer); // 0x28 ItemIcon                    ( ModelClassType RewardItemIcon RewardItemIcon RewardItemIcon Pointer )
            value.DescriptionText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 DescriptionText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangeCountText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 ExchangeCountText           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PurchaseProductIcon                       = GetObject<RewardItem>(new IntPtr(p + 0x040), ReversePrism.DataModels.RewardItem.FromPointer); // 0x40 PurchaseProductIcon         ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PurchaseProductCountTextPair              = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x048), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x48 PurchaseProductCountTextPair ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.GoodsCountTextPair                        = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x050), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x50 GoodsCountTextPair          ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ConvertProductIcon                        = GetObject<RewardItem>(new IntPtr(p + 0x058), ReversePrism.DataModels.RewardItem.FromPointer); // 0x58 ConvertProductIcon          ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.ConvertCountTextPair                      = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x060), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x60 ConvertCountTextPair        ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.ExchangeLimmitTextPair                    = GetObject<ValueFluctionTextPair>(new IntPtr(p + 0x068), ReversePrism.DataModels.ValueFluctionTextPair.FromPointer); // 0x68 ExchangeLimmitTextPair      ( ModelClassType ValueFluctionTextPair ValueFluctionTextPair ValueFluctionTextPair Pointer )
            value.GoToType                                  = (ButtonGoToType)GetInt32(new IntPtr(p + 0x070)); // 0x70 GoToType                    ( ModelEnumType ButtonGoToType ButtonGoToType ButtonGoToType Int32 )
            value.ViewModel                                 = GetObject<ExchangeResultPopupViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.ExchangeResultPopupViewModel.FromPointer); // 0x78 ViewModel                   ( ModelClassType ExchangeResultPopupViewModel ExchangeResultPopupViewModel ExchangeResultPopupViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x088), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x88 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

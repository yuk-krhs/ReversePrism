using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ShopItemView                             00018676D480 ModelClassType ShopPurchaseHistoryItemView ShopPurchaseHistoryItemView ShopPurchaseHistoryItemView Pointer
    // 028 MainItemContainerView                    00018676C7C0 ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer
    // 030 BonusItemContainerView                   00018676C7C0 ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer
    // 038 ViewModel                                00018676DC10 ModelClassType ShopPurchaseHistoryListItemViewModel ShopPurchaseHistoryListItemViewModel ShopPurchaseHistoryListItemViewModel Pointer
    // 040 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onPassDetail                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ShopPurchaseHistoryDetailPopupView : DataModel
    {
        public ShopPurchaseHistoryItemView?             ShopItemView                            { get; set; }
        public ShopPurchaseHistoryDetailItemContainerView? MainItemContainerView                   { get; set; }
        public ShopPurchaseHistoryDetailItemContainerView? BonusItemContainerView                  { get; set; }
        public ShopPurchaseHistoryListItemViewModel?    ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ShopPurchaseHistoryDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchaseHistoryDetailPopupView() { Pointer= p0 };

            value.ShopItemView                              = GetObject<ShopPurchaseHistoryItemView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopPurchaseHistoryItemView.FromPointer); // 02466B878BE8 0x20 ShopItemView                ( 00018676D480 ModelClassType ShopPurchaseHistoryItemView ShopPurchaseHistoryItemView ShopPurchaseHistoryItemView Pointer )
            value.MainItemContainerView                     = GetObject<ShopPurchaseHistoryDetailItemContainerView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopPurchaseHistoryDetailItemContainerView.FromPointer); // 02466B878C08 0x28 MainItemContainerView       ( 00018676C7C0 ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer )
            value.BonusItemContainerView                    = GetObject<ShopPurchaseHistoryDetailItemContainerView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopPurchaseHistoryDetailItemContainerView.FromPointer); // 02466B878C28 0x30 BonusItemContainerView      ( 00018676C7C0 ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer )
            value.ViewModel                                 = GetObject<ShopPurchaseHistoryListItemViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ShopPurchaseHistoryListItemViewModel.FromPointer); // 02466B878C48 0x38 ViewModel                   ( 00018676DC10 ModelClassType ShopPurchaseHistoryListItemViewModel ShopPurchaseHistoryListItemViewModel ShopPurchaseHistoryListItemViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B878CA8 0x50 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

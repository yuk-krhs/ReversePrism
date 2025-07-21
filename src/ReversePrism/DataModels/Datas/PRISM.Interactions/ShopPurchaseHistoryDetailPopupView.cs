using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ShopItemView                             ModelClassType ShopPurchaseHistoryItemView ShopPurchaseHistoryItemView ShopPurchaseHistoryItemView Pointer
    // 028 MainItemContainerView                    ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer
    // 030 BonusItemContainerView                   ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer
    // 038 ViewModel                                ModelClassType ShopPurchaseHistoryListItemViewModel ShopPurchaseHistoryListItemViewModel ShopPurchaseHistoryListItemViewModel Pointer
    // 040 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onPassDetail                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.ShopItemView                              = GetObject<ShopPurchaseHistoryItemView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopPurchaseHistoryItemView.FromPointer); // 0x20 ShopItemView                ( ModelClassType ShopPurchaseHistoryItemView ShopPurchaseHistoryItemView ShopPurchaseHistoryItemView Pointer )
            value.MainItemContainerView                     = GetObject<ShopPurchaseHistoryDetailItemContainerView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopPurchaseHistoryDetailItemContainerView.FromPointer); // 0x28 MainItemContainerView       ( ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer )
            value.BonusItemContainerView                    = GetObject<ShopPurchaseHistoryDetailItemContainerView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopPurchaseHistoryDetailItemContainerView.FromPointer); // 0x30 BonusItemContainerView      ( ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer )
            value.ViewModel                                 = GetObject<ShopPurchaseHistoryListItemViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ShopPurchaseHistoryListItemViewModel.FromPointer); // 0x38 ViewModel                   ( ModelClassType ShopPurchaseHistoryListItemViewModel ShopPurchaseHistoryListItemViewModel ShopPurchaseHistoryListItemViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x50 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

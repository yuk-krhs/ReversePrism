using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MainItemContainerView                    00018676C7C0 ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer
    // 028 ViewModel                                0001865190D0 ModelClassType ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel Pointer
    // 030 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeProductDetailPopupView
    {
        public ShopPurchaseHistoryDetailItemContainerView? MainItemContainerView                   { get; set; }
        public ExchangeSelectionListItemViewModel?      ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeProductDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeProductDetailPopupView();

            value.MainItemContainerView                     = GetObject<ShopPurchaseHistoryDetailItemContainerView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopPurchaseHistoryDetailItemContainerView.FromPointer); // 0270DB8EB4E0 0x20 MainItemContainerView       ( 00018676C7C0 ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer )
            value.ViewModel                                 = GetObject<ExchangeSelectionListItemViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExchangeSelectionListItemViewModel.FromPointer); // 0270DB8EB500 0x28 ViewModel                   ( 0001865190D0 ModelClassType ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB8EB540 0x38 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MainItemContainerView                    ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer
    // 028 ViewModel                                ModelClassType ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel Pointer
    // 030 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 038 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ExchangeProductDetailPopupView : DataModel
    {
        public ShopPurchaseHistoryDetailItemContainerView? MainItemContainerView                   { get; set; }
        public ExchangeSelectionListItemViewModel?      ViewModel                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ExchangeProductDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeProductDetailPopupView() { Pointer= p0 };

            value.MainItemContainerView                     = GetObject<ShopPurchaseHistoryDetailItemContainerView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopPurchaseHistoryDetailItemContainerView.FromPointer); // 0x20 MainItemContainerView       ( ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer )
            value.ViewModel                                 = GetObject<ExchangeSelectionListItemViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExchangeSelectionListItemViewModel.FromPointer); // 0x28 ViewModel                   ( ModelClassType ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel ExchangeSelectionListItemViewModel Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x038), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x38 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

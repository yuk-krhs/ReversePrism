using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MainItemContainerView                    ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer
    // 028 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class ItemSetDetailPopupView : DataModel
    {
        public ShopPurchaseHistoryDetailItemContainerView? MainItemContainerView                   { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static ItemSetDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ItemSetDetailPopupView() { Pointer= p0 };

            value.MainItemContainerView                     = GetObject<ShopPurchaseHistoryDetailItemContainerView>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopPurchaseHistoryDetailItemContainerView.FromPointer); // 0x20 MainItemContainerView       ( ModelClassType ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView ShopPurchaseHistoryDetailItemContainerView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x30 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}

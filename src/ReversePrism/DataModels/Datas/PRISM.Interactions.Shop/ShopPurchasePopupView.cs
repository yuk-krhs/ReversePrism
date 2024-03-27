using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 028 ViewModel                                000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer
    public partial class ShopPurchasePopupView
    {
        public ShopViewModel?                           ViewModel                               { get; set; }

        public static ShopPurchasePopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchasePopupView();

            value.ViewModel                                 = GetObject<ShopViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopViewModel.FromPointer); // 0270DB7BF148 0x28 ViewModel                   ( 000186774A10 ModelClassType ShopViewModel ShopViewModel ShopViewModel Pointer )

            return value;
        }
    }
}

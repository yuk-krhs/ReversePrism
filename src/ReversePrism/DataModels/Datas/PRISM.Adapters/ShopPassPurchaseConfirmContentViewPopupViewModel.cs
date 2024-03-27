using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProductModel                             00018676FA20 ModelClassType ShopPurchaseProductModel ShopPurchaseProductModel ShopPurchaseProductModel Pointer
    public partial class ShopPassPurchaseConfirmContentViewPopupViewModel
    {
        public ShopPurchaseProductModel?                ProductModel                            { get; set; }

        public static ShopPassPurchaseConfirmContentViewPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPassPurchaseConfirmContentViewPopupViewModel();

            value.ProductModel                              = GetObject<ShopPurchaseProductModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopPurchaseProductModel.FromPointer); // 0270D673BCE8 0x10 ProductModel                ( 00018676FA20 ModelClassType ShopPurchaseProductModel ShopPurchaseProductModel ShopPurchaseProductModel Pointer )

            return value;
        }
    }
}

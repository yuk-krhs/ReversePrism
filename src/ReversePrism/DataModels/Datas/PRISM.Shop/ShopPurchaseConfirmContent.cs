using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 View                                     00018676C2D0 ModelClassType ShopPurchaseConfirmView ShopPurchaseConfirmView ShopPurchaseConfirmView Pointer
    // 068 Model                                    00018676FA20 ModelClassType ShopPurchaseProductModel ShopPurchaseProductModel ShopPurchaseProductModel Pointer
    public partial class ShopPurchaseConfirmContent
    {
        public ShopPurchaseConfirmView?                 View                                    { get; set; }
        public ShopPurchaseProductModel?                Model                                   { get; set; }

        public static ShopPurchaseConfirmContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchaseConfirmContent();

            value.View                                      = GetObject<ShopPurchaseConfirmView>(new IntPtr(p + 0x060), ReversePrism.DataModels.ShopPurchaseConfirmView.FromPointer); // 0270D55397C8 0x60 View                        ( 00018676C2D0 ModelClassType ShopPurchaseConfirmView ShopPurchaseConfirmView ShopPurchaseConfirmView Pointer )
            value.Model                                     = GetObject<ShopPurchaseProductModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.ShopPurchaseProductModel.FromPointer); // 0270D55397E8 0x68 Model                       ( 00018676FA20 ModelClassType ShopPurchaseProductModel ShopPurchaseProductModel ShopPurchaseProductModel Pointer )

            return value;
        }
    }
}

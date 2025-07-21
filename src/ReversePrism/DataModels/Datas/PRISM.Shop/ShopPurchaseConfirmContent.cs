using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 View                                     ModelClassType ShopPurchaseConfirmView ShopPurchaseConfirmView ShopPurchaseConfirmView Pointer
    // 068 Model                                    ModelClassType ShopPurchaseProductModel ShopPurchaseProductModel ShopPurchaseProductModel Pointer
    public partial class ShopPurchaseConfirmContent : DataModel
    {
        public ShopPurchaseConfirmView?                 View                                    { get; set; }
        public ShopPurchaseProductModel?                Model                                   { get; set; }

        public static ShopPurchaseConfirmContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchaseConfirmContent() { Pointer= p0 };

            value.View                                      = GetObject<ShopPurchaseConfirmView>(new IntPtr(p + 0x060), ReversePrism.DataModels.ShopPurchaseConfirmView.FromPointer); // 0x60 View                        ( ModelClassType ShopPurchaseConfirmView ShopPurchaseConfirmView ShopPurchaseConfirmView Pointer )
            value.Model                                     = GetObject<ShopPurchaseProductModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.ShopPurchaseProductModel.FromPointer); // 0x68 Model                       ( ModelClassType ShopPurchaseProductModel ShopPurchaseProductModel ShopPurchaseProductModel Pointer )

            return value;
        }
    }
}

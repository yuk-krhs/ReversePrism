using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 View                                     00018676B650 ModelClassType ShopPurchaseCompleteView ShopPurchaseCompleteView ShopPurchaseCompleteView Pointer
    // 068 Model                                    00018676FA20 ModelClassType ShopPurchaseProductModel ShopPurchaseProductModel ShopPurchaseProductModel Pointer
    public partial class ShopPurchaseCompleteContent : DataModel
    {
        public ShopPurchaseCompleteView?                View                                    { get; set; }
        public ShopPurchaseProductModel?                Model                                   { get; set; }

        public static ShopPurchaseCompleteContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchaseCompleteContent() { Pointer= p0 };

            value.View                                      = GetObject<ShopPurchaseCompleteView>(new IntPtr(p + 0x060), ReversePrism.DataModels.ShopPurchaseCompleteView.FromPointer); // 0246655AA3F0 0x60 View                        ( 00018676B650 ModelClassType ShopPurchaseCompleteView ShopPurchaseCompleteView ShopPurchaseCompleteView Pointer )
            value.Model                                     = GetObject<ShopPurchaseProductModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.ShopPurchaseProductModel.FromPointer); // 0246655AA410 0x68 Model                       ( 00018676FA20 ModelClassType ShopPurchaseProductModel ShopPurchaseProductModel ShopPurchaseProductModel Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchaseCountThisTime                    ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 018 ProductParam                             ModelClassType ShopProductParam ShopProductParam ShopProductParam Pointer
    // 020 HaveFreeJewel                            ModelPrimitiveType long long long Int64
    // 028 HavePaidJewel                            ModelPrimitiveType long long long Int64
    public partial class ShopPurchaseProductModel : DataModel
    {
        public IntReactiveProperty?                     PurchaseCountThisTime                   { get; set; }
        public ShopProductParam?                        ProductParam                            { get; set; }
        public long                                     HaveFreeJewel                           { get; set; }
        public long                                     HavePaidJewel                           { get; set; }

        public static ShopPurchaseProductModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopPurchaseProductModel() { Pointer= p0 };

            value.PurchaseCountThisTime                     = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0x10 PurchaseCountThisTime       ( ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.ProductParam                              = GetObject<ShopProductParam>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShopProductParam.FromPointer); // 0x18 ProductParam                ( ModelClassType ShopProductParam ShopProductParam ShopProductParam Pointer )
            value.HaveFreeJewel                             = GetInt64(new IntPtr(p + 0x020)); // 0x20 HaveFreeJewel               ( ModelPrimitiveType long long long Int64 )
            value.HavePaidJewel                             = GetInt64(new IntPtr(p + 0x028)); // 0x28 HavePaidJewel               ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}

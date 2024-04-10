using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchaseCountThisTime                    000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 018 ProductParam                             00018676A6B0 ModelClassType ShopProductParam ShopProductParam ShopProductParam Pointer
    // 020 HaveFreeJewel                            0001865F7700 ModelPrimitiveType long long long Int64
    // 028 HavePaidJewel                            0001865F7700 ModelPrimitiveType long long long Int64
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

            value.PurchaseCountThisTime                     = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0246655AB340 0x10 PurchaseCountThisTime       ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.ProductParam                              = GetObject<ShopProductParam>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShopProductParam.FromPointer); // 0246655AB360 0x18 ProductParam                ( 00018676A6B0 ModelClassType ShopProductParam ShopProductParam ShopProductParam Pointer )
            value.HaveFreeJewel                             = GetInt64(new IntPtr(p + 0x020)); // 0246655AB380 0x20 HaveFreeJewel               ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.HavePaidJewel                             = GetInt64(new IntPtr(p + 0x028)); // 0246655AB3A0 0x28 HavePaidJewel               ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}

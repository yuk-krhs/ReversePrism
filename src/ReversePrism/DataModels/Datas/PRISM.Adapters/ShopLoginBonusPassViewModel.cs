using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PassProductParam                         ModelClassType ShopProductParam ShopProductParam ShopProductParam Pointer
    // 018 PassProduct                              ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 020 ReceivePurchaseBenefitsViewModel         ModelClassType ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel Pointer
    // 028 Age                                      ModelPrimitiveType int int int Int32
    public partial class ShopLoginBonusPassViewModel : DataModel
    {
        public ShopProductParam?                        PassProductParam                        { get; set; }
        public IProductStatus?                          PassProduct                             { get; set; }
        public ShopReceivePurchaseBenefitsViewModel?    ReceivePurchaseBenefitsViewModel        { get; set; }
        public int                                      Age                                     { get; set; }

        public static ShopLoginBonusPassViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopLoginBonusPassViewModel() { Pointer= p0 };

            value.PassProductParam                          = GetObject<ShopProductParam>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopProductParam.FromPointer); // 0x10 PassProductParam            ( ModelClassType ShopProductParam ShopProductParam ShopProductParam Pointer )
            value.PassProduct                               = GetObject<IProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x18 PassProduct                 ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.ReceivePurchaseBenefitsViewModel          = GetObject<ShopReceivePurchaseBenefitsViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopReceivePurchaseBenefitsViewModel.FromPointer); // 0x20 ReceivePurchaseBenefitsViewModel ( ModelClassType ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel Pointer )
            value.Age                                       = GetInt32(new IntPtr(p + 0x028)); // 0x28 Age                         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

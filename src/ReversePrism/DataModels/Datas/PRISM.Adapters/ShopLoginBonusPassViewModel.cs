using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PassProductParam                         00018676A6B0 ModelClassType ShopProductParam ShopProductParam ShopProductParam Pointer
    // 018 PassProduct                              0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 020 ReceivePurchaseBenefitsViewModel         0001867706A0 ModelClassType ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel Pointer
    // 028 Age                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ShopLoginBonusPassViewModel
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
            var value   = new ShopLoginBonusPassViewModel();

            value.PassProductParam                          = GetObject<ShopProductParam>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopProductParam.FromPointer); // 0270036651C0 0x10 PassProductParam            ( 00018676A6B0 ModelClassType ShopProductParam ShopProductParam ShopProductParam Pointer )
            value.PassProduct                               = GetObject<IProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductStatus.FromPointer); // 0270036651E0 0x18 PassProduct                 ( 0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.ReceivePurchaseBenefitsViewModel          = GetObject<ShopReceivePurchaseBenefitsViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopReceivePurchaseBenefitsViewModel.FromPointer); // 027003665200 0x20 ReceivePurchaseBenefitsViewModel ( 0001867706A0 ModelClassType ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel Pointer )
            value.Age                                       = GetInt32(new IntPtr(p + 0x028)); // 027003665220 0x28 Age                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

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
    // 020 HavingPassProduct                        000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 028 ReceivePurchaseBenefitsViewModel         0001867706A0 ModelClassType ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel Pointer
    // 030 SeasonName                               000186671910 ModelPrimitiveType string string string String
    // 038 SeasonPeriodBeginTimeStr                 000186671910 ModelPrimitiveType string string string String
    // 040 SeasonPeriodEndTimeStr                   000186671910 ModelPrimitiveType string string string String
    // 048 SeasonMissionPlaybleBeginTimeStr         000186671910 ModelPrimitiveType string string string String
    // 050 SeasonMissionPlaybleEndTimeStr           000186671910 ModelPrimitiveType string string string String
    // 058 Age                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ShopSeasonPassViewModel
    {
        public ShopProductParam?                        PassProductParam                        { get; set; }
        public IProductStatus?                          PassProduct                             { get; set; }
        public IHavingProductStatus?                    HavingPassProduct                       { get; set; }
        public ShopReceivePurchaseBenefitsViewModel?    ReceivePurchaseBenefitsViewModel        { get; set; }
        public string                                   SeasonName                              { get; set; }
        public string                                   SeasonPeriodBeginTimeStr                { get; set; }
        public string                                   SeasonPeriodEndTimeStr                  { get; set; }
        public string                                   SeasonMissionPlaybleBeginTimeStr        { get; set; }
        public string                                   SeasonMissionPlaybleEndTimeStr          { get; set; }
        public int                                      Age                                     { get; set; }

        public static ShopSeasonPassViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopSeasonPassViewModel();

            value.PassProductParam                          = GetObject<ShopProductParam>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopProductParam.FromPointer); // 027003665F50 0x10 PassProductParam            ( 00018676A6B0 ModelClassType ShopProductParam ShopProductParam ShopProductParam Pointer )
            value.PassProduct                               = GetObject<IProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductStatus.FromPointer); // 027003665F70 0x18 PassProduct                 ( 0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.HavingPassProduct                         = GetObject<IHavingProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 027003665F90 0x20 HavingPassProduct           ( 000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.ReceivePurchaseBenefitsViewModel          = GetObject<ShopReceivePurchaseBenefitsViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopReceivePurchaseBenefitsViewModel.FromPointer); // 027003665FB0 0x28 ReceivePurchaseBenefitsViewModel ( 0001867706A0 ModelClassType ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel Pointer )
            value.SeasonName                                = GetString(new IntPtr(p + 0x030)); // 027003665FD0 0x30 SeasonName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.SeasonPeriodBeginTimeStr                  = GetString(new IntPtr(p + 0x038)); // 027003665FF0 0x38 SeasonPeriodBeginTimeStr    ( 000186671910 ModelPrimitiveType string string string String )
            value.SeasonPeriodEndTimeStr                    = GetString(new IntPtr(p + 0x040)); // 027003666010 0x40 SeasonPeriodEndTimeStr      ( 000186671910 ModelPrimitiveType string string string String )
            value.SeasonMissionPlaybleBeginTimeStr          = GetString(new IntPtr(p + 0x048)); // 027003666030 0x48 SeasonMissionPlaybleBeginTimeStr ( 000186671910 ModelPrimitiveType string string string String )
            value.SeasonMissionPlaybleEndTimeStr            = GetString(new IntPtr(p + 0x050)); // 027003666050 0x50 SeasonMissionPlaybleEndTimeStr ( 000186671910 ModelPrimitiveType string string string String )
            value.Age                                       = GetInt32(new IntPtr(p + 0x058)); // 027003666070 0x58 Age                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

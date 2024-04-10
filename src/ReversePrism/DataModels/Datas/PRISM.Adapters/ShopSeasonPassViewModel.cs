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
    public partial class ShopSeasonPassViewModel : DataModel
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
            var value   = new ShopSeasonPassViewModel() { Pointer= p0 };

            value.PassProductParam                          = GetObject<ShopProductParam>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopProductParam.FromPointer); // 0245A5B549F0 0x10 PassProductParam            ( 00018676A6B0 ModelClassType ShopProductParam ShopProductParam ShopProductParam Pointer )
            value.PassProduct                               = GetObject<IProductStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductStatus.FromPointer); // 0245A5B54A10 0x18 PassProduct                 ( 0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.HavingPassProduct                         = GetObject<IHavingProductStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0245A5B54A30 0x20 HavingPassProduct           ( 000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.ReceivePurchaseBenefitsViewModel          = GetObject<ShopReceivePurchaseBenefitsViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopReceivePurchaseBenefitsViewModel.FromPointer); // 0245A5B54A50 0x28 ReceivePurchaseBenefitsViewModel ( 0001867706A0 ModelClassType ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel ShopReceivePurchaseBenefitsViewModel Pointer )
            value.SeasonName                                = GetString(new IntPtr(p + 0x030)); // 0245A5B54A70 0x30 SeasonName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.SeasonPeriodBeginTimeStr                  = GetString(new IntPtr(p + 0x038)); // 0245A5B54A90 0x38 SeasonPeriodBeginTimeStr    ( 000186671910 ModelPrimitiveType string string string String )
            value.SeasonPeriodEndTimeStr                    = GetString(new IntPtr(p + 0x040)); // 0245A5B54AB0 0x40 SeasonPeriodEndTimeStr      ( 000186671910 ModelPrimitiveType string string string String )
            value.SeasonMissionPlaybleBeginTimeStr          = GetString(new IntPtr(p + 0x048)); // 0245A5B54AD0 0x48 SeasonMissionPlaybleBeginTimeStr ( 000186671910 ModelPrimitiveType string string string String )
            value.SeasonMissionPlaybleEndTimeStr            = GetString(new IntPtr(p + 0x050)); // 0245A5B54AF0 0x50 SeasonMissionPlaybleEndTimeStr ( 000186671910 ModelPrimitiveType string string string String )
            value.Age                                       = GetInt32(new IntPtr(p + 0x058)); // 0245A5B54B10 0x58 Age                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ExchangeGoodsMaxCount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 ResourceTag                              000186671910 ModelPrimitiveType string string string String
    // 000 ExchangeMinCount                         int IL2CPP_TYPE_I4
    // 000 ExchangeMaxCount                         int IL2CPP_TYPE_I4
    // 000 ExchangeJumpCount                        int IL2CPP_TYPE_I4
    // 020 Group                                    000186769B00 ModelClassType IExchangeGroupStatus IExchangeGroupStatus IExchangeGroupStatus Pointer
    // 028 Goods                                    00018676B4C0 ModelClassType IExchangeProductStatus IExchangeProductStatus IExchangeProductStatus Pointer
    // 030 GoodsProductWithAmount                   0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 038 PurchaseProductWithAmount                0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 040 HavingGoods                              000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 048 HavingPurchaseProduct                    000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 050 PriceRateList                            000185CDAE78 ModelClassListType List`1<ExchangePriceRateClientModel> List`1<ExchangePriceRateClientModel> List<ExchangePriceRateClientModel> Pointer
    public partial class ExchangeGoodsClientModel
    {
        public int                                      ExchangeGoodsMaxCount                   { get; set; }
        public string                                   ResourceTag                             { get; set; }
        public IExchangeGroupStatus?                    Group                                   { get; set; }
        public IExchangeProductStatus?                  Goods                                   { get; set; }
        public IProductWithAmountStatus?                GoodsProductWithAmount                  { get; set; }
        public IProductWithAmountStatus?                PurchaseProductWithAmount               { get; set; }
        public IHavingProductStatus?                    HavingGoods                             { get; set; }
        public IHavingProductStatus?                    HavingPurchaseProduct                   { get; set; }
        public List<ExchangePriceRateClientModel>?      PriceRateList                           { get; set; }

        public static ExchangeGoodsClientModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeGoodsClientModel();

            value.ExchangeGoodsMaxCount                     = GetInt32(new IntPtr(p + 0x010)); // 0270D54B5510 0x10 ExchangeGoodsMaxCount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResourceTag                               = GetString(new IntPtr(p + 0x018)); // 0270D54B5530 0x18 ResourceTag                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Group                                     = GetObject<IExchangeGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IExchangeGroupStatus.FromPointer); // 0270D54B55B0 0x20 Group                       ( 000186769B00 ModelClassType IExchangeGroupStatus IExchangeGroupStatus IExchangeGroupStatus Pointer )
            value.Goods                                     = GetObject<IExchangeProductStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IExchangeProductStatus.FromPointer); // 0270D54B55D0 0x28 Goods                       ( 00018676B4C0 ModelClassType IExchangeProductStatus IExchangeProductStatus IExchangeProductStatus Pointer )
            value.GoodsProductWithAmount                    = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D54B55F0 0x30 GoodsProductWithAmount      ( 0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.PurchaseProductWithAmount                 = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D54B5610 0x38 PurchaseProductWithAmount   ( 0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.HavingGoods                               = GetObject<IHavingProductStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0270D54B5630 0x40 HavingGoods                 ( 000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.HavingPurchaseProduct                     = GetObject<IHavingProductStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0270D54B5650 0x48 HavingPurchaseProduct       ( 000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.PriceRateList                             = GetObjectList<ExchangePriceRateClientModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExchangePriceRateClientModel.FromPointer); // 0270D54B5670 0x50 PriceRateList               ( 000185CDAE78 ModelClassListType List`1<ExchangePriceRateClientModel> List`1<ExchangePriceRateClientModel> List<ExchangePriceRateClientModel> Pointer )

            return value;
        }
    }
}

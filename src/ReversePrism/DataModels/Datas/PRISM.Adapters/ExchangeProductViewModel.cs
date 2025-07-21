using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ExchangeMinCount                         int IL2CPP_TYPE_I4
    // 000 ExchangeMaxCount                         int IL2CPP_TYPE_I4
    // 010 ExchangeGoodsMaxCount                    ModelPrimitiveType int int int Int32
    // 014 IsNewProduct                             ModelPrimitiveType bool bool bool Bool
    // 018 CurrentCount                             ModelPrimitiveType int int int Int32
    // 020 Goods                                    ModelClassType ExchangeShinyPartyProductViewModel ExchangeShinyPartyProductViewModel ExchangeShinyPartyProductViewModel Pointer
    // 028 GoodsProductWithAmount                   ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 030 PurchaseProductWithAmount                ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 038 HavingGoods                              ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 040 HavingPurchaseProduct                    ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 048 PriceRateList                            ModelClassListType List`1<ExchangePriceRateClientModel> List`1<ExchangePriceRateClientModel> List<ExchangePriceRateClientModel> Pointer
    public partial class ExchangeProductViewModel : DataModel
    {
        public int                                      ExchangeGoodsMaxCount                   { get; set; }
        public bool                                     IsNewProduct                            { get; set; }
        public int                                      CurrentCount                            { get; set; }
        public ExchangeShinyPartyProductViewModel?      Goods                                   { get; set; }
        public IProductWithAmountStatus?                GoodsProductWithAmount                  { get; set; }
        public IProductWithAmountStatus?                PurchaseProductWithAmount               { get; set; }
        public IHavingProductStatus?                    HavingGoods                             { get; set; }
        public IHavingProductStatus?                    HavingPurchaseProduct                   { get; set; }
        public List<ExchangePriceRateClientModel>?      PriceRateList                           { get; set; }

        public static ExchangeProductViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeProductViewModel() { Pointer= p0 };

            value.ExchangeGoodsMaxCount                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 ExchangeGoodsMaxCount       ( ModelPrimitiveType int int int Int32 )
            value.IsNewProduct                              = GetBool(new IntPtr(p + 0x014)); // 0x14 IsNewProduct                ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentCount                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 CurrentCount                ( ModelPrimitiveType int int int Int32 )
            value.Goods                                     = GetObject<ExchangeShinyPartyProductViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExchangeShinyPartyProductViewModel.FromPointer); // 0x20 Goods                       ( ModelClassType ExchangeShinyPartyProductViewModel ExchangeShinyPartyProductViewModel ExchangeShinyPartyProductViewModel Pointer )
            value.GoodsProductWithAmount                    = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x28 GoodsProductWithAmount      ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.PurchaseProductWithAmount                 = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x30 PurchaseProductWithAmount   ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.HavingGoods                               = GetObject<IHavingProductStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0x38 HavingGoods                 ( ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.HavingPurchaseProduct                     = GetObject<IHavingProductStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0x40 HavingPurchaseProduct       ( ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.PriceRateList                             = GetObjectList<ExchangePriceRateClientModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExchangePriceRateClientModel.FromPointer); // 0x48 PriceRateList               ( ModelClassListType List`1<ExchangePriceRateClientModel> List`1<ExchangePriceRateClientModel> List<ExchangePriceRateClientModel> Pointer )

            return value;
        }
    }
}

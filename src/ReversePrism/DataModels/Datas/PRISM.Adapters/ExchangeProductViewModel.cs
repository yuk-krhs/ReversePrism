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
    // 010 ExchangeGoodsMaxCount                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 IsNewProduct                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 CurrentCount                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Goods                                    00018651BE90 ModelClassType ExchangeShinyPartyProductViewModel ExchangeShinyPartyProductViewModel ExchangeShinyPartyProductViewModel Pointer
    // 028 GoodsProductWithAmount                   0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 030 PurchaseProductWithAmount                0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 038 HavingGoods                              000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 040 HavingPurchaseProduct                    000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 048 PriceRateList                            000185CDAE78 ModelClassListType List`1<ExchangePriceRateClientModel> List`1<ExchangePriceRateClientModel> List<ExchangePriceRateClientModel> Pointer
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

            value.ExchangeGoodsMaxCount                     = GetInt32(new IntPtr(p + 0x010)); // 024666352D20 0x10 ExchangeGoodsMaxCount       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsNewProduct                              = GetBool(new IntPtr(p + 0x014)); // 024666352D40 0x14 IsNewProduct                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentCount                              = GetInt32(new IntPtr(p + 0x018)); // 024666352D60 0x18 CurrentCount                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Goods                                     = GetObject<ExchangeShinyPartyProductViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ExchangeShinyPartyProductViewModel.FromPointer); // 024666352D80 0x20 Goods                       ( 00018651BE90 ModelClassType ExchangeShinyPartyProductViewModel ExchangeShinyPartyProductViewModel ExchangeShinyPartyProductViewModel Pointer )
            value.GoodsProductWithAmount                    = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 024666352DA0 0x28 GoodsProductWithAmount      ( 0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.PurchaseProductWithAmount                 = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 024666352DC0 0x30 PurchaseProductWithAmount   ( 0001865F9F40 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.HavingGoods                               = GetObject<IHavingProductStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 024666352DE0 0x38 HavingGoods                 ( 000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.HavingPurchaseProduct                     = GetObject<IHavingProductStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 024666352E00 0x40 HavingPurchaseProduct       ( 000186565CA0 ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.PriceRateList                             = GetObjectList<ExchangePriceRateClientModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExchangePriceRateClientModel.FromPointer); // 024666352E20 0x48 PriceRateList               ( 000185CDAE78 ModelClassListType List`1<ExchangePriceRateClientModel> List`1<ExchangePriceRateClientModel> List<ExchangePriceRateClientModel> Pointer )

            return value;
        }
    }
}

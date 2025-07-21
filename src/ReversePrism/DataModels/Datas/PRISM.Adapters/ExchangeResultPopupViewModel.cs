using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GoodsModel                               ModelClassType ExchangeProductViewModel ExchangeProductViewModel ExchangeProductViewModel Pointer
    // 018 ExchangeCount                            ModelPrimitiveType int int int Int32
    // 01C IsGoToButtonActive                       ModelPrimitiveType bool bool bool Bool
    // 020 PieceCharaID                             ModelPrimitiveType int int int Int32
    // 028 BeforePurchaseProductAmount              ModelPrimitiveType long long long Int64
    // 030 AfterPurchaseProductAmount               ModelPrimitiveType long long long Int64
    // 038 BeforeGoodsAmount                        ModelPrimitiveType long long long Int64
    // 040 AfterGoodsAmount                         ModelPrimitiveType long long long Int64
    // 048 BeforeExchangeLimit                      ModelPrimitiveType int int int Int32
    // 04C AfterExchangeLimit                       ModelPrimitiveType int int int Int32
    // 050 GoodsProduct                             ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 058 ConvertProduct                           ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 060 RequireProduct                           ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 068 LimitStatus                              ModelClassType IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus Pointer
    public partial class ExchangeResultPopupViewModel : DataModel
    {
        public ExchangeProductViewModel?                GoodsModel                              { get; set; }
        public int                                      ExchangeCount                           { get; set; }
        public bool                                     IsGoToButtonActive                      { get; set; }
        public int                                      PieceCharaID                            { get; set; }
        public long                                     BeforePurchaseProductAmount             { get; set; }
        public long                                     AfterPurchaseProductAmount              { get; set; }
        public long                                     BeforeGoodsAmount                       { get; set; }
        public long                                     AfterGoodsAmount                        { get; set; }
        public int                                      BeforeExchangeLimit                     { get; set; }
        public int                                      AfterExchangeLimit                      { get; set; }
        public IProductWithAmountStatus?                GoodsProduct                            { get; set; }
        public IProductWithAmountStatus?                ConvertProduct                          { get; set; }
        public IProductWithAmountStatus?                RequireProduct                          { get; set; }
        public IExchangeProductPurchaseLimitStatus?     LimitStatus                             { get; set; }

        public static ExchangeResultPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeResultPopupViewModel() { Pointer= p0 };

            value.GoodsModel                                = GetObject<ExchangeProductViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExchangeProductViewModel.FromPointer); // 0x10 GoodsModel                  ( ModelClassType ExchangeProductViewModel ExchangeProductViewModel ExchangeProductViewModel Pointer )
            value.ExchangeCount                             = GetInt32(new IntPtr(p + 0x018)); // 0x18 ExchangeCount               ( ModelPrimitiveType int int int Int32 )
            value.IsGoToButtonActive                        = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsGoToButtonActive          ( ModelPrimitiveType bool bool bool Bool )
            value.PieceCharaID                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 PieceCharaID                ( ModelPrimitiveType int int int Int32 )
            value.BeforePurchaseProductAmount               = GetInt64(new IntPtr(p + 0x028)); // 0x28 BeforePurchaseProductAmount ( ModelPrimitiveType long long long Int64 )
            value.AfterPurchaseProductAmount                = GetInt64(new IntPtr(p + 0x030)); // 0x30 AfterPurchaseProductAmount  ( ModelPrimitiveType long long long Int64 )
            value.BeforeGoodsAmount                         = GetInt64(new IntPtr(p + 0x038)); // 0x38 BeforeGoodsAmount           ( ModelPrimitiveType long long long Int64 )
            value.AfterGoodsAmount                          = GetInt64(new IntPtr(p + 0x040)); // 0x40 AfterGoodsAmount            ( ModelPrimitiveType long long long Int64 )
            value.BeforeExchangeLimit                       = GetInt32(new IntPtr(p + 0x048)); // 0x48 BeforeExchangeLimit         ( ModelPrimitiveType int int int Int32 )
            value.AfterExchangeLimit                        = GetInt32(new IntPtr(p + 0x04C)); // 0x4C AfterExchangeLimit          ( ModelPrimitiveType int int int Int32 )
            value.GoodsProduct                              = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x50 GoodsProduct                ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.ConvertProduct                            = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x58 ConvertProduct              ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.RequireProduct                            = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x60 RequireProduct              ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.LimitStatus                               = GetObject<IExchangeProductPurchaseLimitStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IExchangeProductPurchaseLimitStatus.FromPointer); // 0x68 LimitStatus                 ( ModelClassType IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus Pointer )

            return value;
        }
    }
}

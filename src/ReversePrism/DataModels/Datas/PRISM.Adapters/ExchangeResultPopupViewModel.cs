using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GoodsModel                               0001865146E0 ModelClassType ExchangeProductViewModel ExchangeProductViewModel ExchangeProductViewModel Pointer
    // 018 ExchangeCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C IsGoToButtonActive                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 PieceCharaID                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 BeforePurchaseProductAmount              0001865F7700 ModelPrimitiveType long long long Int64
    // 030 AfterPurchaseProductAmount               0001865F7700 ModelPrimitiveType long long long Int64
    // 038 BeforeGoodsAmount                        0001865F7700 ModelPrimitiveType long long long Int64
    // 040 AfterGoodsAmount                         0001865F7700 ModelPrimitiveType long long long Int64
    // 048 BeforeExchangeLimit                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C AfterExchangeLimit                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 GoodsProduct                             0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 058 ConvertProduct                           0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 060 RequireProduct                           0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 068 LimitStatus                              00018676AFA0 ModelClassType IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus Pointer
    public partial class ExchangeResultPopupViewModel
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
            var value   = new ExchangeResultPopupViewModel();

            value.GoodsModel                                = GetObject<ExchangeProductViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExchangeProductViewModel.FromPointer); // 0270D62BA6D0 0x10 GoodsModel                  ( 0001865146E0 ModelClassType ExchangeProductViewModel ExchangeProductViewModel ExchangeProductViewModel Pointer )
            value.ExchangeCount                             = GetInt32(new IntPtr(p + 0x018)); // 0270D62BA6F0 0x18 ExchangeCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsGoToButtonActive                        = GetBool(new IntPtr(p + 0x01C)); // 0270D62BA710 0x1C IsGoToButtonActive          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PieceCharaID                              = GetInt32(new IntPtr(p + 0x020)); // 0270D62BA730 0x20 PieceCharaID                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BeforePurchaseProductAmount               = GetInt64(new IntPtr(p + 0x028)); // 0270D62BA750 0x28 BeforePurchaseProductAmount ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.AfterPurchaseProductAmount                = GetInt64(new IntPtr(p + 0x030)); // 0270D62BA770 0x30 AfterPurchaseProductAmount  ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.BeforeGoodsAmount                         = GetInt64(new IntPtr(p + 0x038)); // 0270D62BA790 0x38 BeforeGoodsAmount           ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.AfterGoodsAmount                          = GetInt64(new IntPtr(p + 0x040)); // 0270D62BA7B0 0x40 AfterGoodsAmount            ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.BeforeExchangeLimit                       = GetInt32(new IntPtr(p + 0x048)); // 0270D62BA7D0 0x48 BeforeExchangeLimit         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AfterExchangeLimit                        = GetInt32(new IntPtr(p + 0x04C)); // 0270D62BA7F0 0x4C AfterExchangeLimit          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GoodsProduct                              = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D62BA810 0x50 GoodsProduct                ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.ConvertProduct                            = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D62BA830 0x58 ConvertProduct              ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.RequireProduct                            = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x060), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D62BA850 0x60 RequireProduct              ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.LimitStatus                               = GetObject<IExchangeProductPurchaseLimitStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IExchangeProductPurchaseLimitStatus.FromPointer); // 0270D62BA870 0x68 LimitStatus                 ( 00018676AFA0 ModelClassType IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus Pointer )

            return value;
        }
    }
}

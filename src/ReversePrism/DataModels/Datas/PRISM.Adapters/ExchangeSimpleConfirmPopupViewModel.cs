using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ExchangeCautionTextKey                   int IL2CPP_TYPE_I4
    // 000 CautionIdolTextKey                       int IL2CPP_TYPE_I4
    // 000 CautionCharacterTextKey                  int IL2CPP_TYPE_I4
    // 010 ExchangeMstId                            ModelPrimitiveType int int int Int32
    // 018 ExchangeProduct                          ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 020 RequireProduct                           ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 028 LimitStatus                              ModelClassType IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus Pointer
    // 030 RequireProductBaseAmount                 ModelPrimitiveType int int int Int32
    // 034 ExchangeLimitReaminCount                 ModelPrimitiveType int int int Int32
    // 038 ExchangeCount                            ModelPrimitiveType int int int Int32
    public partial class ExchangeSimpleConfirmPopupViewModel : DataModel
    {
        public int                                      ExchangeMstId                           { get; set; }
        public IProductWithAmountStatus?                ExchangeProduct                         { get; set; }
        public IProductWithAmountStatus?                RequireProduct                          { get; set; }
        public IExchangeProductPurchaseLimitStatus?     LimitStatus                             { get; set; }
        public int                                      RequireProductBaseAmount                { get; set; }
        public int                                      ExchangeLimitReaminCount                { get; set; }
        public int                                      ExchangeCount                           { get; set; }

        public static ExchangeSimpleConfirmPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeSimpleConfirmPopupViewModel() { Pointer= p0 };

            value.ExchangeMstId                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 ExchangeMstId               ( ModelPrimitiveType int int int Int32 )
            value.ExchangeProduct                           = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x18 ExchangeProduct             ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.RequireProduct                            = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x20 RequireProduct              ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.LimitStatus                               = GetObject<IExchangeProductPurchaseLimitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IExchangeProductPurchaseLimitStatus.FromPointer); // 0x28 LimitStatus                 ( ModelClassType IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus Pointer )
            value.RequireProductBaseAmount                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 RequireProductBaseAmount    ( ModelPrimitiveType int int int Int32 )
            value.ExchangeLimitReaminCount                  = GetInt32(new IntPtr(p + 0x034)); // 0x34 ExchangeLimitReaminCount    ( ModelPrimitiveType int int int Int32 )
            value.ExchangeCount                             = GetInt32(new IntPtr(p + 0x038)); // 0x38 ExchangeCount               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

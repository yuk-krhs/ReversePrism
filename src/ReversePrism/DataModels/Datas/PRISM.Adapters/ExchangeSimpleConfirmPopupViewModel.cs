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
    // 010 ExchangeMstId                            0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ExchangeProduct                          0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 020 RequireProduct                           0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 028 LimitStatus                              00018676AFA0 ModelClassType IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus Pointer
    // 030 RequireProductBaseAmount                 0001865F4260 ModelPrimitiveType int int int Int32
    // 034 ExchangeLimitReaminCount                 0001865F4260 ModelPrimitiveType int int int Int32
    // 038 ExchangeCount                            0001865F4260 ModelPrimitiveType int int int Int32
    public partial class ExchangeSimpleConfirmPopupViewModel
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
            var value   = new ExchangeSimpleConfirmPopupViewModel();

            value.ExchangeMstId                             = GetInt32(new IntPtr(p + 0x010)); // 0270D62B99A8 0x10 ExchangeMstId               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ExchangeProduct                           = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D62B99C8 0x18 ExchangeProduct             ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.RequireProduct                            = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D62B99E8 0x20 RequireProduct              ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.LimitStatus                               = GetObject<IExchangeProductPurchaseLimitStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IExchangeProductPurchaseLimitStatus.FromPointer); // 0270D62B9A08 0x28 LimitStatus                 ( 00018676AFA0 ModelClassType IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus Pointer )
            value.RequireProductBaseAmount                  = GetInt32(new IntPtr(p + 0x030)); // 0270D62B9A28 0x30 RequireProductBaseAmount    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ExchangeLimitReaminCount                  = GetInt32(new IntPtr(p + 0x034)); // 0270D62B9A48 0x34 ExchangeLimitReaminCount    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ExchangeCount                             = GetInt32(new IntPtr(p + 0x038)); // 0270D62B9A68 0x38 ExchangeCount               ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

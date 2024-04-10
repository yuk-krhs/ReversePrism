using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstShinyPartyTokenProductId              0001865F4260 ModelPrimitiveType int int int Int32
    // 018 ProductWithAmount                        0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 020 PurchaseLimit                            00018676AD00 ModelClassType IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus Pointer
    // 028 MstPriceRateList                         000185CE31D8 ModelClassListType List`1<IExchangeProductPriceRateStatus> List`1<IExchangeProductPriceRateStatus> List<IExchangeProductPriceRateStatus> Pointer
    // 030 TotalPurchaseCount                       0001865F4260 ModelPrimitiveType int int int Int32
    // 038 BeginDate                                000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 048 EndDate                                  000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 058 SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 05C MstExchangeProductFilterId               0001865F4260 ModelPrimitiveType int int int Int32
    public partial class ExchangeShinyPartyProductViewModel : DataModel
    {
        public int                                      MstShinyPartyTokenProductId             { get; set; }
        public IProductWithAmountStatus?                ProductWithAmount                       { get; set; }
        public IExchangeProductPurchaseLimitStatus?     PurchaseLimit                           { get; set; }
        public List<IExchangeProductPriceRateStatus>?   MstPriceRateList                        { get; set; }
        public int                                      TotalPurchaseCount                      { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      SortId                                  { get; set; }
        public int                                      MstExchangeProductFilterId              { get; set; }

        public static ExchangeShinyPartyProductViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeShinyPartyProductViewModel() { Pointer= p0 };

            value.MstShinyPartyTokenProductId               = GetInt32(new IntPtr(p + 0x010)); // 02466635F948 0x10 MstShinyPartyTokenProductId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ProductWithAmount                         = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 02466635F968 0x18 ProductWithAmount           ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.PurchaseLimit                             = GetObject<IExchangeProductPurchaseLimitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IExchangeProductPurchaseLimitStatus.FromPointer); // 02466635F988 0x20 PurchaseLimit               ( 00018676AD00 ModelClassType IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus Pointer )
            value.MstPriceRateList                          = GetObjectList<IExchangeProductPriceRateStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IExchangeProductPriceRateStatus.FromPointer); // 02466635F9A8 0x28 MstPriceRateList            ( 000185CE31D8 ModelClassListType List`1<IExchangeProductPriceRateStatus> List`1<IExchangeProductPriceRateStatus> List<IExchangeProductPriceRateStatus> Pointer )
            value.TotalPurchaseCount                        = GetInt32(new IntPtr(p + 0x030)); // 02466635F9C8 0x30 TotalPurchaseCount          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x038)); // 02466635F9E8 0x38 BeginDate                   ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x048)); // 02466635FA08 0x48 EndDate                     ( 000185D00B98 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x058)); // 02466635FA28 0x58 SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstExchangeProductFilterId                = GetInt32(new IntPtr(p + 0x05C)); // 02466635FA48 0x5C MstExchangeProductFilterId  ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstShinyPartyTokenProductId              ModelPrimitiveType int int int Int32
    // 018 ProductWithAmount                        ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 020 PurchaseLimit                            ModelClassType IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus Pointer
    // 028 MstPriceRateList                         ModelClassListType List`1<IExchangeProductPriceRateStatus> List`1<IExchangeProductPriceRateStatus> List<IExchangeProductPriceRateStatus> Pointer
    // 030 TotalPurchaseCount                       ModelPrimitiveType int int int Int32
    // 038 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 048 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 058 SortId                                   ModelPrimitiveType int int int Int32
    // 05C MstExchangeProductFilterId               ModelPrimitiveType int int int Int32
    // 060 IsAlreadyHaving                          ModelPrimitiveType bool bool bool Bool
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
        public bool                                     IsAlreadyHaving                         { get; set; }

        public static ExchangeShinyPartyProductViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeShinyPartyProductViewModel() { Pointer= p0 };

            value.MstShinyPartyTokenProductId               = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstShinyPartyTokenProductId ( ModelPrimitiveType int int int Int32 )
            value.ProductWithAmount                         = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x18 ProductWithAmount           ( ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.PurchaseLimit                             = GetObject<IExchangeProductPurchaseLimitStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IExchangeProductPurchaseLimitStatus.FromPointer); // 0x20 PurchaseLimit               ( ModelClassType IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus IExchangeProductPurchaseLimitStatus Pointer )
            value.MstPriceRateList                          = GetObjectList<IExchangeProductPriceRateStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IExchangeProductPriceRateStatus.FromPointer); // 0x28 MstPriceRateList            ( ModelClassListType List`1<IExchangeProductPriceRateStatus> List`1<IExchangeProductPriceRateStatus> List<IExchangeProductPriceRateStatus> Pointer )
            value.TotalPurchaseCount                        = GetInt32(new IntPtr(p + 0x030)); // 0x30 TotalPurchaseCount          ( ModelPrimitiveType int int int Int32 )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x038)); // 0x38 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x048)); // 0x48 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x058)); // 0x58 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.MstExchangeProductFilterId                = GetInt32(new IntPtr(p + 0x05C)); // 0x5C MstExchangeProductFilterId  ( ModelPrimitiveType int int int Int32 )
            value.IsAlreadyHaving                           = GetBool(new IntPtr(p + 0x060)); // 0x60 IsAlreadyHaving             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

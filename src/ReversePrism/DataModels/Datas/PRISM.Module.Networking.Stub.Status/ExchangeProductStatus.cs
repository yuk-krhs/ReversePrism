using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ExchangeProductStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstExchangeProductIdFieldNumber          int IL2CPP_TYPE_I4
    // 038 MstExchangeProductId                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProductWithAmountFieldNumber             int IL2CPP_TYPE_I4
    // 040 ProductWithAmount                        0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 PurchaseLimitFieldNumber                 int IL2CPP_TYPE_I4
    // 048 PurchaseLimit                            0001865131D0 ModelClassType ExchangeProductPurchaseLimitStatus ExchangeProductPurchaseLimitStatus ExchangeProductPurchaseLimitStatus Pointer
    // 000 PriceRateListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_priceRateList_codec            FieldCodec`1<ExchangeProductPriceRateStatus> IL2CPP_TYPE_GENERICINST
    // 050 PriceRateList                            000185CD6668 ModelClassListType RepeatedField`1<ExchangeProductPriceRateStatus> RepeatedField`1<ExchangeProductPriceRateStatus> List<ExchangeProductPriceRateStatus> Pointer
    // 000 TotalPurchaseCountFieldNumber            int IL2CPP_TYPE_I4
    // 058 TotalPurchaseCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 060 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 068 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 070 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstExchangeProductFilterIdFieldNumber    int IL2CPP_TYPE_I4
    // 074 MstExchangeProductFilterId               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 078 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ExchangeProductStatus
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      MstExchangeProductId                    { get; set; }
        public ProductWithAmountStatus?                 ProductWithAmount                       { get; set; }
        public ExchangeProductPurchaseLimitStatus?      PurchaseLimit                           { get; set; }
        public List<ExchangeProductPriceRateStatus>?    PriceRateList                           { get; set; }
        public int                                      TotalPurchaseCount                      { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public int                                      SortId                                  { get; set; }
        public int                                      MstExchangeProductFilterId              { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }

        public static ExchangeProductStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeProductStatus();

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0270D122A370 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0270D122A390 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstExchangeProductId                      = GetInt32(new IntPtr(p + 0x038)); // 0270D122A410 0x38 MstExchangeProductId        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProductWithAmount                         = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D122A450 0x40 ProductWithAmount           ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.PurchaseLimit                             = GetObject<ExchangeProductPurchaseLimitStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ExchangeProductPurchaseLimitStatus.FromPointer); // 0270D122A490 0x48 PurchaseLimit               ( 0001865131D0 ModelClassType ExchangeProductPurchaseLimitStatus ExchangeProductPurchaseLimitStatus ExchangeProductPurchaseLimitStatus Pointer )
            value.PriceRateList                             = GetObjectList<ExchangeProductPriceRateStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ExchangeProductPriceRateStatus.FromPointer); // 0270D122A4F0 0x50 PriceRateList               ( 000185CD6668 ModelClassListType RepeatedField`1<ExchangeProductPriceRateStatus> RepeatedField`1<ExchangeProductPriceRateStatus> List<ExchangeProductPriceRateStatus> Pointer )
            value.TotalPurchaseCount                        = GetInt32(new IntPtr(p + 0x058)); // 0270D122A530 0x58 TotalPurchaseCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x060), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D122A570 0x60 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x068), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D122A5B0 0x68 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x070)); // 0270D122A5F0 0x70 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstExchangeProductFilterId                = GetInt32(new IntPtr(p + 0x074)); // 0270D122A630 0x74 MstExchangeProductFilterId  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x078)); // 0270D122A670 0x78 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchaseDate                             000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ExchangePurchaseHistoryStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstExchangeGroupIdFieldNumber            int IL2CPP_TYPE_I4
    // 028 MstExchangeGroupId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstExchangeProductIdFieldNumber          int IL2CPP_TYPE_I4
    // 02C MstExchangeProductId                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PriceProductFieldNumber                  int IL2CPP_TYPE_I4
    // 030 PriceProduct                             0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 ContentProductFieldNumber                int IL2CPP_TYPE_I4
    // 038 ContentProduct                           0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 PurchaseDateFieldNumber                  int IL2CPP_TYPE_I4
    // 040 _PurchaseDate                            000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 MstSelectionTicketProductIdFieldNumber   int IL2CPP_TYPE_I4
    // 048 MstSelectionTicketProductId              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ContentDetailProductListFieldNumber      int IL2CPP_TYPE_I4
    // 008 _repeated_contentDetailProductList_codec FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 050 ContentDetailProductList                 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 AmountFieldNumber                        int IL2CPP_TYPE_I4
    // 058 Amount                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ExchangePurchaseHistoryStatus
    {
        public DateTime                                 PurchaseDate                            { get; set; }
        public int                                      MstExchangeGroupId                      { get; set; }
        public int                                      MstExchangeProductId                    { get; set; }
        public ProductWithAmountStatus?                 PriceProduct                            { get; set; }
        public ProductWithAmountStatus?                 ContentProduct                          { get; set; }
        public Timestamp?                               _PurchaseDate                           { get; set; }
        public int                                      MstSelectionTicketProductId             { get; set; }
        public List<ProductWithAmountStatus>?           ContentDetailProductList                { get; set; }
        public int                                      Amount                                  { get; set; }

        public static ExchangePurchaseHistoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangePurchaseHistoryStatus();

            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x010)); // 0270D1230E98 0x10 PurchaseDate                ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstExchangeGroupId                        = GetInt32(new IntPtr(p + 0x028)); // 0270D1230F18 0x28 MstExchangeGroupId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstExchangeProductId                      = GetInt32(new IntPtr(p + 0x02C)); // 0270D1230F58 0x2C MstExchangeProductId        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PriceProduct                              = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D1230F98 0x30 PriceProduct                ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.ContentProduct                            = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D1230FD8 0x38 ContentProduct              ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value._PurchaseDate                             = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D1231018 0x40 _PurchaseDate               ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.MstSelectionTicketProductId               = GetInt32(new IntPtr(p + 0x048)); // 0270D1231058 0x48 MstSelectionTicketProductId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ContentDetailProductList                  = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D12310B8 0x50 ContentDetailProductList    ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.Amount                                    = GetInt32(new IntPtr(p + 0x058)); // 0270D12310F8 0x58 Amount                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PurchaseDate                  = ToDateTime(value._PurchaseDate);

            return value;
        }
    }
}

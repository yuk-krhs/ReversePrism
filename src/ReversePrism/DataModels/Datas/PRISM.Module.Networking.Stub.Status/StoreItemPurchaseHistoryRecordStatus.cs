using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchaseDate                             ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<StoreItemPurchaseHistoryRecordStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstStoreItemIdFieldNumber                int IL2CPP_TYPE_I4
    // 028 MstStoreItemId                           ModelPrimitiveType int int int Int32
    // 000 PriceFieldNumber                         int IL2CPP_TYPE_I4
    // 02C Price                                    ModelPrimitiveType int int int Int32
    // 000 BonusProductListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_bonusProductList_codec         FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 030 BonusProductList                         ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 PurchaseDateFieldNumber                  int IL2CPP_TYPE_I4
    // 038 _PurchaseDate                            ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 PurchaseAmountFieldNumber                int IL2CPP_TYPE_I4
    // 040 PurchaseAmount                           ModelPrimitiveType int int int Int32
    // 000 ContentProductListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_contentProductList_codec       FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 048 ContentProductList                       ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    public partial class StoreItemPurchaseHistoryRecordStatus : DataModel
    {
        public DateTime                                 PurchaseDate                            { get; set; }
        public int                                      MstStoreItemId                          { get; set; }
        public int                                      Price                                   { get; set; }
        public List<ProductWithAmountStatus>?           BonusProductList                        { get; set; }
        public Timestamp?                               _PurchaseDate                           { get; set; }
        public int                                      PurchaseAmount                          { get; set; }
        public List<ProductWithAmountStatus>?           ContentProductList                      { get; set; }

        public static StoreItemPurchaseHistoryRecordStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoreItemPurchaseHistoryRecordStatus() { Pointer= p0 };

            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x010)); // 0x10 PurchaseDate                ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstStoreItemId                            = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstStoreItemId              ( ModelPrimitiveType int int int Int32 )
            value.Price                                     = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Price                       ( ModelPrimitiveType int int int Int32 )
            value.BonusProductList                          = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x30 BonusProductList            ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value._PurchaseDate                             = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0x38 _PurchaseDate               ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PurchaseAmount                            = GetInt32(new IntPtr(p + 0x040)); // 0x40 PurchaseAmount              ( ModelPrimitiveType int int int Int32 )
            value.ContentProductList                        = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x48 ContentProductList          ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.PurchaseDate                  = ToDateTime(value._PurchaseDate);

            return value;
        }
    }
}

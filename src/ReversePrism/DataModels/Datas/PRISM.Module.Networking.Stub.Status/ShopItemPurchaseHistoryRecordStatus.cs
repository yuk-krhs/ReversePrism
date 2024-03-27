using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PurchaseDate                             000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<ShopItemPurchaseHistoryRecordStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstShopItemIdFieldNumber                 int IL2CPP_TYPE_I4
    // 028 MstShopItemId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PriceProductListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_priceProductList_codec         FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 030 PriceProductList                         000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 ContentProductListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_contentProductList_codec       FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 038 ContentProductList                       000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 BonusProductListFieldNumber              int IL2CPP_TYPE_I4
    // 018 _repeated_bonusProductList_codec         FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 040 BonusProductList                         000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 PurchaseDateFieldNumber                  int IL2CPP_TYPE_I4
    // 048 _PurchaseDate                            000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 PurchaseAmountFieldNumber                int IL2CPP_TYPE_I4
    // 050 PurchaseAmount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ShopItemPurchaseHistoryRecordStatus
    {
        public DateTime                                 PurchaseDate                            { get; set; }
        public int                                      MstShopItemId                           { get; set; }
        public List<ProductWithAmountStatus>?           PriceProductList                        { get; set; }
        public List<ProductWithAmountStatus>?           ContentProductList                      { get; set; }
        public List<ProductWithAmountStatus>?           BonusProductList                        { get; set; }
        public Timestamp?                               _PurchaseDate                           { get; set; }
        public int                                      PurchaseAmount                          { get; set; }

        public static ShopItemPurchaseHistoryRecordStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopItemPurchaseHistoryRecordStatus();

            value.PurchaseDate                              = GetDateTime(new IntPtr(p + 0x010)); // 0270D2808A50 0x10 PurchaseDate                ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstShopItemId                             = GetInt32(new IntPtr(p + 0x028)); // 0270D2808AD0 0x28 MstShopItemId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PriceProductList                          = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D2808B30 0x30 PriceProductList            ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.ContentProductList                        = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D2808B90 0x38 ContentProductList          ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.BonusProductList                          = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D2808BF0 0x40 BonusProductList            ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value._PurchaseDate                             = GetObject<Timestamp>(new IntPtr(p + 0x048), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D2808C30 0x48 _PurchaseDate               ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.PurchaseAmount                            = GetInt32(new IntPtr(p + 0x050)); // 0270D2808C70 0x50 PurchaseAmount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PurchaseDate                  = ToDateTime(value._PurchaseDate);

            return value;
        }
    }
}

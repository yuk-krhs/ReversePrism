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
    // 000 _parser                                  MessageParser`1<StoreItemStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstStoreItemIdFieldNumber                int IL2CPP_TYPE_I4
    // 038 MstStoreItemId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 StoreProductIdFieldNumber                int IL2CPP_TYPE_I4
    // 040 StoreProductId                           000186671910 ModelPrimitiveType string string string String
    // 000 PurchaseLimitFieldNumber                 int IL2CPP_TYPE_I4
    // 048 PurchaseLimit                            0001865DD320 ModelClassType PurchaseLimitStatus PurchaseLimitStatus PurchaseLimitStatus Pointer
    // 000 PriceFieldNumber                         int IL2CPP_TYPE_I4
    // 050 Price                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 BonusProductListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_bonusProductList_codec         FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 058 BonusProductList                         000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 060 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 068 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ContentProductListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_contentProductList_codec       FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 070 ContentProductList                       000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 ShopItemTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 078 ShopItemType                             000186761B60 ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 000 DisplayOrderFieldNumber                  int IL2CPP_TYPE_I4
    // 07C DisplayOrder                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class StoreItemStatus : DataModel
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      MstStoreItemId                          { get; set; }
        public string                                   StoreProductId                          { get; set; }
        public PurchaseLimitStatus?                     PurchaseLimit                           { get; set; }
        public int                                      Price                                   { get; set; }
        public List<ProductWithAmountStatus>?           BonusProductList                        { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public List<ProductWithAmountStatus>?           ContentProductList                      { get; set; }
        public ShopItemType                             ShopItemType                            { get; set; }
        public int                                      DisplayOrder                            { get; set; }

        public static StoreItemStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoreItemStatus() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 024660EFCBA8 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 024660EFCBC8 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstStoreItemId                            = GetInt32(new IntPtr(p + 0x038)); // 024660EFCC48 0x38 MstStoreItemId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StoreProductId                            = GetString(new IntPtr(p + 0x040)); // 024660EFCC88 0x40 StoreProductId              ( 000186671910 ModelPrimitiveType string string string String )
            value.PurchaseLimit                             = GetObject<PurchaseLimitStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.PurchaseLimitStatus.FromPointer); // 024660EFCCC8 0x48 PurchaseLimit               ( 0001865DD320 ModelClassType PurchaseLimitStatus PurchaseLimitStatus PurchaseLimitStatus Pointer )
            value.Price                                     = GetInt32(new IntPtr(p + 0x050)); // 024660EFCD08 0x50 Price                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BonusProductList                          = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 024660EFCD68 0x58 BonusProductList            ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x060), ReversePrism.DataModels.Timestamp.FromPointer); // 024660EFCDA8 0x60 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x068), ReversePrism.DataModels.Timestamp.FromPointer); // 024660EFCDE8 0x68 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ContentProductList                        = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 024660EFCE48 0x70 ContentProductList          ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.ShopItemType                              = (ShopItemType)GetInt32(new IntPtr(p + 0x078)); // 024660EFCE88 0x78 ShopItemType                ( 000186761B60 ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.DisplayOrder                              = GetInt32(new IntPtr(p + 0x07C)); // 024660EFCEC8 0x7C DisplayOrder                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}

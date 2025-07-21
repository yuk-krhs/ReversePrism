using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 020 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<StoreItemStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstStoreItemIdFieldNumber                int IL2CPP_TYPE_I4
    // 038 MstStoreItemId                           ModelPrimitiveType int int int Int32
    // 000 StoreProductIdFieldNumber                int IL2CPP_TYPE_I4
    // 040 StoreProductId                           ModelPrimitiveType string string string String
    // 000 PurchaseLimitFieldNumber                 int IL2CPP_TYPE_I4
    // 048 PurchaseLimit                            ModelClassType PurchaseLimitStatus PurchaseLimitStatus PurchaseLimitStatus Pointer
    // 000 PriceFieldNumber                         int IL2CPP_TYPE_I4
    // 050 Price                                    ModelPrimitiveType int int int Int32
    // 000 BonusProductListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_bonusProductList_codec         FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 058 BonusProductList                         ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 060 _BeginDate                               ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 068 _EndDate                                 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ContentProductListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_contentProductList_codec       FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 070 ContentProductList                       ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 ShopItemTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 078 ShopItemType                             ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 000 DisplayOrderFieldNumber                  int IL2CPP_TYPE_I4
    // 07C DisplayOrder                             ModelPrimitiveType int int int Int32
    // 000 IsAlreadyAcquiredAllProductsFieldNumber  int IL2CPP_TYPE_I4
    // 080 IsAlreadyAcquiredAllProducts             ModelPrimitiveType bool bool bool Bool
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
        public bool                                     IsAlreadyAcquiredAllProducts            { get; set; }

        public static StoreItemStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StoreItemStatus() { Pointer= p0 };

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0x10 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0x20 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstStoreItemId                            = GetInt32(new IntPtr(p + 0x038)); // 0x38 MstStoreItemId              ( ModelPrimitiveType int int int Int32 )
            value.StoreProductId                            = GetString(new IntPtr(p + 0x040)); // 0x40 StoreProductId              ( ModelPrimitiveType string string string String )
            value.PurchaseLimit                             = GetObject<PurchaseLimitStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.PurchaseLimitStatus.FromPointer); // 0x48 PurchaseLimit               ( ModelClassType PurchaseLimitStatus PurchaseLimitStatus PurchaseLimitStatus Pointer )
            value.Price                                     = GetInt32(new IntPtr(p + 0x050)); // 0x50 Price                       ( ModelPrimitiveType int int int Int32 )
            value.BonusProductList                          = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x58 BonusProductList            ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x060), ReversePrism.DataModels.Timestamp.FromPointer); // 0x60 _BeginDate                  ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x068), ReversePrism.DataModels.Timestamp.FromPointer); // 0x68 _EndDate                    ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ContentProductList                        = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x070), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0x70 ContentProductList          ( ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.ShopItemType                              = (ShopItemType)GetInt32(new IntPtr(p + 0x078)); // 0x78 ShopItemType                ( ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.DisplayOrder                              = GetInt32(new IntPtr(p + 0x07C)); // 0x7C DisplayOrder                ( ModelPrimitiveType int int int Int32 )
            value.IsAlreadyAcquiredAllProducts              = GetBool(new IntPtr(p + 0x080)); // 0x80 IsAlreadyAcquiredAllProducts ( ModelPrimitiveType bool bool bool Bool )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}

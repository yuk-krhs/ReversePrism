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
    // 000 _parser                                  MessageParser`1<ShopItemStatus> IL2CPP_TYPE_GENERICINST
    // 030 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstShopItemIdFieldNumber                 int IL2CPP_TYPE_I4
    // 038 MstShopItemId                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PurchaseLimitFieldNumber                 int IL2CPP_TYPE_I4
    // 040 PurchaseLimit                            0001865DD320 ModelClassType PurchaseLimitStatus PurchaseLimitStatus PurchaseLimitStatus Pointer
    // 000 PriceProductFieldNumber                  int IL2CPP_TYPE_I4
    // 048 PriceProduct                             0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer
    // 000 ContentProductListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_contentProductList_codec       FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 050 ContentProductList                       000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 BonusProductListFieldNumber              int IL2CPP_TYPE_I4
    // 010 _repeated_bonusProductList_codec         FieldCodec`1<ProductWithAmountStatus> IL2CPP_TYPE_GENERICINST
    // 058 BonusProductList                         000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer
    // 000 BeginDateFieldNumber                     int IL2CPP_TYPE_I4
    // 060 _BeginDate                               000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 EndDateFieldNumber                       int IL2CPP_TYPE_I4
    // 068 _EndDate                                 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 ShopItemTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 070 ShopItemType                             000186761B60 ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 000 DisplayOrderFieldNumber                  int IL2CPP_TYPE_I4
    // 074 DisplayOrder                             0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ShopItemStatus
    {
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public int                                      MstShopItemId                           { get; set; }
        public PurchaseLimitStatus?                     PurchaseLimit                           { get; set; }
        public ProductWithAmountStatus?                 PriceProduct                            { get; set; }
        public List<ProductWithAmountStatus>?           ContentProductList                      { get; set; }
        public List<ProductWithAmountStatus>?           BonusProductList                        { get; set; }
        public Timestamp?                               _BeginDate                              { get; set; }
        public Timestamp?                               _EndDate                                { get; set; }
        public ShopItemType                             ShopItemType                            { get; set; }
        public int                                      DisplayOrder                            { get; set; }

        public static ShopItemStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopItemStatus();

            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x010)); // 0270D280C800 0x10 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x020)); // 0270D280C820 0x20 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstShopItemId                             = GetInt32(new IntPtr(p + 0x038)); // 0270D280C8A0 0x38 MstShopItemId               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PurchaseLimit                             = GetObject<PurchaseLimitStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.PurchaseLimitStatus.FromPointer); // 0270D280C8E0 0x40 PurchaseLimit               ( 0001865DD320 ModelClassType PurchaseLimitStatus PurchaseLimitStatus PurchaseLimitStatus Pointer )
            value.PriceProduct                              = GetObject<ProductWithAmountStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D280C920 0x48 PriceProduct                ( 0001865A6D10 ModelClassType ProductWithAmountStatus ProductWithAmountStatus ProductWithAmountStatus Pointer )
            value.ContentProductList                        = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D280C980 0x50 ContentProductList          ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value.BonusProductList                          = GetObjectList<ProductWithAmountStatus>(new IntPtr(p + 0x058), ReversePrism.DataModels.ProductWithAmountStatus.FromPointer); // 0270D280C9E0 0x58 BonusProductList            ( 000185CECB38 ModelClassListType RepeatedField`1<ProductWithAmountStatus> RepeatedField`1<ProductWithAmountStatus> List<ProductWithAmountStatus> Pointer )
            value._BeginDate                                = GetObject<Timestamp>(new IntPtr(p + 0x060), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D280CA20 0x60 _BeginDate                  ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value._EndDate                                  = GetObject<Timestamp>(new IntPtr(p + 0x068), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D280CA60 0x68 _EndDate                    ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.ShopItemType                              = (ShopItemType)GetInt32(new IntPtr(p + 0x070)); // 0270D280CAA0 0x70 ShopItemType                ( 000186761B60 ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.DisplayOrder                              = GetInt32(new IntPtr(p + 0x074)); // 0270D280CAE0 0x74 DisplayOrder                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BeginDate                     = ToDateTime(value._BeginDate);
            value.EndDate                       = ToDateTime(value._EndDate);

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DetailMainItems                          ModelClassListType IReadOnlyList`1<ShopGoodsParam> IReadOnlyList`1<ShopGoodsParam> List<ShopGoodsParam> Pointer
    // 018 DetailBonusItems                         ModelClassListType IReadOnlyList`1<ShopGoodsParam> IReadOnlyList`1<ShopGoodsParam> List<ShopGoodsParam> Pointer
    // 020 StoreItem                                ModelClassType IStoreItemStatus IStoreItemStatus IStoreItemStatus Pointer
    // 028 ShopItem                                 ModelClassType IShopItemStatus IShopItemStatus IShopItemStatus Pointer
    // 030 SeasonPassStoreItem                      ModelClassType ISeasonPassStoreItemStatus ISeasonPassStoreItemStatus ISeasonPassStoreItemStatus Pointer
    // 038 LoginBonusPassStoreItem                  ModelClassType ILoginBonusPassStoreItemStatus ILoginBonusPassStoreItemStatus ILoginBonusPassStoreItemStatus Pointer
    // 040 CostumeShopItem                          ModelClassType ICostumeShopItemStatus ICostumeShopItemStatus ICostumeShopItemStatus Pointer
    // 048 CostumeStoreItem                         ModelClassType ICostumeStoreItemStatus ICostumeStoreItemStatus ICostumeStoreItemStatus Pointer
    // 050 MainContentItemAmount                    ModelPrimitiveType long long long Int64
    // 058 StoreProductId                           ModelPrimitiveType string string string String
    // 060 MstItemId                                ModelPrimitiveType int int int Int32
    // 068 ProductName                              ModelPrimitiveType string string string String
    // 070 GroupType                                ModelEnumType GroupType GroupType GroupType Int32
    // 074 ProductPriceType                         ModelEnumType ProductPriceType ProductPriceType ProductPriceType Int32
    // 078 ShopItemType                             ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 07C Price                                    ModelPrimitiveType int int int Int32
    // 080 StoreLocalPriceString                    ModelPrimitiveType string string string String
    // 088 CautionText                              ModelPrimitiveType string string string String
    // 090 PurchaseLimitType                        ModelEnumType PurchaseCountResetTimingType PurchaseCountResetTimingType PurchaseCountResetTimingType Int32
    // 094 PurchaseCount                            ModelPrimitiveType int int int Int32
    // 098 PurchaseLimitCount                       ModelPrimitiveType int int int Int32
    // 0A0 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 0B0 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 0C0 IsRead                                   ModelPrimitiveType bool bool bool Bool
    // 0C8 GoodsParams                              ModelClassListType List`1<ShopGoodsParam> List`1<ShopGoodsParam> List<ShopGoodsParam> Pointer
    // 0D0 DisplayOrder                             ModelPrimitiveType int int int Int32
    // 0D4 IsAlreadyAcquiredAllProducts             ModelPrimitiveType bool bool bool Bool
    public partial class ShopProductParam : DataModel
    {
        public List<ShopGoodsParam>?                    DetailMainItems                         { get; set; }
        public List<ShopGoodsParam>?                    DetailBonusItems                        { get; set; }
        public IStoreItemStatus?                        StoreItem                               { get; set; }
        public IShopItemStatus?                         ShopItem                                { get; set; }
        public ISeasonPassStoreItemStatus?              SeasonPassStoreItem                     { get; set; }
        public ILoginBonusPassStoreItemStatus?          LoginBonusPassStoreItem                 { get; set; }
        public ICostumeShopItemStatus?                  CostumeShopItem                         { get; set; }
        public ICostumeStoreItemStatus?                 CostumeStoreItem                        { get; set; }
        public long                                     MainContentItemAmount                   { get; set; }
        public string                                   StoreProductId                          { get; set; }
        public int                                      MstItemId                               { get; set; }
        public string                                   ProductName                             { get; set; }
        public GroupType                                GroupType                               { get; set; }
        public ProductPriceType                         ProductPriceType                        { get; set; }
        public ShopItemType                             ShopItemType                            { get; set; }
        public int                                      Price                                   { get; set; }
        public string                                   StoreLocalPriceString                   { get; set; }
        public string                                   CautionText                             { get; set; }
        public PurchaseCountResetTimingType             PurchaseLimitType                       { get; set; }
        public int                                      PurchaseCount                           { get; set; }
        public int                                      PurchaseLimitCount                      { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public bool                                     IsRead                                  { get; set; }
        public List<ShopGoodsParam>?                    GoodsParams                             { get; set; }
        public int                                      DisplayOrder                            { get; set; }
        public bool                                     IsAlreadyAcquiredAllProducts            { get; set; }

        public static ShopProductParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopProductParam() { Pointer= p0 };

            value.DetailMainItems                           = GetObjectList<ShopGoodsParam>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopGoodsParam.FromPointer); // 0x10 DetailMainItems             ( ModelClassListType IReadOnlyList`1<ShopGoodsParam> IReadOnlyList`1<ShopGoodsParam> List<ShopGoodsParam> Pointer )
            value.DetailBonusItems                          = GetObjectList<ShopGoodsParam>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShopGoodsParam.FromPointer); // 0x18 DetailBonusItems            ( ModelClassListType IReadOnlyList`1<ShopGoodsParam> IReadOnlyList`1<ShopGoodsParam> List<ShopGoodsParam> Pointer )
            value.StoreItem                                 = GetObject<IStoreItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0x20 StoreItem                   ( ModelClassType IStoreItemStatus IStoreItemStatus IStoreItemStatus Pointer )
            value.ShopItem                                  = GetObject<IShopItemStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IShopItemStatus.FromPointer); // 0x28 ShopItem                    ( ModelClassType IShopItemStatus IShopItemStatus IShopItemStatus Pointer )
            value.SeasonPassStoreItem                       = GetObject<ISeasonPassStoreItemStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ISeasonPassStoreItemStatus.FromPointer); // 0x30 SeasonPassStoreItem         ( ModelClassType ISeasonPassStoreItemStatus ISeasonPassStoreItemStatus ISeasonPassStoreItemStatus Pointer )
            value.LoginBonusPassStoreItem                   = GetObject<ILoginBonusPassStoreItemStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ILoginBonusPassStoreItemStatus.FromPointer); // 0x38 LoginBonusPassStoreItem     ( ModelClassType ILoginBonusPassStoreItemStatus ILoginBonusPassStoreItemStatus ILoginBonusPassStoreItemStatus Pointer )
            value.CostumeShopItem                           = GetObject<ICostumeShopItemStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ICostumeShopItemStatus.FromPointer); // 0x40 CostumeShopItem             ( ModelClassType ICostumeShopItemStatus ICostumeShopItemStatus ICostumeShopItemStatus Pointer )
            value.CostumeStoreItem                          = GetObject<ICostumeStoreItemStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ICostumeStoreItemStatus.FromPointer); // 0x48 CostumeStoreItem            ( ModelClassType ICostumeStoreItemStatus ICostumeStoreItemStatus ICostumeStoreItemStatus Pointer )
            value.MainContentItemAmount                     = GetInt64(new IntPtr(p + 0x050)); // 0x50 MainContentItemAmount       ( ModelPrimitiveType long long long Int64 )
            value.StoreProductId                            = GetString(new IntPtr(p + 0x058)); // 0x58 StoreProductId              ( ModelPrimitiveType string string string String )
            value.MstItemId                                 = GetInt32(new IntPtr(p + 0x060)); // 0x60 MstItemId                   ( ModelPrimitiveType int int int Int32 )
            value.ProductName                               = GetString(new IntPtr(p + 0x068)); // 0x68 ProductName                 ( ModelPrimitiveType string string string String )
            value.GroupType                                 = (GroupType)GetInt32(new IntPtr(p + 0x070)); // 0x70 GroupType                   ( ModelEnumType GroupType GroupType GroupType Int32 )
            value.ProductPriceType                          = (ProductPriceType)GetInt32(new IntPtr(p + 0x074)); // 0x74 ProductPriceType            ( ModelEnumType ProductPriceType ProductPriceType ProductPriceType Int32 )
            value.ShopItemType                              = (ShopItemType)GetInt32(new IntPtr(p + 0x078)); // 0x78 ShopItemType                ( ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.Price                                     = GetInt32(new IntPtr(p + 0x07C)); // 0x7C Price                       ( ModelPrimitiveType int int int Int32 )
            value.StoreLocalPriceString                     = GetString(new IntPtr(p + 0x080)); // 0x80 StoreLocalPriceString       ( ModelPrimitiveType string string string String )
            value.CautionText                               = GetString(new IntPtr(p + 0x088)); // 0x88 CautionText                 ( ModelPrimitiveType string string string String )
            value.PurchaseLimitType                         = (PurchaseCountResetTimingType)GetInt32(new IntPtr(p + 0x090)); // 0x90 PurchaseLimitType           ( ModelEnumType PurchaseCountResetTimingType PurchaseCountResetTimingType PurchaseCountResetTimingType Int32 )
            value.PurchaseCount                             = GetInt32(new IntPtr(p + 0x094)); // 0x94 PurchaseCount               ( ModelPrimitiveType int int int Int32 )
            value.PurchaseLimitCount                        = GetInt32(new IntPtr(p + 0x098)); // 0x98 PurchaseLimitCount          ( ModelPrimitiveType int int int Int32 )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x0A0)); // 0xA0 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x0B0)); // 0xB0 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.IsRead                                    = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 IsRead                      ( ModelPrimitiveType bool bool bool Bool )
            value.GoodsParams                               = GetObjectList<ShopGoodsParam>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ShopGoodsParam.FromPointer); // 0xC8 GoodsParams                 ( ModelClassListType List`1<ShopGoodsParam> List`1<ShopGoodsParam> List<ShopGoodsParam> Pointer )
            value.DisplayOrder                              = GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 DisplayOrder                ( ModelPrimitiveType int int int Int32 )
            value.IsAlreadyAcquiredAllProducts              = GetBool(new IntPtr(p + 0x0D4)); // 0xD4 IsAlreadyAcquiredAllProducts ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

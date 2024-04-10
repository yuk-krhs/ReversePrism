using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DetailMainItems                          000185D16248 ModelClassListType IReadOnlyList`1<ShopGoodsParam> IReadOnlyList`1<ShopGoodsParam> List<ShopGoodsParam> Pointer
    // 018 DetailBonusItems                         000185D16248 ModelClassListType IReadOnlyList`1<ShopGoodsParam> IReadOnlyList`1<ShopGoodsParam> List<ShopGoodsParam> Pointer
    // 020 StoreItem                                00018665A9E0 ModelClassType IStoreItemStatus IStoreItemStatus IStoreItemStatus Pointer
    // 028 ShopItem                                 0001866428E0 ModelClassType IShopItemStatus IShopItemStatus IShopItemStatus Pointer
    // 030 SeasonPassStoreItem                      00018662F000 ModelClassType ISeasonPassStoreItemStatus ISeasonPassStoreItemStatus ISeasonPassStoreItemStatus Pointer
    // 038 LoginBonusPassStoreItem                  0001865A36F0 ModelClassType ILoginBonusPassStoreItemStatus ILoginBonusPassStoreItemStatus ILoginBonusPassStoreItemStatus Pointer
    // 040 CostumeShopItem                          000186743050 ModelClassType ICostumeShopItemStatus ICostumeShopItemStatus ICostumeShopItemStatus Pointer
    // 048 CostumeStoreItem                         000186743E90 ModelClassType ICostumeStoreItemStatus ICostumeStoreItemStatus ICostumeStoreItemStatus Pointer
    // 050 MainContentItemAmount                    0001865F7700 ModelPrimitiveType long long long Int64
    // 058 StoreProductId                           000186671910 ModelPrimitiveType string string string String
    // 060 MstItemId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 ProductName                              000186671910 ModelPrimitiveType string string string String
    // 070 GroupType                                0001867742D0 ModelEnumType GroupType GroupType GroupType Int32
    // 074 ProductPriceType                         000186775630 ModelEnumType ProductPriceType ProductPriceType ProductPriceType Int32
    // 078 ShopItemType                             00018661A670 ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 07C Price                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 StoreLocalPriceString                    000186671910 ModelPrimitiveType string string string String
    // 088 CautionText                              000186671910 ModelPrimitiveType string string string String
    // 090 PurchaseLimitType                        000186612320 ModelEnumType PurchaseCountResetTimingType PurchaseCountResetTimingType PurchaseCountResetTimingType Int32
    // 094 PurchaseCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 098 PurchaseLimitCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A0 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 0B0 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 0C0 IsRead                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 0C8 GoodsParams                              000185D08E58 ModelClassListType List`1<ShopGoodsParam> List`1<ShopGoodsParam> List<ShopGoodsParam> Pointer
    // 0D0 DisplayOrder                             0001865F2AF0 ModelPrimitiveType int int int Int32
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

        public static ShopProductParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopProductParam() { Pointer= p0 };

            value.DetailMainItems                           = GetObjectList<ShopGoodsParam>(new IntPtr(p + 0x010), ReversePrism.DataModels.ShopGoodsParam.FromPointer); // 0245A5B4EF10 0x10 DetailMainItems             ( 000185D16248 ModelClassListType IReadOnlyList`1<ShopGoodsParam> IReadOnlyList`1<ShopGoodsParam> List<ShopGoodsParam> Pointer )
            value.DetailBonusItems                          = GetObjectList<ShopGoodsParam>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShopGoodsParam.FromPointer); // 0245A5B4EF30 0x18 DetailBonusItems            ( 000185D16248 ModelClassListType IReadOnlyList`1<ShopGoodsParam> IReadOnlyList`1<ShopGoodsParam> List<ShopGoodsParam> Pointer )
            value.StoreItem                                 = GetObject<IStoreItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0245A5B4EF50 0x20 StoreItem                   ( 00018665A9E0 ModelClassType IStoreItemStatus IStoreItemStatus IStoreItemStatus Pointer )
            value.ShopItem                                  = GetObject<IShopItemStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IShopItemStatus.FromPointer); // 0245A5B4EF70 0x28 ShopItem                    ( 0001866428E0 ModelClassType IShopItemStatus IShopItemStatus IShopItemStatus Pointer )
            value.SeasonPassStoreItem                       = GetObject<ISeasonPassStoreItemStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ISeasonPassStoreItemStatus.FromPointer); // 0245A5B4EF90 0x30 SeasonPassStoreItem         ( 00018662F000 ModelClassType ISeasonPassStoreItemStatus ISeasonPassStoreItemStatus ISeasonPassStoreItemStatus Pointer )
            value.LoginBonusPassStoreItem                   = GetObject<ILoginBonusPassStoreItemStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ILoginBonusPassStoreItemStatus.FromPointer); // 0245A5B4EFB0 0x38 LoginBonusPassStoreItem     ( 0001865A36F0 ModelClassType ILoginBonusPassStoreItemStatus ILoginBonusPassStoreItemStatus ILoginBonusPassStoreItemStatus Pointer )
            value.CostumeShopItem                           = GetObject<ICostumeShopItemStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ICostumeShopItemStatus.FromPointer); // 0245A5B4EFD0 0x40 CostumeShopItem             ( 000186743050 ModelClassType ICostumeShopItemStatus ICostumeShopItemStatus ICostumeShopItemStatus Pointer )
            value.CostumeStoreItem                          = GetObject<ICostumeStoreItemStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ICostumeStoreItemStatus.FromPointer); // 0245A5B4EFF0 0x48 CostumeStoreItem            ( 000186743E90 ModelClassType ICostumeStoreItemStatus ICostumeStoreItemStatus ICostumeStoreItemStatus Pointer )
            value.MainContentItemAmount                     = GetInt64(new IntPtr(p + 0x050)); // 0245A5B4F010 0x50 MainContentItemAmount       ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.StoreProductId                            = GetString(new IntPtr(p + 0x058)); // 0245A5B4F030 0x58 StoreProductId              ( 000186671910 ModelPrimitiveType string string string String )
            value.MstItemId                                 = GetInt32(new IntPtr(p + 0x060)); // 0245A5B4F050 0x60 MstItemId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProductName                               = GetString(new IntPtr(p + 0x068)); // 0245A5B4F070 0x68 ProductName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.GroupType                                 = (GroupType)GetInt32(new IntPtr(p + 0x070)); // 0245A5B4F090 0x70 GroupType                   ( 0001867742D0 ModelEnumType GroupType GroupType GroupType Int32 )
            value.ProductPriceType                          = (ProductPriceType)GetInt32(new IntPtr(p + 0x074)); // 0245A5B4F0B0 0x74 ProductPriceType            ( 000186775630 ModelEnumType ProductPriceType ProductPriceType ProductPriceType Int32 )
            value.ShopItemType                              = (ShopItemType)GetInt32(new IntPtr(p + 0x078)); // 0245A5B4F0D0 0x78 ShopItemType                ( 00018661A670 ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.Price                                     = GetInt32(new IntPtr(p + 0x07C)); // 0245A5B4F0F0 0x7C Price                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StoreLocalPriceString                     = GetString(new IntPtr(p + 0x080)); // 0245A5B4F110 0x80 StoreLocalPriceString       ( 000186671910 ModelPrimitiveType string string string String )
            value.CautionText                               = GetString(new IntPtr(p + 0x088)); // 0245A5B4F130 0x88 CautionText                 ( 000186671910 ModelPrimitiveType string string string String )
            value.PurchaseLimitType                         = (PurchaseCountResetTimingType)GetInt32(new IntPtr(p + 0x090)); // 0245A5B4F150 0x90 PurchaseLimitType           ( 000186612320 ModelEnumType PurchaseCountResetTimingType PurchaseCountResetTimingType PurchaseCountResetTimingType Int32 )
            value.PurchaseCount                             = GetInt32(new IntPtr(p + 0x094)); // 0245A5B4F170 0x94 PurchaseCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PurchaseLimitCount                        = GetInt32(new IntPtr(p + 0x098)); // 0245A5B4F190 0x98 PurchaseLimitCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x0A0)); // 0245A5B4F1B0 0xA0 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x0B0)); // 0245A5B4F1D0 0xB0 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.IsRead                                    = GetBool(new IntPtr(p + 0x0C0)); // 0245A5B4F1F0 0xC0 IsRead                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.GoodsParams                               = GetObjectList<ShopGoodsParam>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.ShopGoodsParam.FromPointer); // 0245A5B4F210 0xC8 GoodsParams                 ( 000185D08E58 ModelClassListType List`1<ShopGoodsParam> List`1<ShopGoodsParam> List<ShopGoodsParam> Pointer )
            value.DisplayOrder                              = GetInt32(new IntPtr(p + 0x0D0)); // 0245A5B4F230 0xD0 DisplayOrder                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

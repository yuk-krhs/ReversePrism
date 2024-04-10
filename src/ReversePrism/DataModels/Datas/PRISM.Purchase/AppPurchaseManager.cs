using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StoreItemList                            000185D0C758 ModelClassListType IReadOnlyList`1<IStoreItemStatus> IReadOnlyList`1<IStoreItemStatus> List<IStoreItemStatus> Pointer
    // 018 ShopStoreItemList                        000185D0C758 ModelClassListType IReadOnlyList`1<IStoreItemStatus> IReadOnlyList`1<IStoreItemStatus> List<IStoreItemStatus> Pointer
    // 020 ShopItemList                             000185D0B1B8 ModelClassListType IReadOnlyList`1<IShopItemStatus> IReadOnlyList`1<IShopItemStatus> List<IShopItemStatus> Pointer
    // 028 SeasonPassItemList                       000185D0A448 ModelClassListType IReadOnlyList`1<ISeasonPassStoreItemStatus> IReadOnlyList`1<ISeasonPassStoreItemStatus> List<ISeasonPassStoreItemStatus> Pointer
    // 030 LoginPassItemList                        000185D01EE8 ModelClassListType IReadOnlyList`1<ILoginBonusPassStoreItemStatus> IReadOnlyList`1<ILoginBonusPassStoreItemStatus> List<ILoginBonusPassStoreItemStatus> Pointer
    // 038 CostumeItemList                          000185CF3FA8 ModelClassListType IReadOnlyList`1<ICostumeShopItemStatus> IReadOnlyList`1<ICostumeShopItemStatus> List<ICostumeShopItemStatus> Pointer
    // 040 CostumeStoreItemList                     000185CF4478 ModelClassListType IReadOnlyList`1<ICostumeStoreItemStatus> IReadOnlyList`1<ICostumeStoreItemStatus> List<ICostumeStoreItemStatus> Pointer
    // 048 Purchase                                 000186602450 ModelClassType IPurchase IPurchase IPurchase Pointer
    // 050 ShopService                              0001866EB2F0 ModelClassType IAccessShopService IAccessShopService IAccessShopService Pointer
    // 058 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 060 MonthlyCharges                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 expectedPriceDic                         Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 070 PurchaseState                            0001866B2F10 ModelEnumType PurchaseState PurchaseState PurchaseState Int32
    // 074 MaintenanceState                         0001866B2320 ModelEnumType MaintenanceState MaintenanceState MaintenanceState Int32
    // 078 LocalSave                                0001865DDA30 ModelClassType PurchaseLocalSave PurchaseLocalSave PurchaseLocalSave Pointer
    // 080 errorParamater                           ValueTuple`2<ErrorCode, string> IL2CPP_TYPE_GENERICINST
    // 090 BirthdayParam                            00018675F190 ModelClassType BirthdayParam BirthdayParam BirthdayParam Pointer
    // 098 DeferredDocumentBody                     000186671910 ModelPrimitiveType string string string String
    // 0A0 VerifySuccessStoreItems                  000185CE8CE8 ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer
    public partial class AppPurchaseManager : DataModel
    {
        public List<StoreItemStatus>?                   StoreItemList                           { get; set; }
        public List<StoreItemStatus>?                   ShopStoreItemList                       { get; set; }
        public List<ShopItemStatus>?                    ShopItemList                            { get; set; }
        public List<SeasonPassStoreItemStatus>?         SeasonPassItemList                      { get; set; }
        public List<LoginBonusPassStoreItemStatus>?     LoginPassItemList                       { get; set; }
        public List<CostumeShopItemStatus>?             CostumeItemList                         { get; set; }
        public List<CostumeStoreItemStatus>?            CostumeStoreItemList                    { get; set; }
        /*
        public IPurchase?                               Purchase                                { get; set; }
        public IAccessShopService?                      ShopService                             { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public int                                      MonthlyCharges                          { get; set; }
        public PurchaseState                            PurchaseState                           { get; set; }
        public MaintenanceState                         MaintenanceState                        { get; set; }
        public PurchaseLocalSave?                       LocalSave                               { get; set; }
        public BirthdayParam?                           BirthdayParam                           { get; set; }
        public string                                   DeferredDocumentBody                    { get; set; }
        public List<IStoreItemStatus>?                  VerifySuccessStoreItems                 { get; set; }
        */

        public static AppPurchaseManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppPurchaseManager() { Pointer= p0 };

            value.StoreItemList                             = GetObjectList<StoreItemStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.StoreItemStatus.FromPointer); // 0246650EFDC8 0x10 StoreItemList               ( 000185D0C758 ModelClassListType IReadOnlyList`1<IStoreItemStatus> IReadOnlyList`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )
            value.ShopStoreItemList                         = GetObjectList<StoreItemStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoreItemStatus.FromPointer); // 0246650EFDE8 0x18 ShopStoreItemList           ( 000185D0C758 ModelClassListType IReadOnlyList`1<IStoreItemStatus> IReadOnlyList`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )
            value.ShopItemList                              = GetObjectList<ShopItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopItemStatus.FromPointer); // 0246650EFE08 0x20 ShopItemList                ( 000185D0B1B8 ModelClassListType IReadOnlyList`1<IShopItemStatus> IReadOnlyList`1<IShopItemStatus> List<IShopItemStatus> Pointer )
            value.SeasonPassItemList                        = GetObjectList<SeasonPassStoreItemStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.SeasonPassStoreItemStatus.FromPointer); // 0246650EFE28 0x28 SeasonPassItemList          ( 000185D0A448 ModelClassListType IReadOnlyList`1<ISeasonPassStoreItemStatus> IReadOnlyList`1<ISeasonPassStoreItemStatus> List<ISeasonPassStoreItemStatus> Pointer )
            value.LoginPassItemList                         = GetObjectList<LoginBonusPassStoreItemStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LoginBonusPassStoreItemStatus.FromPointer); // 0246650EFE48 0x30 LoginPassItemList           ( 000185D01EE8 ModelClassListType IReadOnlyList`1<ILoginBonusPassStoreItemStatus> IReadOnlyList`1<ILoginBonusPassStoreItemStatus> List<ILoginBonusPassStoreItemStatus> Pointer )
            value.CostumeItemList                           = GetObjectList<CostumeShopItemStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.CostumeShopItemStatus.FromPointer); // 0246650EFE68 0x38 CostumeItemList             ( 000185CF3FA8 ModelClassListType IReadOnlyList`1<ICostumeShopItemStatus> IReadOnlyList`1<ICostumeShopItemStatus> List<ICostumeShopItemStatus> Pointer )
            value.CostumeStoreItemList                      = GetObjectList<CostumeStoreItemStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.CostumeStoreItemStatus.FromPointer); // 0246650EFE88 0x40 CostumeStoreItemList        ( 000185CF4478 ModelClassListType IReadOnlyList`1<ICostumeStoreItemStatus> IReadOnlyList`1<ICostumeStoreItemStatus> List<ICostumeStoreItemStatus> Pointer )
            /*
            value.Purchase                                  = GetObject<IPurchase>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPurchase.FromPointer); // 0246650EFEA8 0x48 Purchase                    ( 000186602450 ModelClassType IPurchase IPurchase IPurchase Pointer )
            value.ShopService                               = GetObject<IAccessShopService>(new IntPtr(p + 0x050), ReversePrism.DataModels.IAccessShopService.FromPointer); // 0246650EFEC8 0x50 ShopService                 ( 0001866EB2F0 ModelClassType IAccessShopService IAccessShopService IAccessShopService Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x058)); // 0246650EFEE8 0x58 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.MonthlyCharges                            = GetInt32(new IntPtr(p + 0x060)); // 0246650EFF08 0x60 MonthlyCharges              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PurchaseState                             = (PurchaseState)GetInt32(new IntPtr(p + 0x070)); // 0246650EFF48 0x70 PurchaseState               ( 0001866B2F10 ModelEnumType PurchaseState PurchaseState PurchaseState Int32 )
            value.MaintenanceState                          = (MaintenanceState)GetInt32(new IntPtr(p + 0x074)); // 0246650EFF68 0x74 MaintenanceState            ( 0001866B2320 ModelEnumType MaintenanceState MaintenanceState MaintenanceState Int32 )
            value.LocalSave                                 = GetObject<PurchaseLocalSave>(new IntPtr(p + 0x078), ReversePrism.DataModels.PurchaseLocalSave.FromPointer); // 0246650EFF88 0x78 LocalSave                   ( 0001865DDA30 ModelClassType PurchaseLocalSave PurchaseLocalSave PurchaseLocalSave Pointer )
            value.BirthdayParam                             = GetObject<BirthdayParam>(new IntPtr(p + 0x090), ReversePrism.DataModels.BirthdayParam.FromPointer); // 0246650EFFC8 0x90 BirthdayParam               ( 00018675F190 ModelClassType BirthdayParam BirthdayParam BirthdayParam Pointer )
            value.DeferredDocumentBody                      = GetString(new IntPtr(p + 0x098)); // 0246650EFFE8 0x98 DeferredDocumentBody        ( 000186671910 ModelPrimitiveType string string string String )
            value.VerifySuccessStoreItems                   = GetObjectList<IStoreItemStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0246650F0008 0xA0 VerifySuccessStoreItems     ( 000185CE8CE8 ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )
            */
            return value;
        }
    }
}

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
    public partial class AppPurchaseManager
    {
        public List<IStoreItemStatus>?                  StoreItemList                           { get; set; }
        public List<IStoreItemStatus>?                  ShopStoreItemList                       { get; set; }
        public List<IShopItemStatus>?                   ShopItemList                            { get; set; }
        public List<ISeasonPassStoreItemStatus>?        SeasonPassItemList                      { get; set; }
        public List<ILoginBonusPassStoreItemStatus>?    LoginPassItemList                       { get; set; }
        public List<ICostumeShopItemStatus>?            CostumeItemList                         { get; set; }
        public List<ICostumeStoreItemStatus>?           CostumeStoreItemList                    { get; set; }
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

        public static AppPurchaseManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AppPurchaseManager();

            value.StoreItemList                             = GetObjectList<IStoreItemStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0270D50944D8 0x10 StoreItemList               ( 000185D0C758 ModelClassListType IReadOnlyList`1<IStoreItemStatus> IReadOnlyList`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )
            value.ShopStoreItemList                         = GetObjectList<IStoreItemStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0270D50944F8 0x18 ShopStoreItemList           ( 000185D0C758 ModelClassListType IReadOnlyList`1<IStoreItemStatus> IReadOnlyList`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )
            value.ShopItemList                              = GetObjectList<IShopItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IShopItemStatus.FromPointer); // 0270D5094518 0x20 ShopItemList                ( 000185D0B1B8 ModelClassListType IReadOnlyList`1<IShopItemStatus> IReadOnlyList`1<IShopItemStatus> List<IShopItemStatus> Pointer )
            value.SeasonPassItemList                        = GetObjectList<ISeasonPassStoreItemStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISeasonPassStoreItemStatus.FromPointer); // 0270D5094538 0x28 SeasonPassItemList          ( 000185D0A448 ModelClassListType IReadOnlyList`1<ISeasonPassStoreItemStatus> IReadOnlyList`1<ISeasonPassStoreItemStatus> List<ISeasonPassStoreItemStatus> Pointer )
            value.LoginPassItemList                         = GetObjectList<ILoginBonusPassStoreItemStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ILoginBonusPassStoreItemStatus.FromPointer); // 0270D5094558 0x30 LoginPassItemList           ( 000185D01EE8 ModelClassListType IReadOnlyList`1<ILoginBonusPassStoreItemStatus> IReadOnlyList`1<ILoginBonusPassStoreItemStatus> List<ILoginBonusPassStoreItemStatus> Pointer )
            value.CostumeItemList                           = GetObjectList<ICostumeShopItemStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ICostumeShopItemStatus.FromPointer); // 0270D5094578 0x38 CostumeItemList             ( 000185CF3FA8 ModelClassListType IReadOnlyList`1<ICostumeShopItemStatus> IReadOnlyList`1<ICostumeShopItemStatus> List<ICostumeShopItemStatus> Pointer )
            value.CostumeStoreItemList                      = GetObjectList<ICostumeStoreItemStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ICostumeStoreItemStatus.FromPointer); // 0270D5094598 0x40 CostumeStoreItemList        ( 000185CF4478 ModelClassListType IReadOnlyList`1<ICostumeStoreItemStatus> IReadOnlyList`1<ICostumeStoreItemStatus> List<ICostumeStoreItemStatus> Pointer )
            value.Purchase                                  = GetObject<IPurchase>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPurchase.FromPointer); // 0270D50945B8 0x48 Purchase                    ( 000186602450 ModelClassType IPurchase IPurchase IPurchase Pointer )
            value.ShopService                               = GetObject<IAccessShopService>(new IntPtr(p + 0x050), ReversePrism.DataModels.IAccessShopService.FromPointer); // 0270D50945D8 0x50 ShopService                 ( 0001866EB2F0 ModelClassType IAccessShopService IAccessShopService IAccessShopService Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x058)); // 0270D50945F8 0x58 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.MonthlyCharges                            = GetInt32(new IntPtr(p + 0x060)); // 0270D5094618 0x60 MonthlyCharges              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PurchaseState                             = (PurchaseState)GetInt32(new IntPtr(p + 0x070)); // 0270D5094658 0x70 PurchaseState               ( 0001866B2F10 ModelEnumType PurchaseState PurchaseState PurchaseState Int32 )
            value.MaintenanceState                          = (MaintenanceState)GetInt32(new IntPtr(p + 0x074)); // 0270D5094678 0x74 MaintenanceState            ( 0001866B2320 ModelEnumType MaintenanceState MaintenanceState MaintenanceState Int32 )
            value.LocalSave                                 = GetObject<PurchaseLocalSave>(new IntPtr(p + 0x078), ReversePrism.DataModels.PurchaseLocalSave.FromPointer); // 0270D5094698 0x78 LocalSave                   ( 0001865DDA30 ModelClassType PurchaseLocalSave PurchaseLocalSave PurchaseLocalSave Pointer )
            value.BirthdayParam                             = GetObject<BirthdayParam>(new IntPtr(p + 0x090), ReversePrism.DataModels.BirthdayParam.FromPointer); // 0270D50946D8 0x90 BirthdayParam               ( 00018675F190 ModelClassType BirthdayParam BirthdayParam BirthdayParam Pointer )
            value.DeferredDocumentBody                      = GetString(new IntPtr(p + 0x098)); // 0270D50946F8 0x98 DeferredDocumentBody        ( 000186671910 ModelPrimitiveType string string string String )
            value.VerifySuccessStoreItems                   = GetObjectList<IStoreItemStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0270D5094718 0xA0 VerifySuccessStoreItems     ( 000185CE8CE8 ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )

            return value;
        }
    }
}

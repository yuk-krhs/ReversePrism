using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StoreItemList                            ModelClassListType List<IStoreItemStatus> List<IStoreItemStatus> List<IStoreItemStatus> Pointer
    // 018 ShopStoreItemList                        ModelClassListType List<IStoreItemStatus> List<IStoreItemStatus> List<IStoreItemStatus> Pointer
    // 020 ShopItemList                             ModelClassListType List<IShopItemStatus> List<IShopItemStatus> List<IShopItemStatus> Pointer
    // 028 SeasonPassItemList                       ModelClassListType List<ISeasonPassStoreItemStatus> List<ISeasonPassStoreItemStatus> List<ISeasonPassStoreItemStatus> Pointer
    // 030 LoginPassItemList                        ModelClassListType List<ILoginBonusPassStoreItemStatus> List<ILoginBonusPassStoreItemStatus> List<ILoginBonusPassStoreItemStatus> Pointer
    // 038 CostumeItemList                          ModelClassListType List<ICostumeShopItemStatus> List<ICostumeShopItemStatus> List<ICostumeShopItemStatus> Pointer
    // 040 CostumeStoreItemList                     ModelClassListType List<ICostumeStoreItemStatus> List<ICostumeStoreItemStatus> List<ICostumeStoreItemStatus> Pointer
    // 048 Purchase                                 ModelClassType IPurchase IPurchase IPurchase Pointer
    // 050 ShopService                              ModelClassType IAccessShopService IAccessShopService IAccessShopService Pointer
    // 058 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 060 MonthlyCharges                           ModelPrimitiveType int int int Int32
    // 068 expectedPriceDic                         Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 070 PurchaseState                            ModelEnumType PurchaseState PurchaseState PurchaseState Int32
    // 074 MaintenanceState                         ModelEnumType MaintenanceState MaintenanceState MaintenanceState Int32
    // 078 LocalSave                                ModelClassType PurchaseLocalSave PurchaseLocalSave PurchaseLocalSave Pointer
    // 080 errorParamater                           ValueTuple`2<ErrorCode, string> IL2CPP_TYPE_GENERICINST
    // 090 BirthdayParam                            ModelClassType BirthdayParam BirthdayParam BirthdayParam Pointer
    // 098 DeferredDocumentBody                     ModelPrimitiveType string string string String
    // 0A0 VerifySuccessStoreItems                  ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer
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
        public Purchase?                                Purchase                                { get; set; }
        public AccessShopService?                       ShopService                             { get; set; }
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

            value.StoreItemList                             = GetObjectList<StoreItemStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.StoreItemStatus.FromPointer); // 0x10 StoreItemList               ( ModelClassListType List<IStoreItemStatus> List<IStoreItemStatus> List<IStoreItemStatus> Pointer )
            value.ShopStoreItemList                         = GetObjectList<StoreItemStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoreItemStatus.FromPointer); // 0x18 ShopStoreItemList           ( ModelClassListType List<IStoreItemStatus> List<IStoreItemStatus> List<IStoreItemStatus> Pointer )
            value.ShopItemList                              = GetObjectList<ShopItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopItemStatus.FromPointer); // 0x20 ShopItemList                ( ModelClassListType List<IShopItemStatus> List<IShopItemStatus> List<IShopItemStatus> Pointer )
            value.SeasonPassItemList                        = GetObjectList<SeasonPassStoreItemStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.SeasonPassStoreItemStatus.FromPointer); // 0x28 SeasonPassItemList          ( ModelClassListType List<ISeasonPassStoreItemStatus> List<ISeasonPassStoreItemStatus> List<ISeasonPassStoreItemStatus> Pointer )
            value.LoginPassItemList                         = GetObjectList<LoginBonusPassStoreItemStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.LoginBonusPassStoreItemStatus.FromPointer); // 0x30 LoginPassItemList           ( ModelClassListType List<ILoginBonusPassStoreItemStatus> List<ILoginBonusPassStoreItemStatus> List<ILoginBonusPassStoreItemStatus> Pointer )
            value.CostumeItemList                           = GetObjectList<CostumeShopItemStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.CostumeShopItemStatus.FromPointer); // 0x38 CostumeItemList             ( ModelClassListType List<ICostumeShopItemStatus> List<ICostumeShopItemStatus> List<ICostumeShopItemStatus> Pointer )
            value.CostumeStoreItemList                      = GetObjectList<CostumeStoreItemStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.CostumeStoreItemStatus.FromPointer); // 0x40 CostumeStoreItemList        ( ModelClassListType List<ICostumeStoreItemStatus> List<ICostumeStoreItemStatus> List<ICostumeStoreItemStatus> Pointer )
            /*
            value.Purchase                                  = GetObject<IPurchase>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPurchase.FromPointer); // 0x48 Purchase                    ( ModelClassType IPurchase IPurchase IPurchase Pointer )
            value.ShopService                               = GetObject<IAccessShopService>(new IntPtr(p + 0x050), ReversePrism.DataModels.IAccessShopService.FromPointer); // 0x50 ShopService                 ( ModelClassType IAccessShopService IAccessShopService IAccessShopService Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x058)); // 0x58 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.MonthlyCharges                            = GetInt32(new IntPtr(p + 0x060)); // 0x60 MonthlyCharges              ( ModelPrimitiveType int int int Int32 )
            value.PurchaseState                             = (PurchaseState)GetInt32(new IntPtr(p + 0x070)); // 0x70 PurchaseState               ( ModelEnumType PurchaseState PurchaseState PurchaseState Int32 )
            value.MaintenanceState                          = (MaintenanceState)GetInt32(new IntPtr(p + 0x074)); // 0x74 MaintenanceState            ( ModelEnumType MaintenanceState MaintenanceState MaintenanceState Int32 )
            value.LocalSave                                 = GetObject<PurchaseLocalSave>(new IntPtr(p + 0x078), ReversePrism.DataModels.PurchaseLocalSave.FromPointer); // 0x78 LocalSave                   ( ModelClassType PurchaseLocalSave PurchaseLocalSave PurchaseLocalSave Pointer )
            value.BirthdayParam                             = GetObject<BirthdayParam>(new IntPtr(p + 0x090), ReversePrism.DataModels.BirthdayParam.FromPointer); // 0x90 BirthdayParam               ( ModelClassType BirthdayParam BirthdayParam BirthdayParam Pointer )
            value.DeferredDocumentBody                      = GetString(new IntPtr(p + 0x098)); // 0x98 DeferredDocumentBody        ( ModelPrimitiveType string string string String )
            value.VerifySuccessStoreItems                   = GetObjectList<IStoreItemStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IStoreItemStatus.FromPointer); // 0xA0 VerifySuccessStoreItems     ( ModelClassListType List`1<IStoreItemStatus> List`1<IStoreItemStatus> List<IStoreItemStatus> Pointer )
            */

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultTabType                           ShopItemType IL2CPP_TYPE_VALUETYPE
    // 010 TabOrderArray                            ModelEnumListType ShopItemType[] ShopItemType[] List<ShopItemType> Pointer
    // 018 ProductParams                            ModelClassListType List`1<ShopProductParam> List`1<ShopProductParam> List<ShopProductParam> Pointer
    // 020 HaveFreeJewel                            ModelPrimitiveType long long long Int64
    // 028 HavePaidJewel                            ModelPrimitiveType long long long Int64
    // 030 CurrentViewItemType                      ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 038 ViewTabTypeIdList                        ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 040 BirthdayParam                            ModelClassType BirthdayParam BirthdayParam BirthdayParam Pointer
    // 048 ShopLocalSaveData                        ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer
    // 050 ShopSeasonPassViewModel                  ModelClassType ShopSeasonPassViewModel ShopSeasonPassViewModel ShopSeasonPassViewModel Pointer
    // 058 ShopLoginBonusPassViewModel              ModelClassType ShopLoginBonusPassViewModel ShopLoginBonusPassViewModel ShopLoginBonusPassViewModel Pointer
    // 060 LoginBonusPassRewardViewModel            ModelClassType ShopLoginBonusPassRewardPopupViewModel ShopLoginBonusPassRewardPopupViewModel ShopLoginBonusPassRewardPopupViewModel Pointer
    // 068 ShopPassPurchaseConfirmViewModel         ModelClassType ShopPassPurchaseConfirmContentViewModel ShopPassPurchaseConfirmContentViewModel ShopPassPurchaseConfirmContentViewModel Pointer
    // 070 CostumeSellingViewModel                  ModelClassType ShopCostumeSellingViewModel ShopCostumeSellingViewModel ShopCostumeSellingViewModel Pointer
    public partial class ShopViewModel : DataModel
    {
        public List<ShopItemType>?                      TabOrderArray                           { get; set; }
        public List<ShopProductParam>?                  ProductParams                           { get; set; }
        public long                                     HaveFreeJewel                           { get; set; }
        public long                                     HavePaidJewel                           { get; set; }
        public ShopItemType                             CurrentViewItemType                     { get; set; }
        public List<int>?                               ViewTabTypeIdList                       { get; set; }
        public BirthdayParam?                           BirthdayParam                           { get; set; }
        public ShopLocalSave?                           ShopLocalSaveData                       { get; set; }
        public ShopSeasonPassViewModel?                 ShopSeasonPassViewModel                 { get; set; }
        public ShopLoginBonusPassViewModel?             ShopLoginBonusPassViewModel             { get; set; }
        public ShopLoginBonusPassRewardPopupViewModel?  LoginBonusPassRewardViewModel           { get; set; }
        public ShopPassPurchaseConfirmContentViewModel? ShopPassPurchaseConfirmViewModel        { get; set; }
        public ShopCostumeSellingViewModel?             CostumeSellingViewModel                 { get; set; }

        public static ShopViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopViewModel() { Pointer= p0 };

            value.TabOrderArray                             = GetEnumList<ShopItemType>(new IntPtr(p + 0x010)); // 0x10 TabOrderArray               ( ModelEnumListType ShopItemType[] ShopItemType[] List<ShopItemType> Pointer )
            value.ProductParams                             = GetObjectList<ShopProductParam>(new IntPtr(p + 0x018), ReversePrism.DataModels.ShopProductParam.FromPointer); // 0x18 ProductParams               ( ModelClassListType List`1<ShopProductParam> List`1<ShopProductParam> List<ShopProductParam> Pointer )
            value.HaveFreeJewel                             = GetInt64(new IntPtr(p + 0x020)); // 0x20 HaveFreeJewel               ( ModelPrimitiveType long long long Int64 )
            value.HavePaidJewel                             = GetInt64(new IntPtr(p + 0x028)); // 0x28 HavePaidJewel               ( ModelPrimitiveType long long long Int64 )
            value.CurrentViewItemType                       = (ShopItemType)GetInt32(new IntPtr(p + 0x030)); // 0x30 CurrentViewItemType         ( ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.ViewTabTypeIdList                         = GetInt32List(new IntPtr(p + 0x038)); // 0x38 ViewTabTypeIdList           ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.BirthdayParam                             = GetObject<BirthdayParam>(new IntPtr(p + 0x040), ReversePrism.DataModels.BirthdayParam.FromPointer); // 0x40 BirthdayParam               ( ModelClassType BirthdayParam BirthdayParam BirthdayParam Pointer )
            value.ShopLocalSaveData                         = GetObject<ShopLocalSave>(new IntPtr(p + 0x048), ReversePrism.DataModels.ShopLocalSave.FromPointer); // 0x48 ShopLocalSaveData           ( ModelClassType ShopLocalSave ShopLocalSave ShopLocalSave Pointer )
            value.ShopSeasonPassViewModel                   = GetObject<ShopSeasonPassViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.ShopSeasonPassViewModel.FromPointer); // 0x50 ShopSeasonPassViewModel     ( ModelClassType ShopSeasonPassViewModel ShopSeasonPassViewModel ShopSeasonPassViewModel Pointer )
            value.ShopLoginBonusPassViewModel               = GetObject<ShopLoginBonusPassViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.ShopLoginBonusPassViewModel.FromPointer); // 0x58 ShopLoginBonusPassViewModel ( ModelClassType ShopLoginBonusPassViewModel ShopLoginBonusPassViewModel ShopLoginBonusPassViewModel Pointer )
            value.LoginBonusPassRewardViewModel             = GetObject<ShopLoginBonusPassRewardPopupViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.ShopLoginBonusPassRewardPopupViewModel.FromPointer); // 0x60 LoginBonusPassRewardViewModel ( ModelClassType ShopLoginBonusPassRewardPopupViewModel ShopLoginBonusPassRewardPopupViewModel ShopLoginBonusPassRewardPopupViewModel Pointer )
            value.ShopPassPurchaseConfirmViewModel          = GetObject<ShopPassPurchaseConfirmContentViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.ShopPassPurchaseConfirmContentViewModel.FromPointer); // 0x68 ShopPassPurchaseConfirmViewModel ( ModelClassType ShopPassPurchaseConfirmContentViewModel ShopPassPurchaseConfirmContentViewModel ShopPassPurchaseConfirmContentViewModel Pointer )
            value.CostumeSellingViewModel                   = GetObject<ShopCostumeSellingViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.ShopCostumeSellingViewModel.FromPointer); // 0x70 CostumeSellingViewModel     ( ModelClassType ShopCostumeSellingViewModel ShopCostumeSellingViewModel ShopCostumeSellingViewModel Pointer )

            return value;
        }
    }
}

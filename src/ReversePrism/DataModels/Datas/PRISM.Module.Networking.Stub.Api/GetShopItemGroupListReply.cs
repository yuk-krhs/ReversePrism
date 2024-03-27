using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetShopItemGroupListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TotalBillingAmountFieldNumber            int IL2CPP_TYPE_I4
    // 018 TotalBillingAmount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 JewelGroupFieldNumber                    int IL2CPP_TYPE_I4
    // 020 JewelGroup                               00018675F2D0 ModelClassType ShopItemJewelGroupStatus ShopItemJewelGroupStatus ShopItemJewelGroupStatus Pointer
    // 000 ItemGroupFieldNumber                     int IL2CPP_TYPE_I4
    // 028 ItemGroup                                00018675EBC0 ModelClassType ShopItemItemGroupStatus ShopItemItemGroupStatus ShopItemItemGroupStatus Pointer
    // 000 SeasonPassGroupFieldNumber               int IL2CPP_TYPE_I4
    // 030 SeasonPassGroup                          000186760CF0 ModelClassType ShopItemSeasonPassGroupStatus ShopItemSeasonPassGroupStatus ShopItemSeasonPassGroupStatus Pointer
    // 000 LoginBonusPassGroupFieldNumber           int IL2CPP_TYPE_I4
    // 038 LoginBonusPassGroup                      00018675F9A0 ModelClassType ShopItemLoginBonusPassGroupStatus ShopItemLoginBonusPassGroupStatus ShopItemLoginBonusPassGroupStatus Pointer
    // 000 CostumeGroupFieldNumber                  int IL2CPP_TYPE_I4
    // 040 CostumeGroup                             00018675E4A0 ModelClassType ShopItemCostumeGroupStatus ShopItemCostumeGroupStatus ShopItemCostumeGroupStatus Pointer
    // 000 BirthdateFieldNumber                     int IL2CPP_TYPE_I4
    // 048 Birthdate                                000186671910 ModelPrimitiveType string string string String
    public partial class GetShopItemGroupListReply
    {
        public int                                      TotalBillingAmount                      { get; set; }
        public ShopItemJewelGroupStatus?                JewelGroup                              { get; set; }
        public ShopItemItemGroupStatus?                 ItemGroup                               { get; set; }
        public ShopItemSeasonPassGroupStatus?           SeasonPassGroup                         { get; set; }
        public ShopItemLoginBonusPassGroupStatus?       LoginBonusPassGroup                     { get; set; }
        public ShopItemCostumeGroupStatus?              CostumeGroup                            { get; set; }
        public string                                   Birthdate                               { get; set; }

        public static GetShopItemGroupListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetShopItemGroupListReply();

            value.TotalBillingAmount                        = GetInt32(new IntPtr(p + 0x018)); // 0270D27DEC78 0x18 TotalBillingAmount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.JewelGroup                                = GetObject<ShopItemJewelGroupStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopItemJewelGroupStatus.FromPointer); // 0270D27DECB8 0x20 JewelGroup                  ( 00018675F2D0 ModelClassType ShopItemJewelGroupStatus ShopItemJewelGroupStatus ShopItemJewelGroupStatus Pointer )
            value.ItemGroup                                 = GetObject<ShopItemItemGroupStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ShopItemItemGroupStatus.FromPointer); // 0270D27DECF8 0x28 ItemGroup                   ( 00018675EBC0 ModelClassType ShopItemItemGroupStatus ShopItemItemGroupStatus ShopItemItemGroupStatus Pointer )
            value.SeasonPassGroup                           = GetObject<ShopItemSeasonPassGroupStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ShopItemSeasonPassGroupStatus.FromPointer); // 0270D27DED38 0x30 SeasonPassGroup             ( 000186760CF0 ModelClassType ShopItemSeasonPassGroupStatus ShopItemSeasonPassGroupStatus ShopItemSeasonPassGroupStatus Pointer )
            value.LoginBonusPassGroup                       = GetObject<ShopItemLoginBonusPassGroupStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ShopItemLoginBonusPassGroupStatus.FromPointer); // 0270D27DED78 0x38 LoginBonusPassGroup         ( 00018675F9A0 ModelClassType ShopItemLoginBonusPassGroupStatus ShopItemLoginBonusPassGroupStatus ShopItemLoginBonusPassGroupStatus Pointer )
            value.CostumeGroup                              = GetObject<ShopItemCostumeGroupStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.ShopItemCostumeGroupStatus.FromPointer); // 0270D27DEDB8 0x40 CostumeGroup                ( 00018675E4A0 ModelClassType ShopItemCostumeGroupStatus ShopItemCostumeGroupStatus ShopItemCostumeGroupStatus Pointer )
            value.Birthdate                                 = GetString(new IntPtr(p + 0x048)); // 0270D27DEDF8 0x48 Birthdate                   ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}

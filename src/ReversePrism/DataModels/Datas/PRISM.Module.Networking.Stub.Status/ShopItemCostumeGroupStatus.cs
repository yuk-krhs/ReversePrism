using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ShopItemCostumeGroupStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ShopItemTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ShopItemType                             ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 000 CostumeShopItemListFieldNumber           int IL2CPP_TYPE_I4
    // 008 _repeated_costumeShopItemList_codec      FieldCodec`1<CostumeShopItemStatus> IL2CPP_TYPE_GENERICINST
    // 020 CostumeShopItemList                      ModelClassListType RepeatedField`1<CostumeShopItemStatus> RepeatedField`1<CostumeShopItemStatus> List<CostumeShopItemStatus> Pointer
    // 000 CostumeStoreItemListFieldNumber          int IL2CPP_TYPE_I4
    // 010 _repeated_costumeStoreItemList_codec     FieldCodec`1<CostumeStoreItemStatus> IL2CPP_TYPE_GENERICINST
    // 028 CostumeStoreItemList                     ModelClassListType RepeatedField`1<CostumeStoreItemStatus> RepeatedField`1<CostumeStoreItemStatus> List<CostumeStoreItemStatus> Pointer
    public partial class ShopItemCostumeGroupStatus : DataModel
    {
        public ShopItemType                             ShopItemType                            { get; set; }
        public List<CostumeShopItemStatus>?             CostumeShopItemList                     { get; set; }
        public List<CostumeStoreItemStatus>?            CostumeStoreItemList                    { get; set; }

        public static ShopItemCostumeGroupStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopItemCostumeGroupStatus() { Pointer= p0 };

            value.ShopItemType                              = (ShopItemType)GetInt32(new IntPtr(p + 0x018)); // 0x18 ShopItemType                ( ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.CostumeShopItemList                       = GetObjectList<CostumeShopItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.CostumeShopItemStatus.FromPointer); // 0x20 CostumeShopItemList         ( ModelClassListType RepeatedField`1<CostumeShopItemStatus> RepeatedField`1<CostumeShopItemStatus> List<CostumeShopItemStatus> Pointer )
            value.CostumeStoreItemList                      = GetObjectList<CostumeStoreItemStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.CostumeStoreItemStatus.FromPointer); // 0x28 CostumeStoreItemList        ( ModelClassListType RepeatedField`1<CostumeStoreItemStatus> RepeatedField`1<CostumeStoreItemStatus> List<CostumeStoreItemStatus> Pointer )

            return value;
        }
    }
}

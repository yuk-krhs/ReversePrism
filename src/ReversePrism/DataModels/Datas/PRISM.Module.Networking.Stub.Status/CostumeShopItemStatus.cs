using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CostumeShopItemStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCostumeShopItemCategoryIdFieldNumber  int IL2CPP_TYPE_I4
    // 018 MstCostumeShopItemCategoryId             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCostumeShopItemGroupIdFieldNumber     int IL2CPP_TYPE_I4
    // 01C MstCostumeShopItemGroupId                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ShopItemFieldNumber                      int IL2CPP_TYPE_I4
    // 020 ShopItem                                 000186761440 ModelClassType ShopItemStatus ShopItemStatus ShopItemStatus Pointer
    public partial class CostumeShopItemStatus : DataModel
    {
        public int                                      MstCostumeShopItemCategoryId            { get; set; }
        public int                                      MstCostumeShopItemGroupId               { get; set; }
        public ShopItemStatus?                          ShopItem                                { get; set; }

        public static CostumeShopItemStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeShopItemStatus() { Pointer= p0 };

            value.MstCostumeShopItemCategoryId              = GetInt32(new IntPtr(p + 0x018)); // 024662754DE8 0x18 MstCostumeShopItemCategoryId ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCostumeShopItemGroupId                 = GetInt32(new IntPtr(p + 0x01C)); // 024662754E28 0x1C MstCostumeShopItemGroupId   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ShopItem                                  = GetObject<ShopItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopItemStatus.FromPointer); // 024662754E68 0x20 ShopItem                    ( 000186761440 ModelClassType ShopItemStatus ShopItemStatus ShopItemStatus Pointer )

            return value;
        }
    }
}

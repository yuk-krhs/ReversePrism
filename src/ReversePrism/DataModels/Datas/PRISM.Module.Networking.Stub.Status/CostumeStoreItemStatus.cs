using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CostumeStoreItemStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCostumeShopItemCategoryIdFieldNumber  int IL2CPP_TYPE_I4
    // 018 MstCostumeShopItemCategoryId             ModelPrimitiveType int int int Int32
    // 000 MstCostumeShopItemGroupIdFieldNumber     int IL2CPP_TYPE_I4
    // 01C MstCostumeShopItemGroupId                ModelPrimitiveType int int int Int32
    // 000 StoreItemFieldNumber                     int IL2CPP_TYPE_I4
    // 020 StoreItem                                ModelClassType StoreItemStatus StoreItemStatus StoreItemStatus Pointer
    public partial class CostumeStoreItemStatus : DataModel
    {
        public int                                      MstCostumeShopItemCategoryId            { get; set; }
        public int                                      MstCostumeShopItemGroupId               { get; set; }
        public StoreItemStatus?                         StoreItem                               { get; set; }

        public static CostumeStoreItemStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeStoreItemStatus() { Pointer= p0 };

            value.MstCostumeShopItemCategoryId              = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstCostumeShopItemCategoryId ( ModelPrimitiveType int int int Int32 )
            value.MstCostumeShopItemGroupId                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstCostumeShopItemGroupId   ( ModelPrimitiveType int int int Int32 )
            value.StoreItem                                 = GetObject<StoreItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoreItemStatus.FromPointer); // 0x20 StoreItem                   ( ModelClassType StoreItemStatus StoreItemStatus StoreItemStatus Pointer )

            return value;
        }
    }
}

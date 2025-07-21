using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ShopItemItemGroupStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ShopItemTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ShopItemType                             ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 000 ShopItemListFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_shopItemList_codec             FieldCodec`1<ShopItemStatus> IL2CPP_TYPE_GENERICINST
    // 020 ShopItemList                             ModelClassListType RepeatedField`1<ShopItemStatus> RepeatedField`1<ShopItemStatus> List<ShopItemStatus> Pointer
    // 000 StoreItemListFieldNumber                 int IL2CPP_TYPE_I4
    // 010 _repeated_storeItemList_codec            FieldCodec`1<StoreItemStatus> IL2CPP_TYPE_GENERICINST
    // 028 StoreItemList                            ModelClassListType RepeatedField`1<StoreItemStatus> RepeatedField`1<StoreItemStatus> List<StoreItemStatus> Pointer
    public partial class ShopItemItemGroupStatus : DataModel
    {
        public ShopItemType                             ShopItemType                            { get; set; }
        public List<ShopItemStatus>?                    ShopItemList                            { get; set; }
        public List<StoreItemStatus>?                   StoreItemList                           { get; set; }

        public static ShopItemItemGroupStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopItemItemGroupStatus() { Pointer= p0 };

            value.ShopItemType                              = (ShopItemType)GetInt32(new IntPtr(p + 0x018)); // 0x18 ShopItemType                ( ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.ShopItemList                              = GetObjectList<ShopItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ShopItemStatus.FromPointer); // 0x20 ShopItemList                ( ModelClassListType RepeatedField`1<ShopItemStatus> RepeatedField`1<ShopItemStatus> List<ShopItemStatus> Pointer )
            value.StoreItemList                             = GetObjectList<StoreItemStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.StoreItemStatus.FromPointer); // 0x28 StoreItemList               ( ModelClassListType RepeatedField`1<StoreItemStatus> RepeatedField`1<StoreItemStatus> List<StoreItemStatus> Pointer )

            return value;
        }
    }
}

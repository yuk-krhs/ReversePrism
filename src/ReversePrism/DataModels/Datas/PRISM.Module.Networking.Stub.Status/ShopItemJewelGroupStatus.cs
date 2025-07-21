using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ShopItemJewelGroupStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ShopItemTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ShopItemType                             ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 000 StoreItemListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_storeItemList_codec            FieldCodec`1<StoreItemStatus> IL2CPP_TYPE_GENERICINST
    // 020 StoreItemList                            ModelClassListType RepeatedField`1<StoreItemStatus> RepeatedField`1<StoreItemStatus> List<StoreItemStatus> Pointer
    public partial class ShopItemJewelGroupStatus : DataModel
    {
        public ShopItemType                             ShopItemType                            { get; set; }
        public List<StoreItemStatus>?                   StoreItemList                           { get; set; }

        public static ShopItemJewelGroupStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopItemJewelGroupStatus() { Pointer= p0 };

            value.ShopItemType                              = (ShopItemType)GetInt32(new IntPtr(p + 0x018)); // 0x18 ShopItemType                ( ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.StoreItemList                             = GetObjectList<StoreItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.StoreItemStatus.FromPointer); // 0x20 StoreItemList               ( ModelClassListType RepeatedField`1<StoreItemStatus> RepeatedField`1<StoreItemStatus> List<StoreItemStatus> Pointer )

            return value;
        }
    }
}

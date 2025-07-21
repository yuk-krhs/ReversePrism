using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ShopItemSeasonPassGroupStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ShopItemTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ShopItemType                             ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 000 SeasonPassStoreItemListFieldNumber       int IL2CPP_TYPE_I4
    // 008 _repeated_seasonPassStoreItemList_codec  FieldCodec`1<SeasonPassStoreItemStatus> IL2CPP_TYPE_GENERICINST
    // 020 SeasonPassStoreItemList                  ModelClassListType RepeatedField`1<SeasonPassStoreItemStatus> RepeatedField`1<SeasonPassStoreItemStatus> List<SeasonPassStoreItemStatus> Pointer
    public partial class ShopItemSeasonPassGroupStatus : DataModel
    {
        public ShopItemType                             ShopItemType                            { get; set; }
        public List<SeasonPassStoreItemStatus>?         SeasonPassStoreItemList                 { get; set; }

        public static ShopItemSeasonPassGroupStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopItemSeasonPassGroupStatus() { Pointer= p0 };

            value.ShopItemType                              = (ShopItemType)GetInt32(new IntPtr(p + 0x018)); // 0x18 ShopItemType                ( ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.SeasonPassStoreItemList                   = GetObjectList<SeasonPassStoreItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SeasonPassStoreItemStatus.FromPointer); // 0x20 SeasonPassStoreItemList     ( ModelClassListType RepeatedField`1<SeasonPassStoreItemStatus> RepeatedField`1<SeasonPassStoreItemStatus> List<SeasonPassStoreItemStatus> Pointer )

            return value;
        }
    }
}

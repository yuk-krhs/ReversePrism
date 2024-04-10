using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ShopItemLoginBonusPassGroupStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ShopItemTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ShopItemType                             000186761B60 ModelEnumType ShopItemType ShopItemType ShopItemType Int32
    // 000 LoginBonusPassStoreItemListFieldNumber   int IL2CPP_TYPE_I4
    // 008 _repeated_loginBonusPassStoreItemList_codec FieldCodec`1<LoginBonusPassStoreItemStatus> IL2CPP_TYPE_GENERICINST
    // 020 LoginBonusPassStoreItemList              000185CE4C08 ModelClassListType RepeatedField`1<LoginBonusPassStoreItemStatus> RepeatedField`1<LoginBonusPassStoreItemStatus> List<LoginBonusPassStoreItemStatus> Pointer
    public partial class ShopItemLoginBonusPassGroupStatus : DataModel
    {
        public ShopItemType                             ShopItemType                            { get; set; }
        public List<LoginBonusPassStoreItemStatus>?     LoginBonusPassStoreItemList             { get; set; }

        public static ShopItemLoginBonusPassGroupStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopItemLoginBonusPassGroupStatus() { Pointer= p0 };

            value.ShopItemType                              = (ShopItemType)GetInt32(new IntPtr(p + 0x018)); // 024662760CE0 0x18 ShopItemType                ( 000186761B60 ModelEnumType ShopItemType ShopItemType ShopItemType Int32 )
            value.LoginBonusPassStoreItemList               = GetObjectList<LoginBonusPassStoreItemStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.LoginBonusPassStoreItemStatus.FromPointer); // 024662760D40 0x20 LoginBonusPassStoreItemList ( 000185CE4C08 ModelClassListType RepeatedField`1<LoginBonusPassStoreItemStatus> RepeatedField`1<LoginBonusPassStoreItemStatus> List<LoginBonusPassStoreItemStatus> Pointer )

            return value;
        }
    }
}

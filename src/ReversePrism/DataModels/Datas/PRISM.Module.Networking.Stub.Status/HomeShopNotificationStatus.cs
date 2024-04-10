using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<HomeShopNotificationStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstShopItemIdListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_mstShopItemIdList_codec        FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 018 MstShopItemIdList                        000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 MstStoreItemIdListFieldNumber            int IL2CPP_TYPE_I4
    // 010 _repeated_mstStoreItemIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 MstStoreItemIdList                       000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class HomeShopNotificationStatus : DataModel
    {
        public List<int>?                               MstShopItemIdList                       { get; set; }
        public List<int>?                               MstStoreItemIdList                      { get; set; }

        public static HomeShopNotificationStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeShopNotificationStatus() { Pointer= p0 };

            value.MstShopItemIdList                         = GetInt32List(new IntPtr(p + 0x018)); // 02466202B0F8 0x18 MstShopItemIdList           ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.MstStoreItemIdList                        = GetInt32List(new IntPtr(p + 0x020)); // 02466202B158 0x20 MstStoreItemIdList          ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}

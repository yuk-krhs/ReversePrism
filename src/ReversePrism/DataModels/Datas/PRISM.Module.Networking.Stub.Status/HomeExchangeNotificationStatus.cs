using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<HomeExchangeNotificationStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstExchangeGroupIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstExchangeGroupId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstExchangeProductIdListFieldNumber      int IL2CPP_TYPE_I4
    // 008 _repeated_mstExchangeProductIdList_codec FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 MstExchangeProductIdList                 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class HomeExchangeNotificationStatus
    {
        public int                                      MstExchangeGroupId                      { get; set; }
        public List<int>?                               MstExchangeProductIdList                { get; set; }

        public static HomeExchangeNotificationStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeExchangeNotificationStatus();

            value.MstExchangeGroupId                        = GetInt32(new IntPtr(p + 0x018)); // 0270D205E0E0 0x18 MstExchangeGroupId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstExchangeProductIdList                  = GetInt32List(new IntPtr(p + 0x020)); // 0270D205E140 0x20 MstExchangeProductIdList    ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}

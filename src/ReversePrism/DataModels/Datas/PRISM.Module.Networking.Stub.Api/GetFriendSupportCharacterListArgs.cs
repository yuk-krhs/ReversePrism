using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetFriendSupportCharacterListArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSupportCharacterIdListFieldNumber     int IL2CPP_TYPE_I4
    // 008 _repeated_mstSupportCharacterIdList_codec FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 MstSupportCharacterIdList                000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class GetFriendSupportCharacterListArgs : DataModel
    {
        public int                                      MstUnitId                               { get; set; }
        public List<int>?                               MstSupportCharacterIdList               { get; set; }

        public static GetFriendSupportCharacterListArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetFriendSupportCharacterListArgs() { Pointer= p0 };

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x018)); // 0246625392B8 0x18 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterIdList                 = GetInt32List(new IntPtr(p + 0x020)); // 024662539318 0x20 MstSupportCharacterIdList   ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}

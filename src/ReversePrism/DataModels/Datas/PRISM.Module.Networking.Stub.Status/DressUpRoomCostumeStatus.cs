using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<DressUpRoomCostumeStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DressUpRoomCostumeIdFieldNumber          int IL2CPP_TYPE_I4
    // 018 DressUpRoomCostumeId                     000186671910 ModelPrimitiveType string string string String
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCostumeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 024 MstCostumeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstHairstyleIdFieldNumber                int IL2CPP_TYPE_I4
    // 028 MstHairstyleId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstAccessoryIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_mstAccessoryIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 030 MstAccessoryIdList                       000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 DressUpRoomCostumeTypeFieldNumber        int IL2CPP_TYPE_I4
    // 038 DressUpRoomCostumeType                   000186700730 ModelEnumType DressUpRoomCostumeType DressUpRoomCostumeType DressUpRoomCostumeType Int32
    public partial class DressUpRoomCostumeStatus
    {
        public string                                   DressUpRoomCostumeId                    { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public int                                      MstCostumeId                            { get; set; }
        public int                                      MstHairstyleId                          { get; set; }
        public List<int>?                               MstAccessoryIdList                      { get; set; }
        public DressUpRoomCostumeType                   DressUpRoomCostumeType                  { get; set; }

        public static DressUpRoomCostumeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomCostumeStatus();

            value.DressUpRoomCostumeId                      = GetString(new IntPtr(p + 0x018)); // 0270D0FE3DC8 0x18 DressUpRoomCostumeId        ( 000186671910 ModelPrimitiveType string string string String )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x020)); // 0270D0FE3E08 0x20 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x024)); // 0270D0FE3E48 0x24 MstCostumeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstHairstyleId                            = GetInt32(new IntPtr(p + 0x028)); // 0270D0FE3E88 0x28 MstHairstyleId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstAccessoryIdList                        = GetInt32List(new IntPtr(p + 0x030)); // 0270D0FE3EE8 0x30 MstAccessoryIdList          ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.DressUpRoomCostumeType                    = (DressUpRoomCostumeType)GetInt32(new IntPtr(p + 0x038)); // 0270D0FE3F28 0x38 DressUpRoomCostumeType      ( 000186700730 ModelEnumType DressUpRoomCostumeType DressUpRoomCostumeType DressUpRoomCostumeType Int32 )

            return value;
        }
    }
}

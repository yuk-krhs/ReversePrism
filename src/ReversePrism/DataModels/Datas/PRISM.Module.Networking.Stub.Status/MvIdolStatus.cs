using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MvIdolStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCostumeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 01C MstCostumeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstHairstyleIdFieldNumber                int IL2CPP_TYPE_I4
    // 020 MstHairstyleId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstAccessoryIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_mstAccessoryIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 MstAccessoryIdList                       000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class MvIdolStatus
    {
        public int                                      MstIdolId                               { get; set; }
        public int                                      MstCostumeId                            { get; set; }
        public int                                      MstHairstyleId                          { get; set; }
        public List<int>?                               MstAccessoryIdList                      { get; set; }

        public static MvIdolStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MvIdolStatus();

            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D1367760 0x18 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x01C)); // 0270D13677A0 0x1C MstCostumeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstHairstyleId                            = GetInt32(new IntPtr(p + 0x020)); // 0270D13677E0 0x20 MstHairstyleId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstAccessoryIdList                        = GetInt32List(new IntPtr(p + 0x028)); // 0270D1367840 0x28 MstAccessoryIdList          ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )

            return value;
        }
    }
}

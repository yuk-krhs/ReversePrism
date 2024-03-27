using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetDressUpRoomCostumeListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CostumeListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_costumeList_codec              FieldCodec`1<DressUpRoomCostumeStatus> IL2CPP_TYPE_GENERICINST
    // 018 CostumeList                              000185CD3E38 ModelClassListType RepeatedField`1<DressUpRoomCostumeStatus> RepeatedField`1<DressUpRoomCostumeStatus> List<DressUpRoomCostumeStatus> Pointer
    // 000 IsCostumeUnlimitedFieldNumber            int IL2CPP_TYPE_I4
    // 020 IsCostumeUnlimited                       000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GetDressUpRoomCostumeListReply
    {
        public List<DressUpRoomCostumeStatus>?          CostumeList                             { get; set; }
        public bool                                     IsCostumeUnlimited                      { get; set; }

        public static GetDressUpRoomCostumeListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetDressUpRoomCostumeListReply();

            value.CostumeList                               = GetObjectList<DressUpRoomCostumeStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.DressUpRoomCostumeStatus.FromPointer); // 0270D0FDD190 0x18 CostumeList                 ( 000185CD3E38 ModelClassListType RepeatedField`1<DressUpRoomCostumeStatus> RepeatedField`1<DressUpRoomCostumeStatus> List<DressUpRoomCostumeStatus> Pointer )
            value.IsCostumeUnlimited                        = GetBool(new IntPtr(p + 0x020)); // 0270D0FDD1D0 0x20 IsCostumeUnlimited          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

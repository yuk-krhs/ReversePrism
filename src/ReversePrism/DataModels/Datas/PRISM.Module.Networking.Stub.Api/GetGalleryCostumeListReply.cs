using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetGalleryCostumeListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CostumeListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_costumeList_codec              FieldCodec`1<GalleryCostumeStatus> IL2CPP_TYPE_GENERICINST
    // 020 CostumeList                              000185CD9D08 ModelClassListType RepeatedField`1<GalleryCostumeStatus> RepeatedField`1<GalleryCostumeStatus> List<GalleryCostumeStatus> Pointer
    // 000 CostumeSetListFieldNumber                int IL2CPP_TYPE_I4
    // 010 _repeated_costumeSetList_codec           FieldCodec`1<GalleryCostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 028 CostumeSetList                           000185CD9AA8 ModelClassListType RepeatedField`1<GalleryCostumeSetStatus> RepeatedField`1<GalleryCostumeSetStatus> List<GalleryCostumeSetStatus> Pointer
    public partial class GetGalleryCostumeListReply
    {
        public int                                      MstCharacterInfoId                      { get; set; }
        public List<GalleryCostumeStatus>?              CostumeList                             { get; set; }
        public List<GalleryCostumeSetStatus>?           CostumeSetList                          { get; set; }

        public static GetGalleryCostumeListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetGalleryCostumeListReply();

            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x018)); // 0270042053C0 0x18 MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CostumeList                               = GetObjectList<GalleryCostumeStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GalleryCostumeStatus.FromPointer); // 027004205420 0x20 CostumeList                 ( 000185CD9D08 ModelClassListType RepeatedField`1<GalleryCostumeStatus> RepeatedField`1<GalleryCostumeStatus> List<GalleryCostumeStatus> Pointer )
            value.CostumeSetList                            = GetObjectList<GalleryCostumeSetStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.GalleryCostumeSetStatus.FromPointer); // 027004205480 0x28 CostumeSetList              ( 000185CD9AA8 ModelClassListType RepeatedField`1<GalleryCostumeSetStatus> RepeatedField`1<GalleryCostumeSetStatus> List<GalleryCostumeSetStatus> Pointer )

            return value;
        }
    }
}

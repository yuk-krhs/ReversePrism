using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GalleryCostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 CostumeTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 020 CostumeType                              000186637B40 ModelEnumType CostumeType CostumeType CostumeType Int32
    // 000 CostumeListFieldNumber                   int IL2CPP_TYPE_I4
    // 008 _repeated_costumeList_codec              FieldCodec`1<GalleryCostumeStatus> IL2CPP_TYPE_GENERICINST
    // 028 CostumeList                              000185CD9D08 ModelClassListType RepeatedField`1<GalleryCostumeStatus> RepeatedField`1<GalleryCostumeStatus> List<GalleryCostumeStatus> Pointer
    // 000 EnableFieldNumber                        int IL2CPP_TYPE_I4
    // 030 Enable                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GalleryCostumeSetStatus
    {
        public string                                   Name                                    { get; set; }
        public CostumeType                              CostumeType                             { get; set; }
        public List<GalleryCostumeStatus>?              CostumeList                             { get; set; }
        public bool                                     Enable                                  { get; set; }

        public static GalleryCostumeSetStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GalleryCostumeSetStatus();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 02700420AFC8 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.CostumeType                               = (CostumeType)GetInt32(new IntPtr(p + 0x020)); // 02700420B008 0x20 CostumeType                 ( 000186637B40 ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value.CostumeList                               = GetObjectList<GalleryCostumeStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.GalleryCostumeStatus.FromPointer); // 02700420B068 0x28 CostumeList                 ( 000185CD9D08 ModelClassListType RepeatedField`1<GalleryCostumeStatus> RepeatedField`1<GalleryCostumeStatus> List<GalleryCostumeStatus> Pointer )
            value.Enable                                    = GetBool(new IntPtr(p + 0x030)); // 02700420B0A8 0x30 Enable                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

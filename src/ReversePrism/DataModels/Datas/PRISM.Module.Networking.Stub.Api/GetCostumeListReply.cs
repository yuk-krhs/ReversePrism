using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetCostumeListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CostumeSetListFieldNumber                int IL2CPP_TYPE_I4
    // 008 _repeated_costumeSetList_codec           FieldCodec`1<CostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 018 CostumeSetList                           000185CD2998 ModelClassListType RepeatedField`1<CostumeSetStatus> RepeatedField`1<CostumeSetStatus> List<CostumeSetStatus> Pointer
    // 000 CostumeListFieldNumber                   int IL2CPP_TYPE_I4
    // 010 _repeated_costumeList_codec              FieldCodec`1<CostumeStatus> IL2CPP_TYPE_GENERICINST
    // 020 CostumeList                              000185CD2DF8 ModelClassListType RepeatedField`1<CostumeStatus> RepeatedField`1<CostumeStatus> List<CostumeStatus> Pointer
    // 000 HairstyleListFieldNumber                 int IL2CPP_TYPE_I4
    // 018 _repeated_hairstyleList_codec            FieldCodec`1<HairstyleStatus> IL2CPP_TYPE_GENERICINST
    // 028 HairstyleList                            000185CDDCF8 ModelClassListType RepeatedField`1<HairstyleStatus> RepeatedField`1<HairstyleStatus> List<HairstyleStatus> Pointer
    // 000 AccessoryListFieldNumber                 int IL2CPP_TYPE_I4
    // 020 _repeated_accessoryList_codec            FieldCodec`1<AccessoryStatus> IL2CPP_TYPE_GENERICINST
    // 030 AccessoryList                            000185CCD648 ModelClassListType RepeatedField`1<AccessoryStatus> RepeatedField`1<AccessoryStatus> List<AccessoryStatus> Pointer
    public partial class GetCostumeListReply
    {
        public List<CostumeSetStatus>?                  CostumeSetList                          { get; set; }
        public List<CostumeStatus>?                     CostumeList                             { get; set; }
        public List<HairstyleStatus>?                   HairstyleList                           { get; set; }
        public List<AccessoryStatus>?                   AccessoryList                           { get; set; }

        public static GetCostumeListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetCostumeListReply();

            value.CostumeSetList                            = GetObjectList<CostumeSetStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.CostumeSetStatus.FromPointer); // 0270D0D77AE8 0x18 CostumeSetList              ( 000185CD2998 ModelClassListType RepeatedField`1<CostumeSetStatus> RepeatedField`1<CostumeSetStatus> List<CostumeSetStatus> Pointer )
            value.CostumeList                               = GetObjectList<CostumeStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.CostumeStatus.FromPointer); // 0270D0D77B48 0x20 CostumeList                 ( 000185CD2DF8 ModelClassListType RepeatedField`1<CostumeStatus> RepeatedField`1<CostumeStatus> List<CostumeStatus> Pointer )
            value.HairstyleList                             = GetObjectList<HairstyleStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.HairstyleStatus.FromPointer); // 0270D0D77BA8 0x28 HairstyleList               ( 000185CDDCF8 ModelClassListType RepeatedField`1<HairstyleStatus> RepeatedField`1<HairstyleStatus> List<HairstyleStatus> Pointer )
            value.AccessoryList                             = GetObjectList<AccessoryStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.AccessoryStatus.FromPointer); // 0270D0D77C08 0x30 AccessoryList               ( 000185CCD648 ModelClassListType RepeatedField`1<AccessoryStatus> RepeatedField`1<AccessoryStatus> List<AccessoryStatus> Pointer )

            return value;
        }
    }
}

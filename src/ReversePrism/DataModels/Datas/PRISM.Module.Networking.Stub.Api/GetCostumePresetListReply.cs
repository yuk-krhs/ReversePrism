using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetCostumePresetListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CostumePresetListFieldNumber             int IL2CPP_TYPE_I4
    // 008 _repeated_costumePresetList_codec        FieldCodec`1<CostumePresetStatus> IL2CPP_TYPE_GENERICINST
    // 018 CostumePresetList                        000185CD2738 ModelClassListType RepeatedField`1<CostumePresetStatus> RepeatedField`1<CostumePresetStatus> List<CostumePresetStatus> Pointer
    public partial class GetCostumePresetListReply : DataModel
    {
        public List<CostumePresetStatus>?               CostumePresetList                       { get; set; }

        public static GetCostumePresetListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetCostumePresetListReply() { Pointer= p0 };

            value.CostumePresetList                         = GetObjectList<CostumePresetStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.CostumePresetStatus.FromPointer); // 0245A404F540 0x18 CostumePresetList           ( 000185CD2738 ModelClassListType RepeatedField`1<CostumePresetStatus> RepeatedField`1<CostumePresetStatus> List<CostumePresetStatus> Pointer )

            return value;
        }
    }
}

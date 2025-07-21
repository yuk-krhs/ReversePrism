using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetSpecialMissionListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SpecialMissionListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_specialMissionList_codec       FieldCodec`1<SpecialMissionStatus> IL2CPP_TYPE_GENERICINST
    // 018 SpecialMissionList                       ModelClassListType RepeatedField`1<SpecialMissionStatus> RepeatedField`1<SpecialMissionStatus> List<SpecialMissionStatus> Pointer
    public partial class GetSpecialMissionListReply : DataModel
    {
        public List<SpecialMissionStatus>?              SpecialMissionList                      { get; set; }

        public static GetSpecialMissionListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSpecialMissionListReply() { Pointer= p0 };

            value.SpecialMissionList                        = GetObjectList<SpecialMissionStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.SpecialMissionStatus.FromPointer); // 0x18 SpecialMissionList          ( ModelClassListType RepeatedField`1<SpecialMissionStatus> RepeatedField`1<SpecialMissionStatus> List<SpecialMissionStatus> Pointer )

            return value;
        }
    }
}

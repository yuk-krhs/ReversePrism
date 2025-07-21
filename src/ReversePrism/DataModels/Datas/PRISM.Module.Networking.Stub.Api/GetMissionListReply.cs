using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetMissionListReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MissionGroupListFieldNumber              int IL2CPP_TYPE_I4
    // 008 _repeated_missionGroupList_codec         FieldCodec`1<MissionGroupStatus> IL2CPP_TYPE_GENERICINST
    // 018 MissionGroupList                         ModelClassListType RepeatedField`1<MissionGroupStatus> RepeatedField`1<MissionGroupStatus> List<MissionGroupStatus> Pointer
    public partial class GetMissionListReply : DataModel
    {
        public List<MissionGroupStatus>?                MissionGroupList                        { get; set; }

        public static GetMissionListReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetMissionListReply() { Pointer= p0 };

            value.MissionGroupList                          = GetObjectList<MissionGroupStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.MissionGroupStatus.FromPointer); // 0x18 MissionGroupList            ( ModelClassListType RepeatedField`1<MissionGroupStatus> RepeatedField`1<MissionGroupStatus> List<MissionGroupStatus> Pointer )

            return value;
        }
    }
}

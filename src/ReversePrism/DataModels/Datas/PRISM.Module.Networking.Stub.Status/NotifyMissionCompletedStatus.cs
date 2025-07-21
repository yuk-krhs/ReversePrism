using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<NotifyMissionCompletedStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 CompletedListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_completedList_codec            FieldCodec`1<MissionCompletedStatus> IL2CPP_TYPE_GENERICINST
    // 018 CompletedList                            ModelClassListType RepeatedField`1<MissionCompletedStatus> RepeatedField`1<MissionCompletedStatus> List<MissionCompletedStatus> Pointer
    // 000 AndMoreFieldNumber                       int IL2CPP_TYPE_I4
    // 020 AndMore                                  ModelPrimitiveType int int int Int32
    public partial class NotifyMissionCompletedStatus : DataModel
    {
        public List<MissionCompletedStatus>?            CompletedList                           { get; set; }
        public int                                      AndMore                                 { get; set; }

        public static NotifyMissionCompletedStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NotifyMissionCompletedStatus() { Pointer= p0 };

            value.CompletedList                             = GetObjectList<MissionCompletedStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.MissionCompletedStatus.FromPointer); // 0x18 CompletedList               ( ModelClassListType RepeatedField`1<MissionCompletedStatus> RepeatedField`1<MissionCompletedStatus> List<MissionCompletedStatus> Pointer )
            value.AndMore                                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 AndMore                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ScheduleTypeFieldNumber                  int IL2CPP_TYPE_I4
    // 018 ScheduleType                             0001866E4270 ModelEnumType ScheduleType ScheduleType ScheduleType Int32
    // 000 ScheduleStateFieldNumber                 int IL2CPP_TYPE_I4
    // 01C ScheduleState                            0001866E2F10 ModelEnumType ScheduleState ScheduleState ScheduleState Int32
    // 000 ScheduleDetailListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_scheduleDetailList_codec       FieldCodec`1<ScheduleDetailStatus> IL2CPP_TYPE_GENERICINST
    // 020 ScheduleDetailList                       000185CEF358 ModelClassListType RepeatedField`1<ScheduleDetailStatus> RepeatedField`1<ScheduleDetailStatus> List<ScheduleDetailStatus> Pointer
    public partial class ScheduleStatus
    {
        public ScheduleType                             ScheduleType                            { get; set; }
        public ScheduleState                            ScheduleState                           { get; set; }
        public List<ScheduleDetailStatus>?              ScheduleDetailList                      { get; set; }

        public static ScheduleStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleStatus();

            value.ScheduleType                              = (ScheduleType)GetInt32(new IntPtr(p + 0x018)); // 0270041CA2D8 0x18 ScheduleType                ( 0001866E4270 ModelEnumType ScheduleType ScheduleType ScheduleType Int32 )
            value.ScheduleState                             = (ScheduleState)GetInt32(new IntPtr(p + 0x01C)); // 0270041CA318 0x1C ScheduleState               ( 0001866E2F10 ModelEnumType ScheduleState ScheduleState ScheduleState Int32 )
            value.ScheduleDetailList                        = GetObjectList<ScheduleDetailStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScheduleDetailStatus.FromPointer); // 0270041CA378 0x20 ScheduleDetailList          ( 000185CEF358 ModelClassListType RepeatedField`1<ScheduleDetailStatus> RepeatedField`1<ScheduleDetailStatus> List<ScheduleDetailStatus> Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceAutoPlayProgressedSeasonStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TermFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Term                                     00018652DC30 ModelClassType ProduceAutoPlayProgressedTermStatus ProduceAutoPlayProgressedTermStatus ProduceAutoPlayProgressedTermStatus Pointer
    // 000 ScheduleListFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_scheduleList_codec             FieldCodec`1<ProduceAutoProgressedScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 020 ScheduleList                             000185CEAAB8 ModelClassListType RepeatedField`1<ProduceAutoProgressedScheduleStatus> RepeatedField`1<ProduceAutoProgressedScheduleStatus> List<ProduceAutoProgressedScheduleStatus> Pointer
    public partial class ProduceAutoPlayProgressedSeasonStatus
    {
        public ProduceAutoPlayProgressedTermStatus?     Term                                    { get; set; }
        public List<ProduceAutoProgressedScheduleStatus>? ScheduleList                            { get; set; }

        public static ProduceAutoPlayProgressedSeasonStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoPlayProgressedSeasonStatus();

            value.Term                                      = GetObject<ProduceAutoPlayProgressedTermStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceAutoPlayProgressedTermStatus.FromPointer); // 0270D11056B0 0x18 Term                        ( 00018652DC30 ModelClassType ProduceAutoPlayProgressedTermStatus ProduceAutoPlayProgressedTermStatus ProduceAutoPlayProgressedTermStatus Pointer )
            value.ScheduleList                              = GetObjectList<ProduceAutoProgressedScheduleStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceAutoProgressedScheduleStatus.FromPointer); // 0270D1105710 0x20 ScheduleList                ( 000185CEAAB8 ModelClassListType RepeatedField`1<ProduceAutoProgressedScheduleStatus> RepeatedField`1<ProduceAutoProgressedScheduleStatus> List<ProduceAutoProgressedScheduleStatus> Pointer )

            return value;
        }
    }
}

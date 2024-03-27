using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EventScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 EventScheduleIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 EventScheduleId                          000186671910 ModelPrimitiveType string string string String
    // 000 EventScheduleTypeFieldNumber             int IL2CPP_TYPE_I4
    // 020 EventScheduleType                        000186767070 ModelEnumType EventScheduleType EventScheduleType EventScheduleType Int32
    // 000 DisplayPriorityFieldNumber               int IL2CPP_TYPE_I4
    // 024 DisplayPriority                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ImageUrlFieldNumber                      int IL2CPP_TYPE_I4
    // 028 ImageUrl                                 000186671910 ModelPrimitiveType string string string String
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Title                                    000186671910 ModelPrimitiveType string string string String
    // 000 TagListFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_tagList_codec                  FieldCodec`1<EventScheduleTagStatus> IL2CPP_TYPE_GENERICINST
    // 038 TagList                                  000185CD5FD8 ModelClassListType RepeatedField`1<EventScheduleTagStatus> RepeatedField`1<EventScheduleTagStatus> List<EventScheduleTagStatus> Pointer
    // 000 PeriodFieldNumber                        int IL2CPP_TYPE_I4
    // 040 Period                                   000186734A00 ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 DisplayPeriodFieldNumber                 int IL2CPP_TYPE_I4
    // 048 DisplayPeriod                            000186734A00 ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 JumpFieldNumber                          int IL2CPP_TYPE_I4
    // 050 Jump                                     000186768670 ModelClassType JumpStatus JumpStatus JumpStatus Pointer
    public partial class EventScheduleStatus
    {
        public string                                   EventScheduleId                         { get; set; }
        public EventScheduleType                        EventScheduleType                       { get; set; }
        public int                                      DisplayPriority                         { get; set; }
        public string                                   ImageUrl                                { get; set; }
        public string                                   Title                                   { get; set; }
        public List<EventScheduleTagStatus>?            TagList                                 { get; set; }
        public PeriodStatus?                            Period                                  { get; set; }
        public PeriodStatus?                            DisplayPeriod                           { get; set; }
        public JumpStatus?                              Jump                                    { get; set; }

        public static EventScheduleStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventScheduleStatus();

            value.EventScheduleId                           = GetString(new IntPtr(p + 0x018)); // 0270D108E118 0x18 EventScheduleId             ( 000186671910 ModelPrimitiveType string string string String )
            value.EventScheduleType                         = (EventScheduleType)GetInt32(new IntPtr(p + 0x020)); // 0270D108E158 0x20 EventScheduleType           ( 000186767070 ModelEnumType EventScheduleType EventScheduleType EventScheduleType Int32 )
            value.DisplayPriority                           = GetInt32(new IntPtr(p + 0x024)); // 0270D108E198 0x24 DisplayPriority             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ImageUrl                                  = GetString(new IntPtr(p + 0x028)); // 0270D108E1D8 0x28 ImageUrl                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x030)); // 0270D108E218 0x30 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.TagList                                   = GetObjectList<EventScheduleTagStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.EventScheduleTagStatus.FromPointer); // 0270D108E278 0x38 TagList                     ( 000185CD5FD8 ModelClassListType RepeatedField`1<EventScheduleTagStatus> RepeatedField`1<EventScheduleTagStatus> List<EventScheduleTagStatus> Pointer )
            value.Period                                    = GetObject<PeriodStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0270D108E2B8 0x40 Period                      ( 000186734A00 ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value.DisplayPeriod                             = GetObject<PeriodStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0270D108E2F8 0x48 DisplayPeriod               ( 000186734A00 ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value.Jump                                      = GetObject<JumpStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.JumpStatus.FromPointer); // 0270D108E338 0x50 Jump                        ( 000186768670 ModelClassType JumpStatus JumpStatus JumpStatus Pointer )

            return value;
        }
    }
}

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
    // 018 EventScheduleId                          ModelPrimitiveType string string string String
    // 000 EventScheduleTypeFieldNumber             int IL2CPP_TYPE_I4
    // 020 EventScheduleType                        ModelEnumType EventScheduleType EventScheduleType EventScheduleType Int32
    // 000 DisplayPriorityFieldNumber               int IL2CPP_TYPE_I4
    // 024 DisplayPriority                          ModelPrimitiveType int int int Int32
    // 000 ImageUrlFieldNumber                      int IL2CPP_TYPE_I4
    // 028 ImageUrl                                 ModelPrimitiveType string string string String
    // 000 TitleFieldNumber                         int IL2CPP_TYPE_I4
    // 030 Title                                    ModelPrimitiveType string string string String
    // 000 TagListFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_tagList_codec                  FieldCodec`1<EventScheduleTagStatus> IL2CPP_TYPE_GENERICINST
    // 038 TagList                                  ModelClassListType RepeatedField`1<EventScheduleTagStatus> RepeatedField`1<EventScheduleTagStatus> List<EventScheduleTagStatus> Pointer
    // 000 PeriodFieldNumber                        int IL2CPP_TYPE_I4
    // 040 Period                                   ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 DisplayPeriodFieldNumber                 int IL2CPP_TYPE_I4
    // 048 DisplayPeriod                            ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 JumpFieldNumber                          int IL2CPP_TYPE_I4
    // 050 Jump                                     ModelClassType JumpStatus JumpStatus JumpStatus Pointer
    public partial class EventScheduleStatus : DataModel
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
            var value   = new EventScheduleStatus() { Pointer= p0 };

            value.EventScheduleId                           = GetString(new IntPtr(p + 0x018)); // 0x18 EventScheduleId             ( ModelPrimitiveType string string string String )
            value.EventScheduleType                         = (EventScheduleType)GetInt32(new IntPtr(p + 0x020)); // 0x20 EventScheduleType           ( ModelEnumType EventScheduleType EventScheduleType EventScheduleType Int32 )
            value.DisplayPriority                           = GetInt32(new IntPtr(p + 0x024)); // 0x24 DisplayPriority             ( ModelPrimitiveType int int int Int32 )
            value.ImageUrl                                  = GetString(new IntPtr(p + 0x028)); // 0x28 ImageUrl                    ( ModelPrimitiveType string string string String )
            value.Title                                     = GetString(new IntPtr(p + 0x030)); // 0x30 Title                       ( ModelPrimitiveType string string string String )
            value.TagList                                   = GetObjectList<EventScheduleTagStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.EventScheduleTagStatus.FromPointer); // 0x38 TagList                     ( ModelClassListType RepeatedField`1<EventScheduleTagStatus> RepeatedField`1<EventScheduleTagStatus> List<EventScheduleTagStatus> Pointer )
            value.Period                                    = GetObject<PeriodStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0x40 Period                      ( ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value.DisplayPeriod                             = GetObject<PeriodStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0x48 DisplayPeriod               ( ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value.Jump                                      = GetObject<JumpStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.JumpStatus.FromPointer); // 0x50 Jump                        ( ModelClassType JumpStatus JumpStatus JumpStatus Pointer )

            return value;
        }
    }
}

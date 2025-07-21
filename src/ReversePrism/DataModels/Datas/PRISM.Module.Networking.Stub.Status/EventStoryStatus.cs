using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<EventStoryStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StoryFieldNumber                         int IL2CPP_TYPE_I4
    // 018 Story                                    ModelClassType StoryStatus StoryStatus StoryStatus Pointer
    // 000 MstEventIdFieldNumber                    int IL2CPP_TYPE_I4
    // 020 MstEventId                               ModelPrimitiveType int int int Int32
    // 000 EventPeriodFieldNumber                   int IL2CPP_TYPE_I4
    // 028 EventPeriod                              ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer
    // 000 EventTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 030 EventType                                ModelEnumType GameEventType GameEventType GameEventType Int32
    // 000 MstUnitIdFieldNumber                     int IL2CPP_TYPE_I4
    // 034 MstUnitId                                ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseMstEventStoryIdFieldNumber  int IL2CPP_TYPE_I4
    // 038 UnlockPremiseMstEventStoryId             ModelPrimitiveType int int int Int32
    // 000 UnlockPremiseEventPointFieldNumber       int IL2CPP_TYPE_I4
    // 03C UnlockPremiseEventPoint                  ModelPrimitiveType int int int Int32
    public partial class EventStoryStatus : DataModel
    {
        public StoryStatus?                             Story                                   { get; set; }
        public int                                      MstEventId                              { get; set; }
        public PeriodStatus?                            EventPeriod                             { get; set; }
        public GameEventType                            EventType                               { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      UnlockPremiseMstEventStoryId            { get; set; }
        public int                                      UnlockPremiseEventPoint                 { get; set; }

        public static EventStoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryStatus() { Pointer= p0 };

            value.Story                                     = GetObject<StoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.StoryStatus.FromPointer); // 0x18 Story                       ( ModelClassType StoryStatus StoryStatus StoryStatus Pointer )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value.EventPeriod                               = GetObject<PeriodStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.PeriodStatus.FromPointer); // 0x28 EventPeriod                 ( ModelClassType PeriodStatus PeriodStatus PeriodStatus Pointer )
            value.EventType                                 = (GameEventType)GetInt32(new IntPtr(p + 0x030)); // 0x30 EventType                   ( ModelEnumType GameEventType GameEventType GameEventType Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x034)); // 0x34 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseMstEventStoryId              = GetInt32(new IntPtr(p + 0x038)); // 0x38 UnlockPremiseMstEventStoryId ( ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseEventPoint                   = GetInt32(new IntPtr(p + 0x03C)); // 0x3C UnlockPremiseEventPoint     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

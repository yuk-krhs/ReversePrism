using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 eventListScheduleScrollPositions         Dictionary`2<int, float> IL2CPP_TYPE_GENERICINST
    // 018 CurrentSelectedEventTab                  ModelPrimitiveType int int int Int32
    // 020 <AllEventScheduleList>k__BackingField    ReadOnlyCollection`1<IEventScheduleStatus> IL2CPP_TYPE_GENERICINST
    // 028 <EventScheduleLists>k__BackingField      IReadOnlyDictionary`2<EventScheduleType, ReadOnlyCollection`1<IEventScheduleStatus>> IL2CPP_TYPE_GENERICINST
    public partial class EventListOverlayModel : DataModel
    {
        public int                                      CurrentSelectedEventTab                 { get; set; }

        public static EventListOverlayModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventListOverlayModel() { Pointer= p0 };

            value.CurrentSelectedEventTab                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 CurrentSelectedEventTab     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

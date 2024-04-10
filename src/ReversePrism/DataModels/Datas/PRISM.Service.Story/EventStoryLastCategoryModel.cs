using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventId                                  0001865F4260 ModelPrimitiveType int int int Int32
    // 018 EventStories                             000185CF5DB8 ModelClassListType IReadOnlyList`1<IEventStoryStatus> IReadOnlyList`1<IEventStoryStatus> List<IEventStoryStatus> Pointer
    public partial class EventStoryLastCategoryModel : DataModel
    {
        public int                                      EventId                                 { get; set; }
        public List<IEventStoryStatus>?                 EventStories                            { get; set; }

        public static EventStoryLastCategoryModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryLastCategoryModel() { Pointer= p0 };

            value.EventId                                   = GetInt32(new IntPtr(p + 0x010)); // 0246667F89B8 0x10 EventId                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EventStories                              = GetObjectList<IEventStoryStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEventStoryStatus.FromPointer); // 0246667F89D8 0x18 EventStories                ( 000185CF5DB8 ModelClassListType IReadOnlyList`1<IEventStoryStatus> IReadOnlyList`1<IEventStoryStatus> List<IEventStoryStatus> Pointer )

            return value;
        }
    }
}

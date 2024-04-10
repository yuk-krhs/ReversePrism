using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Legacy                                   000186769310 ModelClassType EventStoryLastCategoryArgumentForLegacy EventStoryLastCategoryArgumentForLegacy EventStoryLastCategoryArgumentForLegacy Pointer
    public partial class EventStoryLastCategoryArgument : DataModel
    {
        public EventStoryLastCategoryArgumentForLegacy? Legacy                                  { get; set; }

        public static EventStoryLastCategoryArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryLastCategoryArgument() { Pointer= p0 };

            value.Legacy                                    = GetObject<EventStoryLastCategoryArgumentForLegacy>(new IntPtr(p + 0x010), ReversePrism.DataModels.EventStoryLastCategoryArgumentForLegacy.FromPointer); // 0246667F3260 0x10 Legacy                      ( 000186769310 ModelClassType EventStoryLastCategoryArgumentForLegacy EventStoryLastCategoryArgumentForLegacy EventStoryLastCategoryArgumentForLegacy Pointer )

            return value;
        }
    }
}

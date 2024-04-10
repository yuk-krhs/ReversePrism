using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018676B4B0 ModelClassType EventStoryLastCategoryView EventStoryLastCategoryView EventStoryLastCategoryView Pointer
    public partial class EventStoryLastCategoryBuilder : DataModel
    {
        public EventStoryLastCategoryView?              View                                    { get; set; }

        public static EventStoryLastCategoryBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventStoryLastCategoryBuilder() { Pointer= p0 };

            value.View                                      = GetObject<EventStoryLastCategoryView>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventStoryLastCategoryView.FromPointer); // 02466B6D2B58 0x20 View                        ( 00018676B4B0 ModelClassType EventStoryLastCategoryView EventStoryLastCategoryView EventStoryLastCategoryView Pointer )

            return value;
        }
    }
}

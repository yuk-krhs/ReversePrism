using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 ModelEnumType EventCategory EventCategory EventCategory Int32
    public partial class EventCategoryAttribute : DataModel
    {
        public EventCategory                            Category                                { get; set; }

        public static EventCategoryAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventCategoryAttribute() { Pointer= p0 };

            value.Category                                  = (EventCategory)GetInt32(new IntPtr(p + 0x010)); // 0x10 Category                    ( ModelEnumType EventCategory EventCategory EventCategory Int32 )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Category                                 000186751B10 ModelEnumType EventCategory EventCategory EventCategory Int32
    public partial class EventCategoryAttribute
    {
        public EventCategory                            Category                                { get; set; }

        public static EventCategoryAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventCategoryAttribute();

            value.Category                                  = (EventCategory)GetInt32(new IntPtr(p + 0x010)); // 02700685A3B8 0x10 Category                    ( 000186751B10 ModelEnumType EventCategory EventCategory EventCategory Int32 )

            return value;
        }
    }
}

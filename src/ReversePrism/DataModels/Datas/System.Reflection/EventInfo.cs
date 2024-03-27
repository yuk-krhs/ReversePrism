using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cached_add_event                         000186632900 ModelClassType AddEventAdapter AddEventAdapter AddEventAdapter Pointer
    public partial class EventInfo
    {
        public AddEventAdapter?                         Cached_add_event                        { get; set; }

        public static EventInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventInfo();

            value.Cached_add_event                          = GetObject<AddEventAdapter>(new IntPtr(p + 0x010), ReversePrism.DataModels.AddEventAdapter.FromPointer); // 0270034B7158 0x10 Cached_add_event            ( 000186632900 ModelClassType AddEventAdapter AddEventAdapter AddEventAdapter Pointer )

            return value;
        }
    }
}

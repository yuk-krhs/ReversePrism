using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Dispatcher                             0001867559F0 ModelClassType EventDispatcher EventDispatcher EventDispatcher Pointer
    public partial class EventDispatcherGate
    {
        public EventDispatcher?                         M_Dispatcher                            { get; set; }

        public static EventDispatcherGate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventDispatcherGate();

            value.M_Dispatcher                              = GetObject<EventDispatcher>(new IntPtr(p + 0x010), ReversePrism.DataModels.EventDispatcher.FromPointer); // 027006758A30 0x10 M_Dispatcher                ( 0001867559F0 ModelClassType EventDispatcher EventDispatcher EventDispatcher Pointer )

            return value;
        }
    }
}

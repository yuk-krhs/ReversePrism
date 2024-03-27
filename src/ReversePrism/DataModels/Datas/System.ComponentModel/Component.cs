using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EventDisposed                            <object> IL2CPP_TYPE_OBJECT
    // 018 Site                                     000186646860 ModelClassType ISite ISite ISite Pointer
    // 020 Events                                   000186757970 ModelClassType EventHandlerList EventHandlerList EventHandlerList Pointer
    public partial class Component
    {
        public ISite?                                   Site                                    { get; set; }
        public EventHandlerList?                        Events                                  { get; set; }

        public static Component? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Component();

            value.Site                                      = GetObject<ISite>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISite.FromPointer); // 027004D1BE48 0x18 Site                        ( 000186646860 ModelClassType ISite ISite ISite Pointer )
            value.Events                                    = GetObject<EventHandlerList>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventHandlerList.FromPointer); // 027004D1BE68 0x20 Events                      ( 000186757970 ModelClassType EventHandlerList EventHandlerList EventHandlerList Pointer )

            return value;
        }
    }
}

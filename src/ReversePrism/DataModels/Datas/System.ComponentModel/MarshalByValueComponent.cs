using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_eventDisposed                          <object> IL2CPP_TYPE_OBJECT
    // 010 Site                                     000186646860 ModelClassType ISite ISite ISite Pointer
    // 018 Events                                   000186757970 ModelClassType EventHandlerList EventHandlerList EventHandlerList Pointer
    public partial class MarshalByValueComponent : DataModel
    {
        public ISite?                                   Site                                    { get; set; }
        public EventHandlerList?                        Events                                  { get; set; }

        public static MarshalByValueComponent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MarshalByValueComponent() { Pointer= p0 };

            value.Site                                      = GetObject<ISite>(new IntPtr(p + 0x010), ReversePrism.DataModels.ISite.FromPointer); // 0245A60302A8 0x10 Site                        ( 000186646860 ModelClassType ISite ISite ISite Pointer )
            value.Events                                    = GetObject<EventHandlerList>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventHandlerList.FromPointer); // 0245A60302C8 0x18 Events                      ( 000186757970 ModelClassType EventHandlerList EventHandlerList EventHandlerList Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EventDisposed                            <object> IL2CPP_TYPE_OBJECT
    // 018 Site                                     ModelClassType ISite ISite ISite Pointer
    // 020 Events                                   ModelClassType EventHandlerList EventHandlerList EventHandlerList Pointer
    public partial class Component : DataModel
    {
        public ISite?                                   Site                                    { get; set; }
        public EventHandlerList?                        Events                                  { get; set; }

        public static Component? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Component() { Pointer= p0 };

            value.Site                                      = GetObject<ISite>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISite.FromPointer); // 0x18 Site                        ( ModelClassType ISite ISite ISite Pointer )
            value.Events                                    = GetObject<EventHandlerList>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventHandlerList.FromPointer); // 0x20 Events                      ( ModelClassType EventHandlerList EventHandlerList EventHandlerList Pointer )

            return value;
        }
    }
}

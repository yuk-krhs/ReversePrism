using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Head                                     000186631A10 ModelClassType ListEntry ListEntry ListEntry Pointer
    // 018 Parent                                   0001865F2400 ModelClassType Component Component Component Pointer
    public partial class EventHandlerList
    {
        public ListEntry?                               Head                                    { get; set; }
        public Component?                               Parent                                  { get; set; }

        public static EventHandlerList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventHandlerList();

            value.Head                                      = GetObject<ListEntry>(new IntPtr(p + 0x010), ReversePrism.DataModels.ListEntry.FromPointer); // 0270D7B14680 0x10 Head                        ( 000186631A10 ModelClassType ListEntry ListEntry ListEntry Pointer )
            value.Parent                                    = GetObject<Component>(new IntPtr(p + 0x018), ReversePrism.DataModels.Component.FromPointer); // 0270D7B146A0 0x18 Parent                      ( 0001865F2400 ModelClassType Component Component Component Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Head                                     ModelClassType ListEntry ListEntry ListEntry Pointer
    // 018 Parent                                   ModelClassType Component Component Component Pointer
    public partial class EventHandlerList : DataModel
    {
        public ListEntry?                               Head                                    { get; set; }
        public Component?                               Parent                                  { get; set; }

        public static EventHandlerList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventHandlerList() { Pointer= p0 };

            value.Head                                      = GetObject<ListEntry>(new IntPtr(p + 0x010), ReversePrism.DataModels.ListEntry.FromPointer); // 0x10 Head                        ( ModelClassType ListEntry ListEntry ListEntry Pointer )
            value.Parent                                    = GetObject<Component>(new IntPtr(p + 0x018), ReversePrism.DataModels.Component.FromPointer); // 0x18 Parent                      ( ModelClassType Component Component Component Pointer )

            return value;
        }
    }
}

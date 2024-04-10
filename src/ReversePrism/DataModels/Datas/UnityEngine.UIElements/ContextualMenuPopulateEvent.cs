using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 Menu                                     0001867078C0 ModelClassType DropdownMenu DropdownMenu DropdownMenu Pointer
    // 0C8 TriggerEvent                             00018674E660 ModelClassType EventBase EventBase EventBase Pointer
    // 0D0 M_ContextualMenuManager                  000186618780 ModelClassType ContextualMenuManager ContextualMenuManager ContextualMenuManager Pointer
    public partial class ContextualMenuPopulateEvent : DataModel
    {
        public DropdownMenu?                            Menu                                    { get; set; }
        public EventBase?                               TriggerEvent                            { get; set; }
        public ContextualMenuManager?                   M_ContextualMenuManager                 { get; set; }

        public static ContextualMenuPopulateEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ContextualMenuPopulateEvent() { Pointer= p0 };

            value.Menu                                      = GetObject<DropdownMenu>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.DropdownMenu.FromPointer); // 0245A6751E48 0xC0 Menu                        ( 0001867078C0 ModelClassType DropdownMenu DropdownMenu DropdownMenu Pointer )
            value.TriggerEvent                              = GetObject<EventBase>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.EventBase.FromPointer); // 0245A6751E68 0xC8 TriggerEvent                ( 00018674E660 ModelClassType EventBase EventBase EventBase Pointer )
            value.M_ContextualMenuManager                   = GetObject<ContextualMenuManager>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ContextualMenuManager.FromPointer); // 0245A6751E88 0xD0 M_ContextualMenuManager     ( 000186618780 ModelClassType ContextualMenuManager ContextualMenuManager ContextualMenuManager Pointer )

            return value;
        }
    }
}

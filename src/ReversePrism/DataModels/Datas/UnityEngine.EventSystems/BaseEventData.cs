using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_EventSystem                            00018676C3E0 ModelClassType EventSystem EventSystem EventSystem Pointer
    public partial class BaseEventData
    {
        public EventSystem?                             M_EventSystem                           { get; set; }

        public static BaseEventData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseEventData();

            value.M_EventSystem                             = GetObject<EventSystem>(new IntPtr(p + 0x018), ReversePrism.DataModels.EventSystem.FromPointer); // 027003EBC938 0x18 M_EventSystem               ( 00018676C3E0 ModelClassType EventSystem EventSystem EventSystem Pointer )

            return value;
        }
    }
}

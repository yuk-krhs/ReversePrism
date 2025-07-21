using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Event                                  ModelClassType EventBase EventBase EventBase Pointer
    // 018 M_Panel                                  ModelClassType IPanel IPanel IPanel Pointer
    public partial class EventRecord : DataModel
    {
        public EventBase?                               M_Event                                 { get; set; }
        public IPanel?                                  M_Panel                                 { get; set; }

        public static EventRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventRecord() { Pointer= p0 };

            value.M_Event                                   = GetObject<EventBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.EventBase.FromPointer); // 0x10 M_Event                     ( ModelClassType EventBase EventBase EventBase Pointer )
            value.M_Panel                                   = GetObject<IPanel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPanel.FromPointer); // 0x18 M_Panel                     ( ModelClassType IPanel IPanel IPanel Pointer )

            return value;
        }
    }
}

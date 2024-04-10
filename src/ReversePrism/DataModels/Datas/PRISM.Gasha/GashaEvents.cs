using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventType                                00018676D7F0 ModelEnumType EventType EventType EventType Int32
    public partial class GashaEvents : DataModel
    {
        public EventType                                EventType                               { get; set; }

        public static GashaEvents? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaEvents() { Pointer= p0 };

            value.EventType                                 = (EventType)GetInt32(new IntPtr(p + 0x010)); // 0246653629C8 0x10 EventType                   ( 00018676D7F0 ModelEnumType EventType EventType EventType Int32 )

            return value;
        }
    }
}

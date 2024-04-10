using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_Events                                 000186535A70 ModelClassType EventKeyValue EventKeyValue EventKeyValue Pointer
    public partial class SignalReceiver : DataModel
    {
        public EventKeyValue?                           M_Events                                { get; set; }

        public static SignalReceiver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SignalReceiver() { Pointer= p0 };

            value.M_Events                                  = GetObject<EventKeyValue>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventKeyValue.FromPointer); // 02466B2FE720 0x20 M_Events                    ( 000186535A70 ModelClassType EventKeyValue EventKeyValue EventKeyValue Pointer )

            return value;
        }
    }
}

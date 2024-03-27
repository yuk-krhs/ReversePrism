using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 m_ThisHandle                             <int> IL2CPP_TYPE_I
    // 020 M_Timers                                 000186613480 ModelClassType TimerNode TimerNode TimerNode Pointer
    public partial class TimerQueue
    {
        public TimerNode?                               M_Timers                                { get; set; }

        public static TimerQueue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimerQueue();

            value.M_Timers                                  = GetObject<TimerNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.TimerNode.FromPointer); // 0270D7A31688 0x20 M_Timers                    ( 000186613480 ModelClassType TimerNode TimerNode TimerNode Pointer )

            return value;
        }
    }
}

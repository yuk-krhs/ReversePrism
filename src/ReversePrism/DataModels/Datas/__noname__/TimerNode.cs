using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_TimerState                             000186586920 ModelEnumType TimerState TimerState TimerState Int32
    // 020 M_Callback                               000186611CC0 ModelClassType Callback Callback Callback Pointer
    // 028 m_Context                                <object> IL2CPP_TYPE_OBJECT
    // 030 m_QueueLock                              <object> IL2CPP_TYPE_OBJECT
    // 038 Next                                     0001866131C0 ModelClassType TimerNode TimerNode TimerNode Pointer
    // 040 Prev                                     0001866131C0 ModelClassType TimerNode TimerNode TimerNode Pointer
    public partial class TimerNode
    {
        public TimerState                               M_TimerState                            { get; set; }
        public Callback?                                M_Callback                              { get; set; }
        public TimerNode?                               Next                                    { get; set; }
        public TimerNode?                               Prev                                    { get; set; }

        public static TimerNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimerNode();

            value.M_TimerState                              = (TimerState)GetInt32(new IntPtr(p + 0x018)); // 0270D7A31A48 0x18 M_TimerState                ( 000186586920 ModelEnumType TimerState TimerState TimerState Int32 )
            value.M_Callback                                = GetObject<Callback>(new IntPtr(p + 0x020), ReversePrism.DataModels.Callback.FromPointer); // 0270D7A31A68 0x20 M_Callback                  ( 000186611CC0 ModelClassType Callback Callback Callback Pointer )
            value.Next                                      = GetObject<TimerNode>(new IntPtr(p + 0x038), ReversePrism.DataModels.TimerNode.FromPointer); // 0270D7A31AC8 0x38 Next                        ( 0001866131C0 ModelClassType TimerNode TimerNode TimerNode Pointer )
            value.Prev                                      = GetObject<TimerNode>(new IntPtr(p + 0x040), ReversePrism.DataModels.TimerNode.FromPointer); // 0270D7A31AE8 0x40 Prev                        ( 0001866131C0 ModelClassType TimerNode TimerNode TimerNode Pointer )

            return value;
        }
    }
}

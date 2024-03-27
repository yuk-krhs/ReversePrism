using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_EventQueuePool                         ObjectPool`1<Queue`1<EventBase>> IL2CPP_TYPE_GENERICINST
    // 000 elementPropertyStateDelta                Dictionary`2<ElementPropertyPair, TransitionState> IL2CPP_TYPE_GENERICINST
    // 000 elementPropertyQueuedEvents              Dictionary`2<ElementPropertyPair, Queue`1<EventBase>> IL2CPP_TYPE_GENERICINST
    // 000 panel                                    IPanel IL2CPP_TYPE_CLASS
    // 000 m_ChangesCount                           int IL2CPP_TYPE_I4
    public partial class TransitionEventsFrameState
    {

        public static TransitionEventsFrameState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransitionEventsFrameState();


            return value;
        }
    }
}

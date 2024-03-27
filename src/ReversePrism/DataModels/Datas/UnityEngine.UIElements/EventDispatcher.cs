using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ClickDetector                          0001865B31F0 ModelClassType ClickDetector ClickDetector ClickDetector Pointer
    // 018 M_DispatchingStrategies                  000185CE2B38 ModelClassListType List`1<IEventDispatchingStrategy> List`1<IEventDispatchingStrategy> List<IEventDispatchingStrategy> Pointer
    // 000 k_EventQueuePool                         ObjectPool`1<Queue`1<EventRecord>> IL2CPP_TYPE_GENERICINST
    // 020 m_Queue                                  Queue`1<EventRecord> IL2CPP_TYPE_GENERICINST
    // 028 PointerState                             000186759C80 ModelClassType PointerDispatchState PointerDispatchState PointerDispatchState Pointer
    // 030 M_GateCount                              000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 038 m_DispatchContexts                       Stack`1<DispatchContext> IL2CPP_TYPE_GENERICINST
    // 008 s_EditorStrategies                       IEventDispatchingStrategy[] IL2CPP_TYPE_SZARRAY
    // 040 M_Immediate                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 ProcessingEvents                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class EventDispatcher
    {
        public ClickDetector?                           M_ClickDetector                         { get; set; }
        public List<IEventDispatchingStrategy>?         M_DispatchingStrategies                 { get; set; }
        public PointerDispatchState?                    PointerState                            { get; set; }
        public uint                                     M_GateCount                             { get; set; }
        public bool                                     M_Immediate                             { get; set; }
        public bool                                     ProcessingEvents                        { get; set; }

        public static EventDispatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventDispatcher();

            value.M_ClickDetector                           = GetObject<ClickDetector>(new IntPtr(p + 0x010), ReversePrism.DataModels.ClickDetector.FromPointer); // 027006758F68 0x10 M_ClickDetector             ( 0001865B31F0 ModelClassType ClickDetector ClickDetector ClickDetector Pointer )
            value.M_DispatchingStrategies                   = GetObjectList<IEventDispatchingStrategy>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEventDispatchingStrategy.FromPointer); // 027006758F88 0x18 M_DispatchingStrategies     ( 000185CE2B38 ModelClassListType List`1<IEventDispatchingStrategy> List`1<IEventDispatchingStrategy> List<IEventDispatchingStrategy> Pointer )
            value.PointerState                              = GetObject<PointerDispatchState>(new IntPtr(p + 0x028), ReversePrism.DataModels.PointerDispatchState.FromPointer); // 027006758FE8 0x28 PointerState                ( 000186759C80 ModelClassType PointerDispatchState PointerDispatchState PointerDispatchState Pointer )
            value.M_GateCount                               = GetUInt32(new IntPtr(p + 0x030)); // 027006759008 0x30 M_GateCount                 ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.M_Immediate                               = GetBool(new IntPtr(p + 0x040)); // 027006759068 0x40 M_Immediate                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ProcessingEvents                          = GetBool(new IntPtr(p + 0x041)); // 027006759088 0x41 ProcessingEvents            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

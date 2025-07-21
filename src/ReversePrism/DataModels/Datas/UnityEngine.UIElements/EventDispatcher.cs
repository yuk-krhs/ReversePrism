using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_ClickDetector                          ModelClassType ClickDetector ClickDetector ClickDetector Pointer
    // 018 M_DispatchingStrategies                  ModelClassListType List`1<IEventDispatchingStrategy> List`1<IEventDispatchingStrategy> List<IEventDispatchingStrategy> Pointer
    // 000 k_EventQueuePool                         ObjectPool`1<Queue`1<EventRecord>> IL2CPP_TYPE_GENERICINST
    // 020 m_Queue                                  Queue`1<EventRecord> IL2CPP_TYPE_GENERICINST
    // 028 PointerState                             ModelClassType PointerDispatchState PointerDispatchState PointerDispatchState Pointer
    // 030 M_GateCount                              ModelPrimitiveType uint uint uint UInt32
    // 038 m_DispatchContexts                       Stack`1<DispatchContext> IL2CPP_TYPE_GENERICINST
    // 008 s_EditorStrategies                       IEventDispatchingStrategy[] IL2CPP_TYPE_SZARRAY
    // 040 M_Immediate                              ModelPrimitiveType bool bool bool Bool
    // 041 ProcessingEvents                         ModelPrimitiveType bool bool bool Bool
    public partial class EventDispatcher : DataModel
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
            var value   = new EventDispatcher() { Pointer= p0 };

            value.M_ClickDetector                           = GetObject<ClickDetector>(new IntPtr(p + 0x010), ReversePrism.DataModels.ClickDetector.FromPointer); // 0x10 M_ClickDetector             ( ModelClassType ClickDetector ClickDetector ClickDetector Pointer )
            value.M_DispatchingStrategies                   = GetObjectList<IEventDispatchingStrategy>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEventDispatchingStrategy.FromPointer); // 0x18 M_DispatchingStrategies     ( ModelClassListType List`1<IEventDispatchingStrategy> List`1<IEventDispatchingStrategy> List<IEventDispatchingStrategy> Pointer )
            value.PointerState                              = GetObject<PointerDispatchState>(new IntPtr(p + 0x028), ReversePrism.DataModels.PointerDispatchState.FromPointer); // 0x28 PointerState                ( ModelClassType PointerDispatchState PointerDispatchState PointerDispatchState Pointer )
            value.M_GateCount                               = GetUInt32(new IntPtr(p + 0x030)); // 0x30 M_GateCount                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_Immediate                               = GetBool(new IntPtr(p + 0x040)); // 0x40 M_Immediate                 ( ModelPrimitiveType bool bool bool Bool )
            value.ProcessingEvents                          = GetBool(new IntPtr(p + 0x041)); // 0x41 ProcessingEvents            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

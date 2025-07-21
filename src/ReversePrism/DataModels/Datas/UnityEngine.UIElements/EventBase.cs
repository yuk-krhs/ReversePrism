using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_LastTypeId                             long IL2CPP_TYPE_I8
    // 010 EventCategory                            ModelEnumType EventCategory EventCategory EventCategory Int32
    // 008 s_NextEventId                            ulong IL2CPP_TYPE_U8
    // 018 Timestamp                                ModelPrimitiveType long long long Int64
    // 020 EventId                                  ModelPrimitiveType ulong ulong ulong UInt64
    // 028 TriggerEventId                           ModelPrimitiveType ulong ulong ulong UInt64
    // 030 Propagation                              ModelEnumType EventPropagation EventPropagation EventPropagation Int32
    // 038 Path                                     ModelClassType PropagationPaths PropagationPaths PropagationPaths Pointer
    // 040 LifeCycleStatus                          ModelEnumType LifeCycleStatus LifeCycleStatus LifeCycleStatus Int32
    // 048 LeafTarget                               ModelClassType IEventHandler IEventHandler IEventHandler Pointer
    // 050 M_Target                                 ModelClassType IEventHandler IEventHandler IEventHandler Pointer
    // 058 SkipElements                             ModelClassListType List`1<IEventHandler> List`1<IEventHandler> List<IEventHandler> Pointer
    // 060 PropagationPhase                         ModelEnumType PropagationPhase PropagationPhase PropagationPhase Int32
    // 068 M_CurrentTarget                          ModelClassType IEventHandler IEventHandler IEventHandler Pointer
    // 070 M_ImguiEvent                             ModelClassType Event Event Event Pointer
    // 078 OriginalMousePosition                    ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class EventBase : DataModel
    {
        public EventCategory                            EventCategory                           { get; set; }
        public long                                     Timestamp                               { get; set; }
        public ulong                                    EventId                                 { get; set; }
        public ulong                                    TriggerEventId                          { get; set; }
        public EventPropagation                         Propagation                             { get; set; }
        public PropagationPaths?                        Path                                    { get; set; }
        public LifeCycleStatus                          LifeCycleStatus                         { get; set; }
        public IEventHandler?                           LeafTarget                              { get; set; }
        public IEventHandler?                           M_Target                                { get; set; }
        public List<IEventHandler>?                     SkipElements                            { get; set; }
        public PropagationPhase                         PropagationPhase                        { get; set; }
        public IEventHandler?                           M_CurrentTarget                         { get; set; }
        public Event?                                   M_ImguiEvent                            { get; set; }
        public Vector2                                  OriginalMousePosition                   { get; set; }

        public static EventBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventBase() { Pointer= p0 };

            value.EventCategory                             = (EventCategory)GetInt32(new IntPtr(p + 0x010)); // 0x10 EventCategory               ( ModelEnumType EventCategory EventCategory EventCategory Int32 )
            value.Timestamp                                 = GetInt64(new IntPtr(p + 0x018)); // 0x18 Timestamp                   ( ModelPrimitiveType long long long Int64 )
            value.EventId                                   = GetUInt64(new IntPtr(p + 0x020)); // 0x20 EventId                     ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.TriggerEventId                            = GetUInt64(new IntPtr(p + 0x028)); // 0x28 TriggerEventId              ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Propagation                               = (EventPropagation)GetInt32(new IntPtr(p + 0x030)); // 0x30 Propagation                 ( ModelEnumType EventPropagation EventPropagation EventPropagation Int32 )
            value.Path                                      = GetObject<PropagationPaths>(new IntPtr(p + 0x038), ReversePrism.DataModels.PropagationPaths.FromPointer); // 0x38 Path                        ( ModelClassType PropagationPaths PropagationPaths PropagationPaths Pointer )
            value.LifeCycleStatus                           = (LifeCycleStatus)GetInt32(new IntPtr(p + 0x040)); // 0x40 LifeCycleStatus             ( ModelEnumType LifeCycleStatus LifeCycleStatus LifeCycleStatus Int32 )
            value.LeafTarget                                = GetObject<IEventHandler>(new IntPtr(p + 0x048), ReversePrism.DataModels.IEventHandler.FromPointer); // 0x48 LeafTarget                  ( ModelClassType IEventHandler IEventHandler IEventHandler Pointer )
            value.M_Target                                  = GetObject<IEventHandler>(new IntPtr(p + 0x050), ReversePrism.DataModels.IEventHandler.FromPointer); // 0x50 M_Target                    ( ModelClassType IEventHandler IEventHandler IEventHandler Pointer )
            value.SkipElements                              = GetObjectList<IEventHandler>(new IntPtr(p + 0x058), ReversePrism.DataModels.IEventHandler.FromPointer); // 0x58 SkipElements                ( ModelClassListType List`1<IEventHandler> List`1<IEventHandler> List<IEventHandler> Pointer )
            value.PropagationPhase                          = (PropagationPhase)GetInt32(new IntPtr(p + 0x060)); // 0x60 PropagationPhase            ( ModelEnumType PropagationPhase PropagationPhase PropagationPhase Int32 )
            value.M_CurrentTarget                           = GetObject<IEventHandler>(new IntPtr(p + 0x068), ReversePrism.DataModels.IEventHandler.FromPointer); // 0x68 M_CurrentTarget             ( ModelClassType IEventHandler IEventHandler IEventHandler Pointer )
            value.M_ImguiEvent                              = GetObject<Event>(new IntPtr(p + 0x070), ReversePrism.DataModels.Event.FromPointer); // 0x70 M_ImguiEvent                ( ModelClassType Event Event Event Pointer )
            value.OriginalMousePosition                     = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 0x78 OriginalMousePosition       ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}

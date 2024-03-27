using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_LastTypeId                             long IL2CPP_TYPE_I8
    // 010 EventCategory                            000186751D60 ModelEnumType EventCategory EventCategory EventCategory Int32
    // 008 s_NextEventId                            ulong IL2CPP_TYPE_U8
    // 018 Timestamp                                0001865F7700 ModelPrimitiveType long long long Int64
    // 020 EventId                                  00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 028 TriggerEventId                           00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 030 Propagation                              00018662F100 ModelEnumType EventPropagation EventPropagation EventPropagation Int32
    // 038 Path                                     0001865CF490 ModelClassType PropagationPaths PropagationPaths PropagationPaths Pointer
    // 040 LifeCycleStatus                          00018662F860 ModelEnumType LifeCycleStatus LifeCycleStatus LifeCycleStatus Int32
    // 048 LeafTarget                               0001865E2960 ModelClassType IEventHandler IEventHandler IEventHandler Pointer
    // 050 M_Target                                 0001865E2960 ModelClassType IEventHandler IEventHandler IEventHandler Pointer
    // 058 SkipElements                             000185CE2DC8 ModelClassListType List`1<IEventHandler> List`1<IEventHandler> List<IEventHandler> Pointer
    // 060 PropagationPhase                         0001865CF930 ModelEnumType PropagationPhase PropagationPhase PropagationPhase Int32
    // 068 M_CurrentTarget                          0001865E2960 ModelClassType IEventHandler IEventHandler IEventHandler Pointer
    // 070 M_ImguiEvent                             00018674CC10 ModelClassType Event Event Event Pointer
    // 078 OriginalMousePosition                    0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class EventBase
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
            var value   = new EventBase();

            value.EventCategory                             = (EventCategory)GetInt32(new IntPtr(p + 0x010)); // 027004FB7638 0x10 EventCategory               ( 000186751D60 ModelEnumType EventCategory EventCategory EventCategory Int32 )
            value.Timestamp                                 = GetInt64(new IntPtr(p + 0x018)); // 027004FB7678 0x18 Timestamp                   ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.EventId                                   = GetUInt64(new IntPtr(p + 0x020)); // 027004FB7698 0x20 EventId                     ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.TriggerEventId                            = GetUInt64(new IntPtr(p + 0x028)); // 027004FB76B8 0x28 TriggerEventId              ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.Propagation                               = (EventPropagation)GetInt32(new IntPtr(p + 0x030)); // 027004FB76D8 0x30 Propagation                 ( 00018662F100 ModelEnumType EventPropagation EventPropagation EventPropagation Int32 )
            value.Path                                      = GetObject<PropagationPaths>(new IntPtr(p + 0x038), ReversePrism.DataModels.PropagationPaths.FromPointer); // 027004FB76F8 0x38 Path                        ( 0001865CF490 ModelClassType PropagationPaths PropagationPaths PropagationPaths Pointer )
            value.LifeCycleStatus                           = (LifeCycleStatus)GetInt32(new IntPtr(p + 0x040)); // 027004FB7718 0x40 LifeCycleStatus             ( 00018662F860 ModelEnumType LifeCycleStatus LifeCycleStatus LifeCycleStatus Int32 )
            value.LeafTarget                                = GetObject<IEventHandler>(new IntPtr(p + 0x048), ReversePrism.DataModels.IEventHandler.FromPointer); // 027004FB7738 0x48 LeafTarget                  ( 0001865E2960 ModelClassType IEventHandler IEventHandler IEventHandler Pointer )
            value.M_Target                                  = GetObject<IEventHandler>(new IntPtr(p + 0x050), ReversePrism.DataModels.IEventHandler.FromPointer); // 027004FB7758 0x50 M_Target                    ( 0001865E2960 ModelClassType IEventHandler IEventHandler IEventHandler Pointer )
            value.SkipElements                              = GetObjectList<IEventHandler>(new IntPtr(p + 0x058), ReversePrism.DataModels.IEventHandler.FromPointer); // 027004FB7778 0x58 SkipElements                ( 000185CE2DC8 ModelClassListType List`1<IEventHandler> List`1<IEventHandler> List<IEventHandler> Pointer )
            value.PropagationPhase                          = (PropagationPhase)GetInt32(new IntPtr(p + 0x060)); // 027004FB7798 0x60 PropagationPhase            ( 0001865CF930 ModelEnumType PropagationPhase PropagationPhase PropagationPhase Int32 )
            value.M_CurrentTarget                           = GetObject<IEventHandler>(new IntPtr(p + 0x068), ReversePrism.DataModels.IEventHandler.FromPointer); // 027004FB77B8 0x68 M_CurrentTarget             ( 0001865E2960 ModelClassType IEventHandler IEventHandler IEventHandler Pointer )
            value.M_ImguiEvent                              = GetObject<Event>(new IntPtr(p + 0x070), ReversePrism.DataModels.Event.FromPointer); // 027004FB77D8 0x70 M_ImguiEvent                ( 00018674CC10 ModelClassType Event Event Event Pointer )
            value.OriginalMousePosition                     = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 027004FB77F8 0x78 OriginalMousePosition       ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}

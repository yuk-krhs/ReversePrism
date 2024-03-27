using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 argsNone                                 Type[] IL2CPP_TYPE_SZARRAY
    // 008 noValue                                  <object> IL2CPP_TYPE_OBJECT
    // 010 PropDescCreateSwitch                     00018669B020 ModelClassType TraceSwitch TraceSwitch TraceSwitch Pointer
    // 018 PropDescUsageSwitch                      00018669B020 ModelClassType TraceSwitch TraceSwitch TraceSwitch Pointer
    // 020 BitDefaultValueQueried                   0001865F4BC0 ModelPrimitiveType int int int Int32
    // 024 BitGetQueried                            0001865F4BC0 ModelPrimitiveType int int int Int32
    // 028 BitSetQueried                            0001865F4BC0 ModelPrimitiveType int int int Int32
    // 02C BitShouldSerializeQueried                0001865F4BC0 ModelPrimitiveType int int int Int32
    // 030 BitResetQueried                          0001865F4BC0 ModelPrimitiveType int int int Int32
    // 034 BitChangedQueried                        0001865F4BC0 ModelPrimitiveType int int int Int32
    // 038 BitIPropChangedQueried                   0001865F4BC0 ModelPrimitiveType int int int Int32
    // 03C BitReadOnlyChecked                       0001865F4BC0 ModelPrimitiveType int int int Int32
    // 040 BitAmbientValueQueried                   0001865F4BC0 ModelPrimitiveType int int int Int32
    // 044 BitSetOnDemand                           0001865F4BC0 ModelPrimitiveType int int int Int32
    // 088 State                                    000186763E30 ModelEnumType BitVector32 BitVector32 BitVector32 Int32
    // 090 ComponentClass                           000186692850 ModelClassType Type Type Type Pointer
    // 098 Type                                     000186692850 ModelClassType Type Type Type Pointer
    // 0A0 defaultValue                             <object> IL2CPP_TYPE_OBJECT
    // 0A8 ambientValue                             <object> IL2CPP_TYPE_OBJECT
    // 0B0 PropInfo                                 0001865D41C0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 0B8 GetMethod                                000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0C0 SetMethod                                000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0C8 ShouldSerializeMethod                    000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0D0 ResetMethod                              000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0D8 RealChangedEvent                         0001867544B0 ModelClassType EventDescriptor EventDescriptor EventDescriptor Pointer
    // 0E0 ReceiverType                             000186692850 ModelClassType Type Type Type Pointer
    public partial class ReflectPropertyDescriptor
    {
        public TraceSwitch?                             PropDescCreateSwitch                    { get; set; }
        public TraceSwitch?                             PropDescUsageSwitch                     { get; set; }
        public int                                      BitDefaultValueQueried                  { get; set; }
        public int                                      BitGetQueried                           { get; set; }
        public int                                      BitSetQueried                           { get; set; }
        public int                                      BitShouldSerializeQueried               { get; set; }
        public int                                      BitResetQueried                         { get; set; }
        public int                                      BitChangedQueried                       { get; set; }
        public int                                      BitIPropChangedQueried                  { get; set; }
        public int                                      BitReadOnlyChecked                      { get; set; }
        public int                                      BitAmbientValueQueried                  { get; set; }
        public int                                      BitSetOnDemand                          { get; set; }
        public BitVector32                              State                                   { get; set; }
        public Type?                                    ComponentClass                          { get; set; }
        public Type?                                    Type                                    { get; set; }
        public PropertyInfo?                            PropInfo                                { get; set; }
        public MethodInfo?                              GetMethod                               { get; set; }
        public MethodInfo?                              SetMethod                               { get; set; }
        public MethodInfo?                              ShouldSerializeMethod                   { get; set; }
        public MethodInfo?                              ResetMethod                             { get; set; }
        public EventDescriptor?                         RealChangedEvent                        { get; set; }
        public Type?                                    ReceiverType                            { get; set; }

        public static ReflectPropertyDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectPropertyDescriptor();

            value.PropDescCreateSwitch                      = GetObject<TraceSwitch>(new IntPtr(p + 0x010), ReversePrism.DataModels.TraceSwitch.FromPointer); // 0270D7B1D308 0x10 PropDescCreateSwitch        ( 00018669B020 ModelClassType TraceSwitch TraceSwitch TraceSwitch Pointer )
            value.PropDescUsageSwitch                       = GetObject<TraceSwitch>(new IntPtr(p + 0x018), ReversePrism.DataModels.TraceSwitch.FromPointer); // 0270D7B1D328 0x18 PropDescUsageSwitch         ( 00018669B020 ModelClassType TraceSwitch TraceSwitch TraceSwitch Pointer )
            value.BitDefaultValueQueried                    = GetInt32(new IntPtr(p + 0x020)); // 0270D7B1D348 0x20 BitDefaultValueQueried      ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.BitGetQueried                             = GetInt32(new IntPtr(p + 0x024)); // 0270D7B1D368 0x24 BitGetQueried               ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.BitSetQueried                             = GetInt32(new IntPtr(p + 0x028)); // 0270D7B1D388 0x28 BitSetQueried               ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.BitShouldSerializeQueried                 = GetInt32(new IntPtr(p + 0x02C)); // 0270D7B1D3A8 0x2C BitShouldSerializeQueried   ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.BitResetQueried                           = GetInt32(new IntPtr(p + 0x030)); // 0270D7B1D3C8 0x30 BitResetQueried             ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.BitChangedQueried                         = GetInt32(new IntPtr(p + 0x034)); // 0270D7B1D3E8 0x34 BitChangedQueried           ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.BitIPropChangedQueried                    = GetInt32(new IntPtr(p + 0x038)); // 0270D7B1D408 0x38 BitIPropChangedQueried      ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.BitReadOnlyChecked                        = GetInt32(new IntPtr(p + 0x03C)); // 0270D7B1D428 0x3C BitReadOnlyChecked          ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.BitAmbientValueQueried                    = GetInt32(new IntPtr(p + 0x040)); // 0270D7B1D448 0x40 BitAmbientValueQueried      ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.BitSetOnDemand                            = GetInt32(new IntPtr(p + 0x044)); // 0270D7B1D468 0x44 BitSetOnDemand              ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.State                                     = (BitVector32)GetInt32(new IntPtr(p + 0x088)); // 0270D7B1D488 0x88 State                       ( 000186763E30 ModelEnumType BitVector32 BitVector32 BitVector32 Int32 )
            value.ComponentClass                            = GetObject<Type>(new IntPtr(p + 0x090), ReversePrism.DataModels.Type.FromPointer); // 0270D7B1D4A8 0x90 ComponentClass              ( 000186692850 ModelClassType Type Type Type Pointer )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x098), ReversePrism.DataModels.Type.FromPointer); // 0270D7B1D4C8 0x98 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )
            value.PropInfo                                  = GetObject<PropertyInfo>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0270D7B1D528 0xB0 PropInfo                    ( 0001865D41C0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.GetMethod                                 = GetObject<MethodInfo>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7B1D548 0xB8 GetMethod                   ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.SetMethod                                 = GetObject<MethodInfo>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7B1D568 0xC0 SetMethod                   ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ShouldSerializeMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7B1D588 0xC8 ShouldSerializeMethod       ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ResetMethod                               = GetObject<MethodInfo>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.MethodInfo.FromPointer); // 0270D7B1D5A8 0xD0 ResetMethod                 ( 000186613630 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.RealChangedEvent                          = GetObject<EventDescriptor>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.EventDescriptor.FromPointer); // 0270D7B1D5C8 0xD8 RealChangedEvent            ( 0001867544B0 ModelClassType EventDescriptor EventDescriptor EventDescriptor Pointer )
            value.ReceiverType                              = GetObject<Type>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Type.FromPointer); // 0270D7B1D5E8 0xE0 ReceiverType                ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}

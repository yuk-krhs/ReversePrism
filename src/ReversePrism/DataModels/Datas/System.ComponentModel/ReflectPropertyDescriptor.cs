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
    // 010 PropDescCreateSwitch                     ModelClassType TraceSwitch TraceSwitch TraceSwitch Pointer
    // 018 PropDescUsageSwitch                      ModelClassType TraceSwitch TraceSwitch TraceSwitch Pointer
    // 020 BitDefaultValueQueried                   ModelPrimitiveType int int int Int32
    // 024 BitGetQueried                            ModelPrimitiveType int int int Int32
    // 028 BitSetQueried                            ModelPrimitiveType int int int Int32
    // 02C BitShouldSerializeQueried                ModelPrimitiveType int int int Int32
    // 030 BitResetQueried                          ModelPrimitiveType int int int Int32
    // 034 BitChangedQueried                        ModelPrimitiveType int int int Int32
    // 038 BitIPropChangedQueried                   ModelPrimitiveType int int int Int32
    // 03C BitReadOnlyChecked                       ModelPrimitiveType int int int Int32
    // 040 BitAmbientValueQueried                   ModelPrimitiveType int int int Int32
    // 044 BitSetOnDemand                           ModelPrimitiveType int int int Int32
    // 088 State                                    ModelEnumType BitVector32 BitVector32 BitVector32 Int32
    // 090 ComponentClass                           ModelClassType Type Type Type Pointer
    // 098 Type                                     ModelClassType Type Type Type Pointer
    // 0A0 defaultValue                             <object> IL2CPP_TYPE_OBJECT
    // 0A8 ambientValue                             <object> IL2CPP_TYPE_OBJECT
    // 0B0 PropInfo                                 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 0B8 GetMethod                                ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0C0 SetMethod                                ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0C8 ShouldSerializeMethod                    ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0D0 ResetMethod                              ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 0D8 RealChangedEvent                         ModelClassType EventDescriptor EventDescriptor EventDescriptor Pointer
    // 0E0 ReceiverType                             ModelClassType Type Type Type Pointer
    public partial class ReflectPropertyDescriptor : DataModel
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
            var value   = new ReflectPropertyDescriptor() { Pointer= p0 };

            value.PropDescCreateSwitch                      = GetObject<TraceSwitch>(new IntPtr(p + 0x010), ReversePrism.DataModels.TraceSwitch.FromPointer); // 0x10 PropDescCreateSwitch        ( ModelClassType TraceSwitch TraceSwitch TraceSwitch Pointer )
            value.PropDescUsageSwitch                       = GetObject<TraceSwitch>(new IntPtr(p + 0x018), ReversePrism.DataModels.TraceSwitch.FromPointer); // 0x18 PropDescUsageSwitch         ( ModelClassType TraceSwitch TraceSwitch TraceSwitch Pointer )
            value.BitDefaultValueQueried                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 BitDefaultValueQueried      ( ModelPrimitiveType int int int Int32 )
            value.BitGetQueried                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 BitGetQueried               ( ModelPrimitiveType int int int Int32 )
            value.BitSetQueried                             = GetInt32(new IntPtr(p + 0x028)); // 0x28 BitSetQueried               ( ModelPrimitiveType int int int Int32 )
            value.BitShouldSerializeQueried                 = GetInt32(new IntPtr(p + 0x02C)); // 0x2C BitShouldSerializeQueried   ( ModelPrimitiveType int int int Int32 )
            value.BitResetQueried                           = GetInt32(new IntPtr(p + 0x030)); // 0x30 BitResetQueried             ( ModelPrimitiveType int int int Int32 )
            value.BitChangedQueried                         = GetInt32(new IntPtr(p + 0x034)); // 0x34 BitChangedQueried           ( ModelPrimitiveType int int int Int32 )
            value.BitIPropChangedQueried                    = GetInt32(new IntPtr(p + 0x038)); // 0x38 BitIPropChangedQueried      ( ModelPrimitiveType int int int Int32 )
            value.BitReadOnlyChecked                        = GetInt32(new IntPtr(p + 0x03C)); // 0x3C BitReadOnlyChecked          ( ModelPrimitiveType int int int Int32 )
            value.BitAmbientValueQueried                    = GetInt32(new IntPtr(p + 0x040)); // 0x40 BitAmbientValueQueried      ( ModelPrimitiveType int int int Int32 )
            value.BitSetOnDemand                            = GetInt32(new IntPtr(p + 0x044)); // 0x44 BitSetOnDemand              ( ModelPrimitiveType int int int Int32 )
            value.State                                     = (BitVector32)GetInt32(new IntPtr(p + 0x088)); // 0x88 State                       ( ModelEnumType BitVector32 BitVector32 BitVector32 Int32 )
            value.ComponentClass                            = GetObject<Type>(new IntPtr(p + 0x090), ReversePrism.DataModels.Type.FromPointer); // 0x90 ComponentClass              ( ModelClassType Type Type Type Pointer )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x098), ReversePrism.DataModels.Type.FromPointer); // 0x98 Type                        ( ModelClassType Type Type Type Pointer )
            value.PropInfo                                  = GetObject<PropertyInfo>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0xB0 PropInfo                    ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.GetMethod                                 = GetObject<MethodInfo>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.MethodInfo.FromPointer); // 0xB8 GetMethod                   ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.SetMethod                                 = GetObject<MethodInfo>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.MethodInfo.FromPointer); // 0xC0 SetMethod                   ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ShouldSerializeMethod                     = GetObject<MethodInfo>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.MethodInfo.FromPointer); // 0xC8 ShouldSerializeMethod       ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.ResetMethod                               = GetObject<MethodInfo>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.MethodInfo.FromPointer); // 0xD0 ResetMethod                 ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.RealChangedEvent                          = GetObject<EventDescriptor>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.EventDescriptor.FromPointer); // 0xD8 RealChangedEvent            ( ModelClassType EventDescriptor EventDescriptor EventDescriptor Pointer )
            value.ReceiverType                              = GetObject<Type>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.Type.FromPointer); // 0xE0 ReceiverType                ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}

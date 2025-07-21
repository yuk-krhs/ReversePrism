using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_State                                  ModelClassType InputActionState InputActionState InputActionState Pointer
    // 018 M_MapIndex                               ModelPrimitiveType int int int Int32
    // 01C M_BindingCurrentIndex                    ModelPrimitiveType int int int Int32
    // 020 M_BindingEndIndex                        ModelPrimitiveType int int int Int32
    // 024 M_InteractionCurrentIndex                ModelPrimitiveType int int int Int32
    // 028 M_InteractionEndIndex                    ModelPrimitiveType int int int Int32
    // 02C M_ProcessorCurrentIndex                  ModelPrimitiveType int int int Int32
    // 030 M_ProcessorEndIndex                      ModelPrimitiveType int int int Int32
    // 038 M_BindingMask                            ModelEnumType InputBinding InputBinding InputBinding Int32
    // 090 M_ObjectType                             ModelClassType Type Type Type Pointer
    // 098 M_ParameterName                          ModelPrimitiveType string string string String
    // 0A0 M_MayBeInteraction                       ModelPrimitiveType bool bool bool Bool
    // 0A1 M_MayBeProcessor                         ModelPrimitiveType bool bool bool Bool
    // 0A2 M_MayBeComposite                         ModelPrimitiveType bool bool bool Bool
    // 0A3 M_CurrentBindingIsComposite              ModelPrimitiveType bool bool bool Bool
    // 0A8 m_CurrentObject                          <object> IL2CPP_TYPE_OBJECT
    // 0B0 M_CurrentParameter                       ModelClassType FieldInfo FieldInfo FieldInfo Pointer
    public partial class ParameterEnumerator : DataModel
    {
        public InputActionState?                        M_State                                 { get; set; }
        public int                                      M_MapIndex                              { get; set; }
        public int                                      M_BindingCurrentIndex                   { get; set; }
        public int                                      M_BindingEndIndex                       { get; set; }
        public int                                      M_InteractionCurrentIndex               { get; set; }
        public int                                      M_InteractionEndIndex                   { get; set; }
        public int                                      M_ProcessorCurrentIndex                 { get; set; }
        public int                                      M_ProcessorEndIndex                     { get; set; }
        public InputBinding                             M_BindingMask                           { get; set; }
        public Type?                                    M_ObjectType                            { get; set; }
        public string                                   M_ParameterName                         { get; set; }
        public bool                                     M_MayBeInteraction                      { get; set; }
        public bool                                     M_MayBeProcessor                        { get; set; }
        public bool                                     M_MayBeComposite                        { get; set; }
        public bool                                     M_CurrentBindingIsComposite             { get; set; }
        public FieldInfo?                               M_CurrentParameter                      { get; set; }

        public static ParameterEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterEnumerator() { Pointer= p0 };

            value.M_State                                   = GetObject<InputActionState>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionState.FromPointer); // 0x10 M_State                     ( ModelClassType InputActionState InputActionState InputActionState Pointer )
            value.M_MapIndex                                = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_MapIndex                  ( ModelPrimitiveType int int int Int32 )
            value.M_BindingCurrentIndex                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_BindingCurrentIndex       ( ModelPrimitiveType int int int Int32 )
            value.M_BindingEndIndex                         = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_BindingEndIndex           ( ModelPrimitiveType int int int Int32 )
            value.M_InteractionCurrentIndex                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_InteractionCurrentIndex   ( ModelPrimitiveType int int int Int32 )
            value.M_InteractionEndIndex                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_InteractionEndIndex       ( ModelPrimitiveType int int int Int32 )
            value.M_ProcessorCurrentIndex                   = GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_ProcessorCurrentIndex     ( ModelPrimitiveType int int int Int32 )
            value.M_ProcessorEndIndex                       = GetInt32(new IntPtr(p + 0x030)); // 0x30 M_ProcessorEndIndex         ( ModelPrimitiveType int int int Int32 )
            value.M_BindingMask                             = (InputBinding)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_BindingMask               ( ModelEnumType InputBinding InputBinding InputBinding Int32 )
            value.M_ObjectType                              = GetObject<Type>(new IntPtr(p + 0x090), ReversePrism.DataModels.Type.FromPointer); // 0x90 M_ObjectType                ( ModelClassType Type Type Type Pointer )
            value.M_ParameterName                           = GetString(new IntPtr(p + 0x098)); // 0x98 M_ParameterName             ( ModelPrimitiveType string string string String )
            value.M_MayBeInteraction                        = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 M_MayBeInteraction          ( ModelPrimitiveType bool bool bool Bool )
            value.M_MayBeProcessor                          = GetBool(new IntPtr(p + 0x0A1)); // 0xA1 M_MayBeProcessor            ( ModelPrimitiveType bool bool bool Bool )
            value.M_MayBeComposite                          = GetBool(new IntPtr(p + 0x0A2)); // 0xA2 M_MayBeComposite            ( ModelPrimitiveType bool bool bool Bool )
            value.M_CurrentBindingIsComposite               = GetBool(new IntPtr(p + 0x0A3)); // 0xA3 M_CurrentBindingIsComposite ( ModelPrimitiveType bool bool bool Bool )
            value.M_CurrentParameter                        = GetObject<FieldInfo>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.FieldInfo.FromPointer); // 0xB0 M_CurrentParameter          ( ModelClassType FieldInfo FieldInfo FieldInfo Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_State                                  0001866F71F0 ModelClassType InputActionState InputActionState InputActionState Pointer
    // 018 M_MapIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C M_BindingCurrentIndex                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_BindingEndIndex                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 M_InteractionCurrentIndex                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_InteractionEndIndex                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C M_ProcessorCurrentIndex                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 M_ProcessorEndIndex                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 M_BindingMask                            0001865EA070 ModelEnumType InputBinding InputBinding InputBinding Int32
    // 090 M_ObjectType                             000186692850 ModelClassType Type Type Type Pointer
    // 098 M_ParameterName                          000186671910 ModelPrimitiveType string string string String
    // 0A0 M_MayBeInteraction                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A1 M_MayBeProcessor                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A2 M_MayBeComposite                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A3 M_CurrentBindingIsComposite              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 m_CurrentObject                          <object> IL2CPP_TYPE_OBJECT
    // 0B0 M_CurrentParameter                       0001865730B0 ModelClassType FieldInfo FieldInfo FieldInfo Pointer
    public partial class ParameterEnumerator
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
            var value   = new ParameterEnumerator();

            value.M_State                                   = GetObject<InputActionState>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputActionState.FromPointer); // 0270D7650360 0x10 M_State                     ( 0001866F71F0 ModelClassType InputActionState InputActionState InputActionState Pointer )
            value.M_MapIndex                                = GetInt32(new IntPtr(p + 0x018)); // 0270D7650380 0x18 M_MapIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_BindingCurrentIndex                     = GetInt32(new IntPtr(p + 0x01C)); // 0270D76503A0 0x1C M_BindingCurrentIndex       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_BindingEndIndex                         = GetInt32(new IntPtr(p + 0x020)); // 0270D76503C0 0x20 M_BindingEndIndex           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_InteractionCurrentIndex                 = GetInt32(new IntPtr(p + 0x024)); // 0270D76503E0 0x24 M_InteractionCurrentIndex   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_InteractionEndIndex                     = GetInt32(new IntPtr(p + 0x028)); // 0270D7650400 0x28 M_InteractionEndIndex       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ProcessorCurrentIndex                   = GetInt32(new IntPtr(p + 0x02C)); // 0270D7650420 0x2C M_ProcessorCurrentIndex     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_ProcessorEndIndex                       = GetInt32(new IntPtr(p + 0x030)); // 0270D7650440 0x30 M_ProcessorEndIndex         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_BindingMask                             = (InputBinding)GetInt32(new IntPtr(p + 0x038)); // 0270D7650460 0x38 M_BindingMask               ( 0001865EA070 ModelEnumType InputBinding InputBinding InputBinding Int32 )
            value.M_ObjectType                              = GetObject<Type>(new IntPtr(p + 0x090), ReversePrism.DataModels.Type.FromPointer); // 0270D7650480 0x90 M_ObjectType                ( 000186692850 ModelClassType Type Type Type Pointer )
            value.M_ParameterName                           = GetString(new IntPtr(p + 0x098)); // 0270D76504A0 0x98 M_ParameterName             ( 000186671910 ModelPrimitiveType string string string String )
            value.M_MayBeInteraction                        = GetBool(new IntPtr(p + 0x0A0)); // 0270D76504C0 0xA0 M_MayBeInteraction          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MayBeProcessor                          = GetBool(new IntPtr(p + 0x0A1)); // 0270D76504E0 0xA1 M_MayBeProcessor            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MayBeComposite                          = GetBool(new IntPtr(p + 0x0A2)); // 0270D7650500 0xA2 M_MayBeComposite            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CurrentBindingIsComposite               = GetBool(new IntPtr(p + 0x0A3)); // 0270D7650520 0xA3 M_CurrentBindingIsComposite ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_CurrentParameter                        = GetObject<FieldInfo>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.FieldInfo.FromPointer); // 0270D7650560 0xB0 M_CurrentParameter          ( 0001865730B0 ModelClassType FieldInfo FieldInfo FieldInfo Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MessageOptions> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 _extensions                              ExtensionSet`1<MessageOptions> IL2CPP_TYPE_GENERICINST
    // 020 HasBits0                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MessageSetWireFormatFieldNumber          int IL2CPP_TYPE_I4
    // 008 MessageSetWireFormatDefaultValue         bool IL2CPP_TYPE_BOOLEAN
    // 024 MessageSetWireFormat                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 NoStandardDescriptorAccessorFieldNumber  int IL2CPP_TYPE_I4
    // 009 NoStandardDescriptorAccessorDefaultValue bool IL2CPP_TYPE_BOOLEAN
    // 025 NoStandardDescriptorAccessor             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 DeprecatedFieldNumber                    int IL2CPP_TYPE_I4
    // 00A DeprecatedDefaultValue                   bool IL2CPP_TYPE_BOOLEAN
    // 026 Deprecated                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 MapEntryFieldNumber                      int IL2CPP_TYPE_I4
    // 00B MapEntryDefaultValue                     bool IL2CPP_TYPE_BOOLEAN
    // 027 MapEntry                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 UninterpretedOptionFieldNumber           int IL2CPP_TYPE_I4
    // 010 _repeated_uninterpretedOption_codec      FieldCodec`1<UninterpretedOption> IL2CPP_TYPE_GENERICINST
    // 028 UninterpretedOption                      000185CF62B8 ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer
    public partial class MessageOptions : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public bool                                     MessageSetWireFormat                    { get; set; }
        public bool                                     NoStandardDescriptorAccessor            { get; set; }
        public bool                                     Deprecated                              { get; set; }
        public bool                                     MapEntry                                { get; set; }
        public List<UninterpretedOption>?               UninterpretedOption                     { get; set; }

        public static MessageOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageOptions() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x020)); // 024660B972F8 0x20 HasBits0                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MessageSetWireFormat                      = GetBool(new IntPtr(p + 0x024)); // 024660B97358 0x24 MessageSetWireFormat        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NoStandardDescriptorAccessor              = GetBool(new IntPtr(p + 0x025)); // 024660B973B8 0x25 NoStandardDescriptorAccessor ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Deprecated                                = GetBool(new IntPtr(p + 0x026)); // 024660B97418 0x26 Deprecated                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MapEntry                                  = GetBool(new IntPtr(p + 0x027)); // 024660B97478 0x27 MapEntry                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UninterpretedOption                       = GetObjectList<UninterpretedOption>(new IntPtr(p + 0x028), ReversePrism.DataModels.UninterpretedOption.FromPointer); // 024660B974D8 0x28 UninterpretedOption         ( 000185CF62B8 ModelClassListType RepeatedField`1<UninterpretedOption> RepeatedField`1<UninterpretedOption> List<UninterpretedOption> Pointer )

            return value;
        }
    }
}

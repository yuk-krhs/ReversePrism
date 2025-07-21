using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Enum> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     ModelPrimitiveType string string string String
    // 000 EnumvalueFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_enumvalue_codec                FieldCodec`1<EnumValue> IL2CPP_TYPE_GENERICINST
    // 020 Enumvalue                                ModelClassListType RepeatedField`1<EnumValue> RepeatedField`1<EnumValue> List<EnumValue> Pointer
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 010 _repeated_options_codec                  FieldCodec`1<Option> IL2CPP_TYPE_GENERICINST
    // 028 Options                                  ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer
    // 000 SourceContextFieldNumber                 int IL2CPP_TYPE_I4
    // 030 SourceContext                            ModelClassType SourceContext SourceContext SourceContext Pointer
    // 000 SyntaxFieldNumber                        int IL2CPP_TYPE_I4
    // 038 Syntax                                   ModelEnumType Syntax Syntax Syntax Int32
    // 000 EditionFieldNumber                       int IL2CPP_TYPE_I4
    // 040 Edition                                  ModelPrimitiveType string string string String
    public partial class Enum : DataModel
    {
        public string                                   Name                                    { get; set; }
        public List<EnumValue>?                         Enumvalue                               { get; set; }
        public List<Option>?                            Options                                 { get; set; }
        public SourceContext?                           SourceContext                           { get; set; }
        public Syntax                                   Syntax                                  { get; set; }
        public string                                   Edition                                 { get; set; }

        public static Enum? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Enum() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.Enumvalue                                 = GetObjectList<EnumValue>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnumValue.FromPointer); // 0x20 Enumvalue                   ( ModelClassListType RepeatedField`1<EnumValue> RepeatedField`1<EnumValue> List<EnumValue> Pointer )
            value.Options                                   = GetObjectList<Option>(new IntPtr(p + 0x028), ReversePrism.DataModels.Option.FromPointer); // 0x28 Options                     ( ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer )
            value.SourceContext                             = GetObject<SourceContext>(new IntPtr(p + 0x030), ReversePrism.DataModels.SourceContext.FromPointer); // 0x30 SourceContext               ( ModelClassType SourceContext SourceContext SourceContext Pointer )
            value.Syntax                                    = (Syntax)GetInt32(new IntPtr(p + 0x038)); // 0x38 Syntax                      ( ModelEnumType Syntax Syntax Syntax Int32 )
            value.Edition                                   = GetString(new IntPtr(p + 0x040)); // 0x40 Edition                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}

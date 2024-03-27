using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Type> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 FieldsFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _repeated_fields_codec                   FieldCodec`1<Field> IL2CPP_TYPE_GENERICINST
    // 020 Fields                                   000185CD88A8 ModelClassListType RepeatedField`1<Field> RepeatedField`1<Field> List<Field> Pointer
    // 000 OneofsFieldNumber                        int IL2CPP_TYPE_I4
    // 010 _repeated_oneofs_codec                   FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 028 Oneofs                                   000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 018 _repeated_options_codec                  FieldCodec`1<Option> IL2CPP_TYPE_GENERICINST
    // 030 Options                                  000185CE83A8 ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer
    // 000 SourceContextFieldNumber                 int IL2CPP_TYPE_I4
    // 038 SourceContext                            0001865399F0 ModelClassType SourceContext SourceContext SourceContext Pointer
    // 000 SyntaxFieldNumber                        int IL2CPP_TYPE_I4
    // 040 Syntax                                   000186604390 ModelEnumType Syntax Syntax Syntax Int32
    public partial class Type
    {
        public string                                   Name                                    { get; set; }
        public List<Field>?                             Fields                                  { get; set; }
        public List<string>?                            Oneofs                                  { get; set; }
        public List<Option>?                            Options                                 { get; set; }
        public SourceContext?                           SourceContext                           { get; set; }
        public Syntax                                   Syntax                                  { get; set; }

        public static Type? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Type();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270DA4AA250 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Fields                                    = GetObjectList<Field>(new IntPtr(p + 0x020), ReversePrism.DataModels.Field.FromPointer); // 0270DA4AA2B0 0x20 Fields                      ( 000185CD88A8 ModelClassListType RepeatedField`1<Field> RepeatedField`1<Field> List<Field> Pointer )
            value.Oneofs                                    = GetStringList(new IntPtr(p + 0x028)); // 0270DA4AA310 0x28 Oneofs                      ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.Options                                   = GetObjectList<Option>(new IntPtr(p + 0x030), ReversePrism.DataModels.Option.FromPointer); // 0270DA4AA370 0x30 Options                     ( 000185CE83A8 ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer )
            value.SourceContext                             = GetObject<SourceContext>(new IntPtr(p + 0x038), ReversePrism.DataModels.SourceContext.FromPointer); // 0270DA4AA3B0 0x38 SourceContext               ( 0001865399F0 ModelClassType SourceContext SourceContext SourceContext Pointer )
            value.Syntax                                    = (Syntax)GetInt32(new IntPtr(p + 0x040)); // 0270DA4AA3F0 0x40 Syntax                      ( 000186604390 ModelEnumType Syntax Syntax Syntax Int32 )

            return value;
        }
    }
}

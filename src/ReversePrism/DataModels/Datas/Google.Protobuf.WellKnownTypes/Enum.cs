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
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 EnumvalueFieldNumber                     int IL2CPP_TYPE_I4
    // 008 _repeated_enumvalue_codec                FieldCodec`1<EnumValue> IL2CPP_TYPE_GENERICINST
    // 020 Enumvalue                                000185CD4738 ModelClassListType RepeatedField`1<EnumValue> RepeatedField`1<EnumValue> List<EnumValue> Pointer
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 010 _repeated_options_codec                  FieldCodec`1<Option> IL2CPP_TYPE_GENERICINST
    // 028 Options                                  000185CE83A8 ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer
    // 000 SourceContextFieldNumber                 int IL2CPP_TYPE_I4
    // 030 SourceContext                            0001865399F0 ModelClassType SourceContext SourceContext SourceContext Pointer
    // 000 SyntaxFieldNumber                        int IL2CPP_TYPE_I4
    // 038 Syntax                                   000186604390 ModelEnumType Syntax Syntax Syntax Int32
    public partial class Enum
    {
        public string                                   Name                                    { get; set; }
        public List<EnumValue>?                         Enumvalue                               { get; set; }
        public List<Option>?                            Options                                 { get; set; }
        public SourceContext?                           SourceContext                           { get; set; }
        public Syntax                                   Syntax                                  { get; set; }

        public static Enum? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Enum();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270DA4BC548 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Enumvalue                                 = GetObjectList<EnumValue>(new IntPtr(p + 0x020), ReversePrism.DataModels.EnumValue.FromPointer); // 0270DA4BC5A8 0x20 Enumvalue                   ( 000185CD4738 ModelClassListType RepeatedField`1<EnumValue> RepeatedField`1<EnumValue> List<EnumValue> Pointer )
            value.Options                                   = GetObjectList<Option>(new IntPtr(p + 0x028), ReversePrism.DataModels.Option.FromPointer); // 0270DA4BC608 0x28 Options                     ( 000185CE83A8 ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer )
            value.SourceContext                             = GetObject<SourceContext>(new IntPtr(p + 0x030), ReversePrism.DataModels.SourceContext.FromPointer); // 0270DA4BC648 0x30 SourceContext               ( 0001865399F0 ModelClassType SourceContext SourceContext SourceContext Pointer )
            value.Syntax                                    = (Syntax)GetInt32(new IntPtr(p + 0x038)); // 0270DA4BC688 0x38 Syntax                      ( 000186604390 ModelEnumType Syntax Syntax Syntax Int32 )

            return value;
        }
    }
}

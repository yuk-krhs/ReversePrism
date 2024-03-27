using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Api> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 MethodsFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_methods_codec                  FieldCodec`1<Method> IL2CPP_TYPE_GENERICINST
    // 020 Methods                                  000185CE6098 ModelClassListType RepeatedField`1<Method> RepeatedField`1<Method> List<Method> Pointer
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 010 _repeated_options_codec                  FieldCodec`1<Option> IL2CPP_TYPE_GENERICINST
    // 028 Options                                  000185CE83A8 ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer
    // 000 VersionFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Version                                  000186671910 ModelPrimitiveType string string string String
    // 000 SourceContextFieldNumber                 int IL2CPP_TYPE_I4
    // 038 SourceContext                            0001865399F0 ModelClassType SourceContext SourceContext SourceContext Pointer
    // 000 MixinsFieldNumber                        int IL2CPP_TYPE_I4
    // 018 _repeated_mixins_codec                   FieldCodec`1<Mixin> IL2CPP_TYPE_GENERICINST
    // 040 Mixins                                   000185CE7348 ModelClassListType RepeatedField`1<Mixin> RepeatedField`1<Mixin> List<Mixin> Pointer
    // 000 SyntaxFieldNumber                        int IL2CPP_TYPE_I4
    // 048 Syntax                                   000186604390 ModelEnumType Syntax Syntax Syntax Int32
    public partial class Api
    {
        public string                                   Name                                    { get; set; }
        public List<Method>?                            Methods                                 { get; set; }
        public List<Option>?                            Options                                 { get; set; }
        public string                                   Version                                 { get; set; }
        public SourceContext?                           SourceContext                           { get; set; }
        public List<Mixin>?                             Mixins                                  { get; set; }
        public Syntax                                   Syntax                                  { get; set; }

        public static Api? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Api();

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0270DA451E00 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Methods                                   = GetObjectList<Method>(new IntPtr(p + 0x020), ReversePrism.DataModels.Method.FromPointer); // 0270DA451E60 0x20 Methods                     ( 000185CE6098 ModelClassListType RepeatedField`1<Method> RepeatedField`1<Method> List<Method> Pointer )
            value.Options                                   = GetObjectList<Option>(new IntPtr(p + 0x028), ReversePrism.DataModels.Option.FromPointer); // 0270DA451EC0 0x28 Options                     ( 000185CE83A8 ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer )
            value.Version                                   = GetString(new IntPtr(p + 0x030)); // 0270DA451F00 0x30 Version                     ( 000186671910 ModelPrimitiveType string string string String )
            value.SourceContext                             = GetObject<SourceContext>(new IntPtr(p + 0x038), ReversePrism.DataModels.SourceContext.FromPointer); // 0270DA451F40 0x38 SourceContext               ( 0001865399F0 ModelClassType SourceContext SourceContext SourceContext Pointer )
            value.Mixins                                    = GetObjectList<Mixin>(new IntPtr(p + 0x040), ReversePrism.DataModels.Mixin.FromPointer); // 0270DA451FA0 0x40 Mixins                      ( 000185CE7348 ModelClassListType RepeatedField`1<Mixin> RepeatedField`1<Mixin> List<Mixin> Pointer )
            value.Syntax                                    = (Syntax)GetInt32(new IntPtr(p + 0x048)); // 0270DA451FE0 0x48 Syntax                      ( 000186604390 ModelEnumType Syntax Syntax Syntax Int32 )

            return value;
        }
    }
}

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
    // 018 Name                                     ModelPrimitiveType string string string String
    // 000 MethodsFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_methods_codec                  FieldCodec`1<Method> IL2CPP_TYPE_GENERICINST
    // 020 Methods                                  ModelClassListType RepeatedField`1<Method> RepeatedField`1<Method> List<Method> Pointer
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 010 _repeated_options_codec                  FieldCodec`1<Option> IL2CPP_TYPE_GENERICINST
    // 028 Options                                  ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer
    // 000 VersionFieldNumber                       int IL2CPP_TYPE_I4
    // 030 Version                                  ModelPrimitiveType string string string String
    // 000 SourceContextFieldNumber                 int IL2CPP_TYPE_I4
    // 038 SourceContext                            ModelClassType SourceContext SourceContext SourceContext Pointer
    // 000 MixinsFieldNumber                        int IL2CPP_TYPE_I4
    // 018 _repeated_mixins_codec                   FieldCodec`1<Mixin> IL2CPP_TYPE_GENERICINST
    // 040 Mixins                                   ModelClassListType RepeatedField`1<Mixin> RepeatedField`1<Mixin> List<Mixin> Pointer
    // 000 SyntaxFieldNumber                        int IL2CPP_TYPE_I4
    // 048 Syntax                                   ModelEnumType Syntax Syntax Syntax Int32
    public partial class Api : DataModel
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
            var value   = new Api() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.Methods                                   = GetObjectList<Method>(new IntPtr(p + 0x020), ReversePrism.DataModels.Method.FromPointer); // 0x20 Methods                     ( ModelClassListType RepeatedField`1<Method> RepeatedField`1<Method> List<Method> Pointer )
            value.Options                                   = GetObjectList<Option>(new IntPtr(p + 0x028), ReversePrism.DataModels.Option.FromPointer); // 0x28 Options                     ( ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer )
            value.Version                                   = GetString(new IntPtr(p + 0x030)); // 0x30 Version                     ( ModelPrimitiveType string string string String )
            value.SourceContext                             = GetObject<SourceContext>(new IntPtr(p + 0x038), ReversePrism.DataModels.SourceContext.FromPointer); // 0x38 SourceContext               ( ModelClassType SourceContext SourceContext SourceContext Pointer )
            value.Mixins                                    = GetObjectList<Mixin>(new IntPtr(p + 0x040), ReversePrism.DataModels.Mixin.FromPointer); // 0x40 Mixins                      ( ModelClassListType RepeatedField`1<Mixin> RepeatedField`1<Mixin> List<Mixin> Pointer )
            value.Syntax                                    = (Syntax)GetInt32(new IntPtr(p + 0x048)); // 0x48 Syntax                      ( ModelEnumType Syntax Syntax Syntax Int32 )

            return value;
        }
    }
}

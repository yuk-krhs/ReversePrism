using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Method> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 RequestTypeUrlFieldNumber                int IL2CPP_TYPE_I4
    // 020 RequestTypeUrl                           000186671910 ModelPrimitiveType string string string String
    // 000 RequestStreamingFieldNumber              int IL2CPP_TYPE_I4
    // 028 RequestStreaming                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ResponseTypeUrlFieldNumber               int IL2CPP_TYPE_I4
    // 030 ResponseTypeUrl                          000186671910 ModelPrimitiveType string string string String
    // 000 ResponseStreamingFieldNumber             int IL2CPP_TYPE_I4
    // 038 ResponseStreaming                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_options_codec                  FieldCodec`1<Option> IL2CPP_TYPE_GENERICINST
    // 040 Options                                  000185CE83A8 ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer
    // 000 SyntaxFieldNumber                        int IL2CPP_TYPE_I4
    // 048 Syntax                                   000186604390 ModelEnumType Syntax Syntax Syntax Int32
    public partial class Method : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   RequestTypeUrl                          { get; set; }
        public bool                                     RequestStreaming                        { get; set; }
        public string                                   ResponseTypeUrl                         { get; set; }
        public bool                                     ResponseStreaming                       { get; set; }
        public List<Option>?                            Options                                 { get; set; }
        public Syntax                                   Syntax                                  { get; set; }

        public static Method? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Method() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 02466A4AFAF8 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.RequestTypeUrl                            = GetString(new IntPtr(p + 0x020)); // 02466A4AFB38 0x20 RequestTypeUrl              ( 000186671910 ModelPrimitiveType string string string String )
            value.RequestStreaming                          = GetBool(new IntPtr(p + 0x028)); // 02466A4AFB78 0x28 RequestStreaming            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ResponseTypeUrl                           = GetString(new IntPtr(p + 0x030)); // 02466A4AFBB8 0x30 ResponseTypeUrl             ( 000186671910 ModelPrimitiveType string string string String )
            value.ResponseStreaming                         = GetBool(new IntPtr(p + 0x038)); // 02466A4AFBF8 0x38 ResponseStreaming           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Options                                   = GetObjectList<Option>(new IntPtr(p + 0x040), ReversePrism.DataModels.Option.FromPointer); // 02466A4AFC58 0x40 Options                     ( 000185CE83A8 ModelClassListType RepeatedField`1<Option> RepeatedField`1<Option> List<Option> Pointer )
            value.Syntax                                    = (Syntax)GetInt32(new IntPtr(p + 0x048)); // 02466A4AFC98 0x48 Syntax                      ( 000186604390 ModelEnumType Syntax Syntax Syntax Int32 )

            return value;
        }
    }
}

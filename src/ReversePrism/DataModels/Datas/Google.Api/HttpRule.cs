using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<HttpRule> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SelectorFieldNumber                      int IL2CPP_TYPE_I4
    // 018 Selector                                 000186671910 ModelPrimitiveType string string string String
    // 000 GetFieldNumber                           int IL2CPP_TYPE_I4
    // 000 PutFieldNumber                           int IL2CPP_TYPE_I4
    // 000 PostFieldNumber                          int IL2CPP_TYPE_I4
    // 000 DeleteFieldNumber                        int IL2CPP_TYPE_I4
    // 000 PatchFieldNumber                         int IL2CPP_TYPE_I4
    // 000 CustomFieldNumber                        int IL2CPP_TYPE_I4
    // 000 BodyFieldNumber                          int IL2CPP_TYPE_I4
    // 020 Body                                     000186671910 ModelPrimitiveType string string string String
    // 000 ResponseBodyFieldNumber                  int IL2CPP_TYPE_I4
    // 028 ResponseBody                             000186671910 ModelPrimitiveType string string string String
    // 000 AdditionalBindingsFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_additionalBindings_codec       FieldCodec`1<HttpRule> IL2CPP_TYPE_GENERICINST
    // 030 AdditionalBindings                       000185CDECF8 ModelClassListType RepeatedField`1<HttpRule> RepeatedField`1<HttpRule> List<HttpRule> Pointer
    // 038 pattern_                                 <object> IL2CPP_TYPE_OBJECT
    // 040 PatternCase                              000186565BF0 ModelEnumType PatternOneofCase PatternOneofCase PatternOneofCase Int32
    public partial class HttpRule : DataModel
    {
        public string                                   Selector                                { get; set; }
        public string                                   Body                                    { get; set; }
        public string                                   ResponseBody                            { get; set; }
        public List<HttpRule>?                          AdditionalBindings                      { get; set; }
        public PatternOneofCase                         PatternCase                             { get; set; }

        public static HttpRule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpRule() { Pointer= p0 };

            value.Selector                                  = GetString(new IntPtr(p + 0x018)); // 02466A777438 0x18 Selector                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Body                                      = GetString(new IntPtr(p + 0x020)); // 02466A777538 0x20 Body                        ( 000186671910 ModelPrimitiveType string string string String )
            value.ResponseBody                              = GetString(new IntPtr(p + 0x028)); // 02466A777578 0x28 ResponseBody                ( 000186671910 ModelPrimitiveType string string string String )
            value.AdditionalBindings                        = GetObjectList<HttpRule>(new IntPtr(p + 0x030), ReversePrism.DataModels.HttpRule.FromPointer); // 02466A7775D8 0x30 AdditionalBindings          ( 000185CDECF8 ModelClassListType RepeatedField`1<HttpRule> RepeatedField`1<HttpRule> List<HttpRule> Pointer )
            value.PatternCase                               = (PatternOneofCase)GetInt32(new IntPtr(p + 0x040)); // 02466A777618 0x40 PatternCase                 ( 000186565BF0 ModelEnumType PatternOneofCase PatternOneofCase PatternOneofCase Int32 )

            return value;
        }
    }
}

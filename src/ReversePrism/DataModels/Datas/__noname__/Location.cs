using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Location> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 PathFieldNumber                          int IL2CPP_TYPE_I4
    // 008 _repeated_path_codec                     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 018 Path                                     000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 SpanFieldNumber                          int IL2CPP_TYPE_I4
    // 010 _repeated_span_codec                     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 Span                                     000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 LeadingCommentsFieldNumber               int IL2CPP_TYPE_I4
    // 018 LeadingCommentsDefaultValue              0001866738F0 ModelPrimitiveType string string string String
    // 028 LeadingComments                          000186671910 ModelPrimitiveType string string string String
    // 000 TrailingCommentsFieldNumber              int IL2CPP_TYPE_I4
    // 020 TrailingCommentsDefaultValue             0001866738F0 ModelPrimitiveType string string string String
    // 030 TrailingComments                         000186671910 ModelPrimitiveType string string string String
    // 000 LeadingDetachedCommentsFieldNumber       int IL2CPP_TYPE_I4
    // 028 _repeated_leadingDetachedComments_codec  FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 038 LeadingDetachedComments                  000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class Location
    {
        public List<int>?                               Path                                    { get; set; }
        public List<int>?                               Span                                    { get; set; }
        public string                                   LeadingCommentsDefaultValue             { get; set; }
        public string                                   LeadingComments                         { get; set; }
        public string                                   TrailingCommentsDefaultValue            { get; set; }
        public string                                   TrailingComments                        { get; set; }
        public List<string>?                            LeadingDetachedComments                 { get; set; }

        public static Location? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Location();

            value.Path                                      = GetInt32List(new IntPtr(p + 0x018)); // 0270D0BC14F8 0x18 Path                        ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.Span                                      = GetInt32List(new IntPtr(p + 0x020)); // 0270D0BC1558 0x20 Span                        ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.LeadingCommentsDefaultValue               = GetString(new IntPtr(p + 0x018)); // 0270D0BC1598 0x18 LeadingCommentsDefaultValue ( 0001866738F0 ModelPrimitiveType string string string String )
            value.LeadingComments                           = GetString(new IntPtr(p + 0x028)); // 0270D0BC15B8 0x28 LeadingComments             ( 000186671910 ModelPrimitiveType string string string String )
            value.TrailingCommentsDefaultValue              = GetString(new IntPtr(p + 0x020)); // 0270D0BC15F8 0x20 TrailingCommentsDefaultValue ( 0001866738F0 ModelPrimitiveType string string string String )
            value.TrailingComments                          = GetString(new IntPtr(p + 0x030)); // 0270D0BC1618 0x30 TrailingComments            ( 000186671910 ModelPrimitiveType string string string String )
            value.LeadingDetachedComments                   = GetStringList(new IntPtr(p + 0x038)); // 0270D0BC1678 0x38 LeadingDetachedComments     ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}

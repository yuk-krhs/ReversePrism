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
    // 018 Path                                     ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 SpanFieldNumber                          int IL2CPP_TYPE_I4
    // 010 _repeated_span_codec                     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 Span                                     ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 LeadingCommentsFieldNumber               int IL2CPP_TYPE_I4
    // 018 LeadingCommentsDefaultValue              ModelPrimitiveType string string string String
    // 028 LeadingComments                          ModelPrimitiveType string string string String
    // 000 TrailingCommentsFieldNumber              int IL2CPP_TYPE_I4
    // 020 TrailingCommentsDefaultValue             ModelPrimitiveType string string string String
    // 030 TrailingComments                         ModelPrimitiveType string string string String
    // 000 LeadingDetachedCommentsFieldNumber       int IL2CPP_TYPE_I4
    // 028 _repeated_leadingDetachedComments_codec  FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 038 LeadingDetachedComments                  ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    public partial class Location : DataModel
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
            var value   = new Location() { Pointer= p0 };

            value.Path                                      = GetInt32List(new IntPtr(p + 0x018)); // 0x18 Path                        ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.Span                                      = GetInt32List(new IntPtr(p + 0x020)); // 0x20 Span                        ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.LeadingCommentsDefaultValue               = GetString(new IntPtr(p + 0x018)); // 0x18 LeadingCommentsDefaultValue ( ModelPrimitiveType string string string String )
            value.LeadingComments                           = GetString(new IntPtr(p + 0x028)); // 0x28 LeadingComments             ( ModelPrimitiveType string string string String )
            value.TrailingCommentsDefaultValue              = GetString(new IntPtr(p + 0x020)); // 0x20 TrailingCommentsDefaultValue ( ModelPrimitiveType string string string String )
            value.TrailingComments                          = GetString(new IntPtr(p + 0x030)); // 0x30 TrailingComments            ( ModelPrimitiveType string string string String )
            value.LeadingDetachedComments                   = GetStringList(new IntPtr(p + 0x038)); // 0x38 LeadingDetachedComments     ( ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )

            return value;
        }
    }
}

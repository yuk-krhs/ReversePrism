using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ResourceDescriptor> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Type                                     000186671910 ModelPrimitiveType string string string String
    // 000 PatternFieldNumber                       int IL2CPP_TYPE_I4
    // 008 _repeated_pattern_codec                  FieldCodec`1<string> IL2CPP_TYPE_GENERICINST
    // 020 Pattern                                  000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer
    // 000 NameFieldFieldNumber                     int IL2CPP_TYPE_I4
    // 028 NameField                                000186671910 ModelPrimitiveType string string string String
    // 000 HistoryFieldNumber                       int IL2CPP_TYPE_I4
    // 030 History                                  000186572690 ModelEnumType History History History Int32
    // 000 PluralFieldNumber                        int IL2CPP_TYPE_I4
    // 038 Plural                                   000186671910 ModelPrimitiveType string string string String
    // 000 SingularFieldNumber                      int IL2CPP_TYPE_I4
    // 040 Singular                                 000186671910 ModelPrimitiveType string string string String
    // 000 StyleFieldNumber                         int IL2CPP_TYPE_I4
    // 010 _repeated_style_codec                    FieldCodec`1<Style> IL2CPP_TYPE_GENERICINST
    // 048 Style                                    000185CF9B48 ModelEnumListType RepeatedField`1<Style> RepeatedField`1<Style> List<Style> Pointer
    public partial class ResourceDescriptor
    {
        public string                                   Type                                    { get; set; }
        public List<string>?                            Pattern                                 { get; set; }
        public string                                   NameField                               { get; set; }
        public History                                  History                                 { get; set; }
        public string                                   Plural                                  { get; set; }
        public string                                   Singular                                { get; set; }
        public List<Style>?                             Style                                   { get; set; }

        public static ResourceDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceDescriptor();

            value.Type                                      = GetString(new IntPtr(p + 0x018)); // 0270DA848B50 0x18 Type                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Pattern                                   = GetStringList(new IntPtr(p + 0x020)); // 0270DA848BB0 0x20 Pattern                     ( 000185CF3478 ModelPrimitiveListType RepeatedField`1<string> RepeatedField`1<string> List<string> Pointer )
            value.NameField                                 = GetString(new IntPtr(p + 0x028)); // 0270DA848BF0 0x28 NameField                   ( 000186671910 ModelPrimitiveType string string string String )
            value.History                                   = (History)GetInt32(new IntPtr(p + 0x030)); // 0270DA848C30 0x30 History                     ( 000186572690 ModelEnumType History History History Int32 )
            value.Plural                                    = GetString(new IntPtr(p + 0x038)); // 0270DA848C70 0x38 Plural                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Singular                                  = GetString(new IntPtr(p + 0x040)); // 0270DA848CB0 0x40 Singular                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Style                                     = GetEnumList<Style>(new IntPtr(p + 0x048)); // 0270DA848D10 0x48 Style                       ( 000185CF9B48 ModelEnumListType RepeatedField`1<Style> RepeatedField`1<Style> List<Style> Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BACK_SLASH                               char IL2CPP_TYPE_CHAR
    // 000 FORWARD_SLASH                            char IL2CPP_TYPE_CHAR
    // 000 HIGH_SURROGATE_START                     char IL2CPP_TYPE_CHAR
    // 000 LOW_SURROGATE_END                        char IL2CPP_TYPE_CHAR
    // 000 MAX_CHAR                                 char IL2CPP_TYPE_CHAR
    // 000 WHITESPACE                               char IL2CPP_TYPE_CHAR
    // 000 CARRIAGE_RETURN                          char IL2CPP_TYPE_CHAR
    // 000 NEWLINE                                  char IL2CPP_TYPE_CHAR
    // 000 BACKSPACE                                char IL2CPP_TYPE_CHAR
    // 000 FORM_FEED                                char IL2CPP_TYPE_CHAR
    // 000 HORIZONTAL_TABULATION                    char IL2CPP_TYPE_CHAR
    // 000 xmlNamespace                             string IL2CPP_TYPE_STRING
    // 000 xmlnsNamespace                           string IL2CPP_TYPE_STRING
    // 000 binHexEncoding                           BinHexEncoding IL2CPP_TYPE_CLASS
    // 008 CharacterAbbrevs                         char[] IL2CPP_TYPE_SZARRAY
    // 018 AttributeText                            000186671910 ModelPrimitiveType string string string String
    // 020 DataType                                 000186738170 ModelEnumType JsonDataType JsonDataType JsonDataType Int32
    // 024 Depth                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 EndElementBuffer                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 IsWritingDataTypeAttribute               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02A IsWritingServerTypeAttribute             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02B IsWritingXmlnsAttribute                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C IsWritingXmlnsAttributeDefaultNs         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 NameState                                000186738D60 ModelEnumType NameState NameState NameState Int32
    // 034 NodeType                                 000186756FE0 ModelEnumType JsonNodeType JsonNodeType JsonNodeType Int32
    // 038 NodeWriter                               000186738860 ModelClassType JsonNodeWriter JsonNodeWriter JsonNodeWriter Pointer
    // 040 Scopes                                   000185B8F180 ModelEnumListType JsonNodeType[] JsonNodeType[] List<JsonNodeType> Pointer
    // 048 ServerTypeValue                          000186671910 ModelPrimitiveType string string string String
    // 050 WriteState                               0001865618F0 ModelEnumType WriteState WriteState WriteState Int32
    // 054 WroteServerTypeAttribute                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 055 Indent                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 IndentChars                              000186671910 ModelPrimitiveType string string string String
    // 060 IndentLevel                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlJsonWriter : DataModel
    {
        public string                                   AttributeText                           { get; set; }
        public JsonDataType                             DataType                                { get; set; }
        public int                                      Depth                                   { get; set; }
        public bool                                     EndElementBuffer                        { get; set; }
        public bool                                     IsWritingDataTypeAttribute              { get; set; }
        public bool                                     IsWritingServerTypeAttribute            { get; set; }
        public bool                                     IsWritingXmlnsAttribute                 { get; set; }
        public bool                                     IsWritingXmlnsAttributeDefaultNs        { get; set; }
        public NameState                                NameState                               { get; set; }
        public JsonNodeType                             NodeType                                { get; set; }
        public JsonNodeWriter?                          NodeWriter                              { get; set; }
        public List<JsonNodeType>?                      Scopes                                  { get; set; }
        public string                                   ServerTypeValue                         { get; set; }
        public WriteState                               WriteState                              { get; set; }
        public bool                                     WroteServerTypeAttribute                { get; set; }
        public bool                                     Indent                                  { get; set; }
        public string                                   IndentChars                             { get; set; }
        public int                                      IndentLevel                             { get; set; }

        public static XmlJsonWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlJsonWriter() { Pointer= p0 };

            value.AttributeText                             = GetString(new IntPtr(p + 0x018)); // 0245A4DBD680 0x18 AttributeText               ( 000186671910 ModelPrimitiveType string string string String )
            value.DataType                                  = (JsonDataType)GetInt32(new IntPtr(p + 0x020)); // 0245A4DBD6A0 0x20 DataType                    ( 000186738170 ModelEnumType JsonDataType JsonDataType JsonDataType Int32 )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x024)); // 0245A4DBD6C0 0x24 Depth                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndElementBuffer                          = GetBool(new IntPtr(p + 0x028)); // 0245A4DBD6E0 0x28 EndElementBuffer            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsWritingDataTypeAttribute                = GetBool(new IntPtr(p + 0x029)); // 0245A4DBD700 0x29 IsWritingDataTypeAttribute  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsWritingServerTypeAttribute              = GetBool(new IntPtr(p + 0x02A)); // 0245A4DBD720 0x2A IsWritingServerTypeAttribute ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsWritingXmlnsAttribute                   = GetBool(new IntPtr(p + 0x02B)); // 0245A4DBD740 0x2B IsWritingXmlnsAttribute     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsWritingXmlnsAttributeDefaultNs          = GetBool(new IntPtr(p + 0x02C)); // 0245A4DBD760 0x2C IsWritingXmlnsAttributeDefaultNs ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NameState                                 = (NameState)GetInt32(new IntPtr(p + 0x030)); // 0245A4DBD780 0x30 NameState                   ( 000186738D60 ModelEnumType NameState NameState NameState Int32 )
            value.NodeType                                  = (JsonNodeType)GetInt32(new IntPtr(p + 0x034)); // 0245A4DBD7A0 0x34 NodeType                    ( 000186756FE0 ModelEnumType JsonNodeType JsonNodeType JsonNodeType Int32 )
            value.NodeWriter                                = GetObject<JsonNodeWriter>(new IntPtr(p + 0x038), ReversePrism.DataModels.JsonNodeWriter.FromPointer); // 0245A4DBD7C0 0x38 NodeWriter                  ( 000186738860 ModelClassType JsonNodeWriter JsonNodeWriter JsonNodeWriter Pointer )
            value.Scopes                                    = GetEnumList<JsonNodeType>(new IntPtr(p + 0x040)); // 0245A4DBD7E0 0x40 Scopes                      ( 000185B8F180 ModelEnumListType JsonNodeType[] JsonNodeType[] List<JsonNodeType> Pointer )
            value.ServerTypeValue                           = GetString(new IntPtr(p + 0x048)); // 0245A4DBD800 0x48 ServerTypeValue             ( 000186671910 ModelPrimitiveType string string string String )
            value.WriteState                                = (WriteState)GetInt32(new IntPtr(p + 0x050)); // 0245A4DBD820 0x50 WriteState                  ( 0001865618F0 ModelEnumType WriteState WriteState WriteState Int32 )
            value.WroteServerTypeAttribute                  = GetBool(new IntPtr(p + 0x054)); // 0245A4DBD840 0x54 WroteServerTypeAttribute    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Indent                                    = GetBool(new IntPtr(p + 0x055)); // 0245A4DBD860 0x55 Indent                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IndentChars                               = GetString(new IntPtr(p + 0x058)); // 0245A4DBD880 0x58 IndentChars                 ( 000186671910 ModelPrimitiveType string string string String )
            value.IndentLevel                               = GetInt32(new IntPtr(p + 0x060)); // 0245A4DBD8A0 0x60 IndentLevel                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

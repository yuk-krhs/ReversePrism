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
    // 018 AttributeText                            ModelPrimitiveType string string string String
    // 020 DataType                                 ModelEnumType JsonDataType JsonDataType JsonDataType Int32
    // 024 Depth                                    ModelPrimitiveType int int int Int32
    // 028 EndElementBuffer                         ModelPrimitiveType bool bool bool Bool
    // 029 IsWritingDataTypeAttribute               ModelPrimitiveType bool bool bool Bool
    // 02A IsWritingServerTypeAttribute             ModelPrimitiveType bool bool bool Bool
    // 02B IsWritingXmlnsAttribute                  ModelPrimitiveType bool bool bool Bool
    // 02C IsWritingXmlnsAttributeDefaultNs         ModelPrimitiveType bool bool bool Bool
    // 030 NameState                                ModelEnumType NameState NameState NameState Int32
    // 034 NodeType                                 ModelEnumType JsonNodeType JsonNodeType JsonNodeType Int32
    // 038 NodeWriter                               ModelClassType JsonNodeWriter JsonNodeWriter JsonNodeWriter Pointer
    // 040 Scopes                                   ModelEnumListType JsonNodeType[] JsonNodeType[] List<JsonNodeType> Pointer
    // 048 ServerTypeValue                          ModelPrimitiveType string string string String
    // 050 WriteState                               ModelEnumType WriteState WriteState WriteState Int32
    // 054 WroteServerTypeAttribute                 ModelPrimitiveType bool bool bool Bool
    // 055 Indent                                   ModelPrimitiveType bool bool bool Bool
    // 058 IndentChars                              ModelPrimitiveType string string string String
    // 060 IndentLevel                              ModelPrimitiveType int int int Int32
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

            value.AttributeText                             = GetString(new IntPtr(p + 0x018)); // 0x18 AttributeText               ( ModelPrimitiveType string string string String )
            value.DataType                                  = (JsonDataType)GetInt32(new IntPtr(p + 0x020)); // 0x20 DataType                    ( ModelEnumType JsonDataType JsonDataType JsonDataType Int32 )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 Depth                       ( ModelPrimitiveType int int int Int32 )
            value.EndElementBuffer                          = GetBool(new IntPtr(p + 0x028)); // 0x28 EndElementBuffer            ( ModelPrimitiveType bool bool bool Bool )
            value.IsWritingDataTypeAttribute                = GetBool(new IntPtr(p + 0x029)); // 0x29 IsWritingDataTypeAttribute  ( ModelPrimitiveType bool bool bool Bool )
            value.IsWritingServerTypeAttribute              = GetBool(new IntPtr(p + 0x02A)); // 0x2A IsWritingServerTypeAttribute ( ModelPrimitiveType bool bool bool Bool )
            value.IsWritingXmlnsAttribute                   = GetBool(new IntPtr(p + 0x02B)); // 0x2B IsWritingXmlnsAttribute     ( ModelPrimitiveType bool bool bool Bool )
            value.IsWritingXmlnsAttributeDefaultNs          = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsWritingXmlnsAttributeDefaultNs ( ModelPrimitiveType bool bool bool Bool )
            value.NameState                                 = (NameState)GetInt32(new IntPtr(p + 0x030)); // 0x30 NameState                   ( ModelEnumType NameState NameState NameState Int32 )
            value.NodeType                                  = (JsonNodeType)GetInt32(new IntPtr(p + 0x034)); // 0x34 NodeType                    ( ModelEnumType JsonNodeType JsonNodeType JsonNodeType Int32 )
            value.NodeWriter                                = GetObject<JsonNodeWriter>(new IntPtr(p + 0x038), ReversePrism.DataModels.JsonNodeWriter.FromPointer); // 0x38 NodeWriter                  ( ModelClassType JsonNodeWriter JsonNodeWriter JsonNodeWriter Pointer )
            value.Scopes                                    = GetEnumList<JsonNodeType>(new IntPtr(p + 0x040)); // 0x40 Scopes                      ( ModelEnumListType JsonNodeType[] JsonNodeType[] List<JsonNodeType> Pointer )
            value.ServerTypeValue                           = GetString(new IntPtr(p + 0x048)); // 0x48 ServerTypeValue             ( ModelPrimitiveType string string string String )
            value.WriteState                                = (WriteState)GetInt32(new IntPtr(p + 0x050)); // 0x50 WriteState                  ( ModelEnumType WriteState WriteState WriteState Int32 )
            value.WroteServerTypeAttribute                  = GetBool(new IntPtr(p + 0x054)); // 0x54 WroteServerTypeAttribute    ( ModelPrimitiveType bool bool bool Bool )
            value.Indent                                    = GetBool(new IntPtr(p + 0x055)); // 0x55 Indent                      ( ModelPrimitiveType bool bool bool Bool )
            value.IndentChars                               = GetString(new IntPtr(p + 0x058)); // 0x58 IndentChars                 ( ModelPrimitiveType string string string String )
            value.IndentLevel                               = GetInt32(new IntPtr(p + 0x060)); // 0x60 IndentLevel                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

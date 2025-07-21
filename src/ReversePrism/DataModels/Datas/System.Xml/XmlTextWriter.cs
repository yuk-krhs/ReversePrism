using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 TextWriter                               ModelClassType TextWriter TextWriter TextWriter Pointer
    // 020 XmlEncoder                               ModelClassType XmlTextEncoder XmlTextEncoder XmlTextEncoder Pointer
    // 028 Encoding                                 ModelClassType Encoding Encoding Encoding Pointer
    // 030 Formatting                               ModelEnumType Formatting Formatting Formatting Int32
    // 034 Indented                                 ModelPrimitiveType bool bool bool Bool
    // 038 Indentation                              ModelPrimitiveType int int int Int32
    // 03C indentChar                               char IL2CPP_TYPE_CHAR
    // 040 Stack                                    ModelEnumListType TagInfo[] TagInfo[] List<TagInfo> Pointer
    // 048 Top                                      ModelPrimitiveType int int int Int32
    // 050 StateTable                               ModelEnumListType State[] State[] List<State> Pointer
    // 058 CurrentState                             ModelEnumType State State State Int32
    // 05C LastToken                                ModelEnumType Token Token Token Int32
    // 060 Base64Encoder                            ModelClassType XmlTextWriterBase64Encoder XmlTextWriterBase64Encoder XmlTextWriterBase64Encoder Pointer
    // 068 quoteChar                                char IL2CPP_TYPE_CHAR
    // 06A curQuoteChar                             char IL2CPP_TYPE_CHAR
    // 06C Namespaces                               ModelPrimitiveType bool bool bool Bool
    // 070 SpecialAttr                              ModelEnumType SpecialAttr SpecialAttr SpecialAttr Int32
    // 078 PrefixForXmlNs                           ModelPrimitiveType string string string String
    // 080 Flush                                    ModelPrimitiveType bool bool bool Bool
    // 088 NsStack                                  ModelEnumListType Namespace[] Namespace[] List<Namespace> Pointer
    // 090 NsTop                                    ModelPrimitiveType int int int Int32
    // 098 nsHashtable                              Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 0A0 UseNsHashtable                           ModelPrimitiveType bool bool bool Bool
    // 0A8 XmlCharType                              ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 000 stateName                                string[] IL2CPP_TYPE_SZARRAY
    // 008 tokenName                                string[] IL2CPP_TYPE_SZARRAY
    // 010 StateTableDefault                        ModelEnumListType State[] State[] List<State> Pointer
    // 018 StateTableDocument                       ModelEnumListType State[] State[] List<State> Pointer
    public partial class XmlTextWriter : DataModel
    {
        public TextWriter?                              TextWriter                              { get; set; }
        public XmlTextEncoder?                          XmlEncoder                              { get; set; }
        public Encoding?                                Encoding                                { get; set; }
        public Formatting                               Formatting                              { get; set; }
        public bool                                     Indented                                { get; set; }
        public int                                      Indentation                             { get; set; }
        public List<TagInfo>?                           Stack                                   { get; set; }
        public int                                      Top                                     { get; set; }
        public List<State>?                             StateTable                              { get; set; }
        public State                                    CurrentState                            { get; set; }
        public Token                                    LastToken                               { get; set; }
        public XmlTextWriterBase64Encoder?              Base64Encoder                           { get; set; }
        public bool                                     Namespaces                              { get; set; }
        public SpecialAttr                              SpecialAttr                             { get; set; }
        public string                                   PrefixForXmlNs                          { get; set; }
        public bool                                     Flush                                   { get; set; }
        public List<Namespace>?                         NsStack                                 { get; set; }
        public int                                      NsTop                                   { get; set; }
        public bool                                     UseNsHashtable                          { get; set; }
        public XmlCharType                              XmlCharType                             { get; set; }
        public List<State>?                             StateTableDefault                       { get; set; }
        public List<State>?                             StateTableDocument                      { get; set; }

        public static XmlTextWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTextWriter() { Pointer= p0 };

            value.TextWriter                                = GetObject<TextWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextWriter.FromPointer); // 0x18 TextWriter                  ( ModelClassType TextWriter TextWriter TextWriter Pointer )
            value.XmlEncoder                                = GetObject<XmlTextEncoder>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlTextEncoder.FromPointer); // 0x20 XmlEncoder                  ( ModelClassType XmlTextEncoder XmlTextEncoder XmlTextEncoder Pointer )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x028), ReversePrism.DataModels.Encoding.FromPointer); // 0x28 Encoding                    ( ModelClassType Encoding Encoding Encoding Pointer )
            value.Formatting                                = (Formatting)GetInt32(new IntPtr(p + 0x030)); // 0x30 Formatting                  ( ModelEnumType Formatting Formatting Formatting Int32 )
            value.Indented                                  = GetBool(new IntPtr(p + 0x034)); // 0x34 Indented                    ( ModelPrimitiveType bool bool bool Bool )
            value.Indentation                               = GetInt32(new IntPtr(p + 0x038)); // 0x38 Indentation                 ( ModelPrimitiveType int int int Int32 )
            value.Stack                                     = GetEnumList<TagInfo>(new IntPtr(p + 0x040)); // 0x40 Stack                       ( ModelEnumListType TagInfo[] TagInfo[] List<TagInfo> Pointer )
            value.Top                                       = GetInt32(new IntPtr(p + 0x048)); // 0x48 Top                         ( ModelPrimitiveType int int int Int32 )
            value.StateTable                                = GetEnumList<State>(new IntPtr(p + 0x050)); // 0x50 StateTable                  ( ModelEnumListType State[] State[] List<State> Pointer )
            value.CurrentState                              = (State)GetInt32(new IntPtr(p + 0x058)); // 0x58 CurrentState                ( ModelEnumType State State State Int32 )
            value.LastToken                                 = (Token)GetInt32(new IntPtr(p + 0x05C)); // 0x5C LastToken                   ( ModelEnumType Token Token Token Int32 )
            value.Base64Encoder                             = GetObject<XmlTextWriterBase64Encoder>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlTextWriterBase64Encoder.FromPointer); // 0x60 Base64Encoder               ( ModelClassType XmlTextWriterBase64Encoder XmlTextWriterBase64Encoder XmlTextWriterBase64Encoder Pointer )
            value.Namespaces                                = GetBool(new IntPtr(p + 0x06C)); // 0x6C Namespaces                  ( ModelPrimitiveType bool bool bool Bool )
            value.SpecialAttr                               = (SpecialAttr)GetInt32(new IntPtr(p + 0x070)); // 0x70 SpecialAttr                 ( ModelEnumType SpecialAttr SpecialAttr SpecialAttr Int32 )
            value.PrefixForXmlNs                            = GetString(new IntPtr(p + 0x078)); // 0x78 PrefixForXmlNs              ( ModelPrimitiveType string string string String )
            value.Flush                                     = GetBool(new IntPtr(p + 0x080)); // 0x80 Flush                       ( ModelPrimitiveType bool bool bool Bool )
            value.NsStack                                   = GetEnumList<Namespace>(new IntPtr(p + 0x088)); // 0x88 NsStack                     ( ModelEnumListType Namespace[] Namespace[] List<Namespace> Pointer )
            value.NsTop                                     = GetInt32(new IntPtr(p + 0x090)); // 0x90 NsTop                       ( ModelPrimitiveType int int int Int32 )
            value.UseNsHashtable                            = GetBool(new IntPtr(p + 0x0A0)); // 0xA0 UseNsHashtable              ( ModelPrimitiveType bool bool bool Bool )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 XmlCharType                 ( ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.StateTableDefault                         = GetEnumList<State>(new IntPtr(p + 0x010)); // 0x10 StateTableDefault           ( ModelEnumListType State[] State[] List<State> Pointer )
            value.StateTableDocument                        = GetEnumList<State>(new IntPtr(p + 0x018)); // 0x18 StateTableDocument          ( ModelEnumListType State[] State[] List<State> Pointer )

            return value;
        }
    }
}

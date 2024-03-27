using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 TextWriter                               00018664BAC0 ModelClassType TextWriter TextWriter TextWriter Pointer
    // 020 XmlEncoder                               0001865CCD50 ModelClassType XmlTextEncoder XmlTextEncoder XmlTextEncoder Pointer
    // 028 Encoding                                 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 030 Formatting                               0001865B9E30 ModelEnumType Formatting Formatting Formatting Int32
    // 034 Indented                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 Indentation                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C indentChar                               char IL2CPP_TYPE_CHAR
    // 040 Stack                                    000185CC8A68 ModelEnumListType TagInfo[] TagInfo[] List<TagInfo> Pointer
    // 048 Top                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 StateTable                               000185CC87B8 ModelEnumListType State[] State[] List<State> Pointer
    // 058 CurrentState                             0001867478B0 ModelEnumType State State State Int32
    // 05C LastToken                                000186748140 ModelEnumType Token Token Token Int32
    // 060 Base64Encoder                            0001865CDC00 ModelClassType XmlTextWriterBase64Encoder XmlTextWriterBase64Encoder XmlTextWriterBase64Encoder Pointer
    // 068 quoteChar                                char IL2CPP_TYPE_CHAR
    // 06A curQuoteChar                             char IL2CPP_TYPE_CHAR
    // 06C Namespaces                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 SpecialAttr                              0001867472D0 ModelEnumType SpecialAttr SpecialAttr SpecialAttr Int32
    // 078 PrefixForXmlNs                           000186671910 ModelPrimitiveType string string string String
    // 080 Flush                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 NsStack                                  000185CC8588 ModelEnumListType Namespace[] Namespace[] List<Namespace> Pointer
    // 090 NsTop                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 098 nsHashtable                              Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 0A0 UseNsHashtable                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 XmlCharType                              00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 000 stateName                                string[] IL2CPP_TYPE_SZARRAY
    // 008 tokenName                                string[] IL2CPP_TYPE_SZARRAY
    // 010 StateTableDefault                        000185CC8848 ModelEnumListType State[] State[] List<State> Pointer
    // 018 StateTableDocument                       000185CC8848 ModelEnumListType State[] State[] List<State> Pointer
    public partial class XmlTextWriter
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
            var value   = new XmlTextWriter();

            value.TextWriter                                = GetObject<TextWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextWriter.FromPointer); // 0270D73BEBA0 0x18 TextWriter                  ( 00018664BAC0 ModelClassType TextWriter TextWriter TextWriter Pointer )
            value.XmlEncoder                                = GetObject<XmlTextEncoder>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlTextEncoder.FromPointer); // 0270D73BEBC0 0x20 XmlEncoder                  ( 0001865CCD50 ModelClassType XmlTextEncoder XmlTextEncoder XmlTextEncoder Pointer )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x028), ReversePrism.DataModels.Encoding.FromPointer); // 0270D73BEBE0 0x28 Encoding                    ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.Formatting                                = (Formatting)GetInt32(new IntPtr(p + 0x030)); // 0270D73BEC00 0x30 Formatting                  ( 0001865B9E30 ModelEnumType Formatting Formatting Formatting Int32 )
            value.Indented                                  = GetBool(new IntPtr(p + 0x034)); // 0270D73BEC20 0x34 Indented                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Indentation                               = GetInt32(new IntPtr(p + 0x038)); // 0270D73BEC40 0x38 Indentation                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Stack                                     = GetEnumList<TagInfo>(new IntPtr(p + 0x040)); // 0270D73BEC80 0x40 Stack                       ( 000185CC8A68 ModelEnumListType TagInfo[] TagInfo[] List<TagInfo> Pointer )
            value.Top                                       = GetInt32(new IntPtr(p + 0x048)); // 0270D73BECA0 0x48 Top                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StateTable                                = GetEnumList<State>(new IntPtr(p + 0x050)); // 0270D73BECC0 0x50 StateTable                  ( 000185CC87B8 ModelEnumListType State[] State[] List<State> Pointer )
            value.CurrentState                              = (State)GetInt32(new IntPtr(p + 0x058)); // 0270D73BECE0 0x58 CurrentState                ( 0001867478B0 ModelEnumType State State State Int32 )
            value.LastToken                                 = (Token)GetInt32(new IntPtr(p + 0x05C)); // 0270D73BED00 0x5C LastToken                   ( 000186748140 ModelEnumType Token Token Token Int32 )
            value.Base64Encoder                             = GetObject<XmlTextWriterBase64Encoder>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlTextWriterBase64Encoder.FromPointer); // 0270D73BED20 0x60 Base64Encoder               ( 0001865CDC00 ModelClassType XmlTextWriterBase64Encoder XmlTextWriterBase64Encoder XmlTextWriterBase64Encoder Pointer )
            value.Namespaces                                = GetBool(new IntPtr(p + 0x06C)); // 0270D73BED80 0x6C Namespaces                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SpecialAttr                               = (SpecialAttr)GetInt32(new IntPtr(p + 0x070)); // 0270D73BEDA0 0x70 SpecialAttr                 ( 0001867472D0 ModelEnumType SpecialAttr SpecialAttr SpecialAttr Int32 )
            value.PrefixForXmlNs                            = GetString(new IntPtr(p + 0x078)); // 0270D73BEDC0 0x78 PrefixForXmlNs              ( 000186671910 ModelPrimitiveType string string string String )
            value.Flush                                     = GetBool(new IntPtr(p + 0x080)); // 0270D73BEDE0 0x80 Flush                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NsStack                                   = GetEnumList<Namespace>(new IntPtr(p + 0x088)); // 0270D73BEE00 0x88 NsStack                     ( 000185CC8588 ModelEnumListType Namespace[] Namespace[] List<Namespace> Pointer )
            value.NsTop                                     = GetInt32(new IntPtr(p + 0x090)); // 0270D73BEE20 0x90 NsTop                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UseNsHashtable                            = GetBool(new IntPtr(p + 0x0A0)); // 0270D73BEE60 0xA0 UseNsHashtable              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x0A8)); // 0270D73BEE80 0xA8 XmlCharType                 ( 00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.StateTableDefault                         = GetEnumList<State>(new IntPtr(p + 0x010)); // 0270D73BEEE0 0x10 StateTableDefault           ( 000185CC8848 ModelEnumListType State[] State[] List<State> Pointer )
            value.StateTableDocument                        = GetEnumList<State>(new IntPtr(p + 0x018)); // 0270D73BEF00 0x18 StateTableDocument          ( 000185CC8848 ModelEnumListType State[] State[] List<State> Pointer )

            return value;
        }
    }
}

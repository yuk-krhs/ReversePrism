using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAsync                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Encoding                                 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 020 OmitXmlDecl                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 024 NewLineHandling                          00018669F5C0 ModelEnumType NewLineHandling NewLineHandling NewLineHandling Int32
    // 028 NewLineChars                             000186671910 ModelPrimitiveType string string string String
    // 030 Indent                                   0001866B28F0 ModelEnumType TriState TriState TriState Int32
    // 038 IndentChars                              000186671910 ModelPrimitiveType string string string String
    // 040 NewLineOnAttributes                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 CloseOutput                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 NamespaceHandling                        00018667D970 ModelEnumType NamespaceHandling NamespaceHandling NamespaceHandling Int32
    // 048 ConformanceLevel                         000186600120 ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32
    // 04C CheckCharacters                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04D WriteEndDocumentOnClose                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 OutputMethod                             0001865A76D0 ModelEnumType XmlOutputMethod XmlOutputMethod XmlOutputMethod Int32
    // 058 CdataSections                            000185D1DC48 ModelClassListType List`1<XmlQualifiedName> List`1<XmlQualifiedName> List<XmlQualifiedName> Pointer
    // 060 DoNotEscapeUriAttributes                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 061 MergeCDataSections                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 MediaType                                000186671910 ModelPrimitiveType string string string String
    // 070 DocTypeSystem                            000186671910 ModelPrimitiveType string string string String
    // 078 DocTypePublic                            000186671910 ModelPrimitiveType string string string String
    // 080 Standalone                               0001865CB0D0 ModelEnumType XmlStandalone XmlStandalone XmlStandalone Int32
    // 084 AutoXmlDecl                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 085 IsReadOnly                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XmlWriterSettings
    {
        public bool                                     UseAsync                                { get; set; }
        public Encoding?                                Encoding                                { get; set; }
        public bool                                     OmitXmlDecl                             { get; set; }
        public NewLineHandling                          NewLineHandling                         { get; set; }
        public string                                   NewLineChars                            { get; set; }
        public TriState                                 Indent                                  { get; set; }
        public string                                   IndentChars                             { get; set; }
        public bool                                     NewLineOnAttributes                     { get; set; }
        public bool                                     CloseOutput                             { get; set; }
        public NamespaceHandling                        NamespaceHandling                       { get; set; }
        public ConformanceLevel                         ConformanceLevel                        { get; set; }
        public bool                                     CheckCharacters                         { get; set; }
        public bool                                     WriteEndDocumentOnClose                 { get; set; }
        public XmlOutputMethod                          OutputMethod                            { get; set; }
        public List<XmlQualifiedName>?                  CdataSections                           { get; set; }
        public bool                                     DoNotEscapeUriAttributes                { get; set; }
        public bool                                     MergeCDataSections                      { get; set; }
        public string                                   MediaType                               { get; set; }
        public string                                   DocTypeSystem                           { get; set; }
        public string                                   DocTypePublic                           { get; set; }
        public XmlStandalone                            Standalone                              { get; set; }
        public bool                                     AutoXmlDecl                             { get; set; }
        public bool                                     IsReadOnly                              { get; set; }

        public static XmlWriterSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlWriterSettings();

            value.UseAsync                                  = GetBool(new IntPtr(p + 0x010)); // 0270D736B4A0 0x10 UseAsync                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x018), ReversePrism.DataModels.Encoding.FromPointer); // 0270D736B4C0 0x18 Encoding                    ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.OmitXmlDecl                               = GetBool(new IntPtr(p + 0x020)); // 0270D736B4E0 0x20 OmitXmlDecl                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NewLineHandling                           = (NewLineHandling)GetInt32(new IntPtr(p + 0x024)); // 0270D736B500 0x24 NewLineHandling             ( 00018669F5C0 ModelEnumType NewLineHandling NewLineHandling NewLineHandling Int32 )
            value.NewLineChars                              = GetString(new IntPtr(p + 0x028)); // 0270D736B520 0x28 NewLineChars                ( 000186671910 ModelPrimitiveType string string string String )
            value.Indent                                    = (TriState)GetInt32(new IntPtr(p + 0x030)); // 0270D736B540 0x30 Indent                      ( 0001866B28F0 ModelEnumType TriState TriState TriState Int32 )
            value.IndentChars                               = GetString(new IntPtr(p + 0x038)); // 0270D736B560 0x38 IndentChars                 ( 000186671910 ModelPrimitiveType string string string String )
            value.NewLineOnAttributes                       = GetBool(new IntPtr(p + 0x040)); // 0270D736B580 0x40 NewLineOnAttributes         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CloseOutput                               = GetBool(new IntPtr(p + 0x041)); // 0270D736B5A0 0x41 CloseOutput                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NamespaceHandling                         = (NamespaceHandling)GetInt32(new IntPtr(p + 0x044)); // 0270D736B5C0 0x44 NamespaceHandling           ( 00018667D970 ModelEnumType NamespaceHandling NamespaceHandling NamespaceHandling Int32 )
            value.ConformanceLevel                          = (ConformanceLevel)GetInt32(new IntPtr(p + 0x048)); // 0270D736B5E0 0x48 ConformanceLevel            ( 000186600120 ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32 )
            value.CheckCharacters                           = GetBool(new IntPtr(p + 0x04C)); // 0270D736B600 0x4C CheckCharacters             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WriteEndDocumentOnClose                   = GetBool(new IntPtr(p + 0x04D)); // 0270D736B620 0x4D WriteEndDocumentOnClose     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OutputMethod                              = (XmlOutputMethod)GetInt32(new IntPtr(p + 0x050)); // 0270D736B640 0x50 OutputMethod                ( 0001865A76D0 ModelEnumType XmlOutputMethod XmlOutputMethod XmlOutputMethod Int32 )
            value.CdataSections                             = GetObjectList<XmlQualifiedName>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D736B660 0x58 CdataSections               ( 000185D1DC48 ModelClassListType List`1<XmlQualifiedName> List`1<XmlQualifiedName> List<XmlQualifiedName> Pointer )
            value.DoNotEscapeUriAttributes                  = GetBool(new IntPtr(p + 0x060)); // 0270D736B680 0x60 DoNotEscapeUriAttributes    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MergeCDataSections                        = GetBool(new IntPtr(p + 0x061)); // 0270D736B6A0 0x61 MergeCDataSections          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MediaType                                 = GetString(new IntPtr(p + 0x068)); // 0270D736B6C0 0x68 MediaType                   ( 000186671910 ModelPrimitiveType string string string String )
            value.DocTypeSystem                             = GetString(new IntPtr(p + 0x070)); // 0270D736B6E0 0x70 DocTypeSystem               ( 000186671910 ModelPrimitiveType string string string String )
            value.DocTypePublic                             = GetString(new IntPtr(p + 0x078)); // 0270D736B700 0x78 DocTypePublic               ( 000186671910 ModelPrimitiveType string string string String )
            value.Standalone                                = (XmlStandalone)GetInt32(new IntPtr(p + 0x080)); // 0270D736B720 0x80 Standalone                  ( 0001865CB0D0 ModelEnumType XmlStandalone XmlStandalone XmlStandalone Int32 )
            value.AutoXmlDecl                               = GetBool(new IntPtr(p + 0x084)); // 0270D736B740 0x84 AutoXmlDecl                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsReadOnly                                = GetBool(new IntPtr(p + 0x085)); // 0270D736B760 0x85 IsReadOnly                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

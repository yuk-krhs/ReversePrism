using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAsync                                 ModelPrimitiveType bool bool bool Bool
    // 018 Encoding                                 ModelClassType Encoding Encoding Encoding Pointer
    // 020 OmitXmlDecl                              ModelPrimitiveType bool bool bool Bool
    // 024 NewLineHandling                          ModelEnumType NewLineHandling NewLineHandling NewLineHandling Int32
    // 028 NewLineChars                             ModelPrimitiveType string string string String
    // 030 Indent                                   ModelEnumType TriState TriState TriState Int32
    // 038 IndentChars                              ModelPrimitiveType string string string String
    // 040 NewLineOnAttributes                      ModelPrimitiveType bool bool bool Bool
    // 041 CloseOutput                              ModelPrimitiveType bool bool bool Bool
    // 044 NamespaceHandling                        ModelEnumType NamespaceHandling NamespaceHandling NamespaceHandling Int32
    // 048 ConformanceLevel                         ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32
    // 04C CheckCharacters                          ModelPrimitiveType bool bool bool Bool
    // 04D WriteEndDocumentOnClose                  ModelPrimitiveType bool bool bool Bool
    // 050 OutputMethod                             ModelEnumType XmlOutputMethod XmlOutputMethod XmlOutputMethod Int32
    // 058 CdataSections                            ModelClassListType List`1<XmlQualifiedName> List`1<XmlQualifiedName> List<XmlQualifiedName> Pointer
    // 060 DoNotEscapeUriAttributes                 ModelPrimitiveType bool bool bool Bool
    // 061 MergeCDataSections                       ModelPrimitiveType bool bool bool Bool
    // 068 MediaType                                ModelPrimitiveType string string string String
    // 070 DocTypeSystem                            ModelPrimitiveType string string string String
    // 078 DocTypePublic                            ModelPrimitiveType string string string String
    // 080 Standalone                               ModelEnumType XmlStandalone XmlStandalone XmlStandalone Int32
    // 084 AutoXmlDecl                              ModelPrimitiveType bool bool bool Bool
    // 085 IsReadOnly                               ModelPrimitiveType bool bool bool Bool
    public partial class XmlWriterSettings : DataModel
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
            var value   = new XmlWriterSettings() { Pointer= p0 };

            value.UseAsync                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 UseAsync                    ( ModelPrimitiveType bool bool bool Bool )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x018), ReversePrism.DataModels.Encoding.FromPointer); // 0x18 Encoding                    ( ModelClassType Encoding Encoding Encoding Pointer )
            value.OmitXmlDecl                               = GetBool(new IntPtr(p + 0x020)); // 0x20 OmitXmlDecl                 ( ModelPrimitiveType bool bool bool Bool )
            value.NewLineHandling                           = (NewLineHandling)GetInt32(new IntPtr(p + 0x024)); // 0x24 NewLineHandling             ( ModelEnumType NewLineHandling NewLineHandling NewLineHandling Int32 )
            value.NewLineChars                              = GetString(new IntPtr(p + 0x028)); // 0x28 NewLineChars                ( ModelPrimitiveType string string string String )
            value.Indent                                    = (TriState)GetInt32(new IntPtr(p + 0x030)); // 0x30 Indent                      ( ModelEnumType TriState TriState TriState Int32 )
            value.IndentChars                               = GetString(new IntPtr(p + 0x038)); // 0x38 IndentChars                 ( ModelPrimitiveType string string string String )
            value.NewLineOnAttributes                       = GetBool(new IntPtr(p + 0x040)); // 0x40 NewLineOnAttributes         ( ModelPrimitiveType bool bool bool Bool )
            value.CloseOutput                               = GetBool(new IntPtr(p + 0x041)); // 0x41 CloseOutput                 ( ModelPrimitiveType bool bool bool Bool )
            value.NamespaceHandling                         = (NamespaceHandling)GetInt32(new IntPtr(p + 0x044)); // 0x44 NamespaceHandling           ( ModelEnumType NamespaceHandling NamespaceHandling NamespaceHandling Int32 )
            value.ConformanceLevel                          = (ConformanceLevel)GetInt32(new IntPtr(p + 0x048)); // 0x48 ConformanceLevel            ( ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32 )
            value.CheckCharacters                           = GetBool(new IntPtr(p + 0x04C)); // 0x4C CheckCharacters             ( ModelPrimitiveType bool bool bool Bool )
            value.WriteEndDocumentOnClose                   = GetBool(new IntPtr(p + 0x04D)); // 0x4D WriteEndDocumentOnClose     ( ModelPrimitiveType bool bool bool Bool )
            value.OutputMethod                              = (XmlOutputMethod)GetInt32(new IntPtr(p + 0x050)); // 0x50 OutputMethod                ( ModelEnumType XmlOutputMethod XmlOutputMethod XmlOutputMethod Int32 )
            value.CdataSections                             = GetObjectList<XmlQualifiedName>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x58 CdataSections               ( ModelClassListType List`1<XmlQualifiedName> List`1<XmlQualifiedName> List<XmlQualifiedName> Pointer )
            value.DoNotEscapeUriAttributes                  = GetBool(new IntPtr(p + 0x060)); // 0x60 DoNotEscapeUriAttributes    ( ModelPrimitiveType bool bool bool Bool )
            value.MergeCDataSections                        = GetBool(new IntPtr(p + 0x061)); // 0x61 MergeCDataSections          ( ModelPrimitiveType bool bool bool Bool )
            value.MediaType                                 = GetString(new IntPtr(p + 0x068)); // 0x68 MediaType                   ( ModelPrimitiveType string string string String )
            value.DocTypeSystem                             = GetString(new IntPtr(p + 0x070)); // 0x70 DocTypeSystem               ( ModelPrimitiveType string string string String )
            value.DocTypePublic                             = GetString(new IntPtr(p + 0x078)); // 0x78 DocTypePublic               ( ModelPrimitiveType string string string String )
            value.Standalone                                = (XmlStandalone)GetInt32(new IntPtr(p + 0x080)); // 0x80 Standalone                  ( ModelEnumType XmlStandalone XmlStandalone XmlStandalone Int32 )
            value.AutoXmlDecl                               = GetBool(new IntPtr(p + 0x084)); // 0x84 AutoXmlDecl                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsReadOnly                                = GetBool(new IntPtr(p + 0x085)); // 0x85 IsReadOnly                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 UseAsync                                 ModelPrimitiveType bool bool bool Bool
    // 030 BufBytes                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 Stream                                   ModelClassType Stream Stream Stream Pointer
    // 040 Encoding                                 ModelClassType Encoding Encoding Encoding Pointer
    // 048 XmlCharType                              ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 050 BufPos                                   ModelPrimitiveType int int int Int32
    // 054 TextPos                                  ModelPrimitiveType int int int Int32
    // 058 ContentPos                               ModelPrimitiveType int int int Int32
    // 05C CdataPos                                 ModelPrimitiveType int int int Int32
    // 060 AttrEndPos                               ModelPrimitiveType int int int Int32
    // 064 BufLen                                   ModelPrimitiveType int int int Int32
    // 068 WriteToNull                              ModelPrimitiveType bool bool bool Bool
    // 069 HadDoubleBracket                         ModelPrimitiveType bool bool bool Bool
    // 06A InAttributeValue                         ModelPrimitiveType bool bool bool Bool
    // 06C NewLineHandling                          ModelEnumType NewLineHandling NewLineHandling NewLineHandling Int32
    // 070 CloseOutput                              ModelPrimitiveType bool bool bool Bool
    // 071 OmitXmlDeclaration                       ModelPrimitiveType bool bool bool Bool
    // 078 NewLineChars                             ModelPrimitiveType string string string String
    // 080 CheckCharacters                          ModelPrimitiveType bool bool bool Bool
    // 084 Standalone                               ModelEnumType XmlStandalone XmlStandalone XmlStandalone Int32
    // 088 OutputMethod                             ModelEnumType XmlOutputMethod XmlOutputMethod XmlOutputMethod Int32
    // 08C AutoXmlDeclaration                       ModelPrimitiveType bool bool bool Bool
    // 08D MergeCDataSections                       ModelPrimitiveType bool bool bool Bool
    public partial class XmlUtf8RawTextWriter : DataModel
    {
        public bool                                     UseAsync                                { get; set; }
        public List<sbyte>?                             BufBytes                                { get; set; }
        public Stream?                                  Stream                                  { get; set; }
        public Encoding?                                Encoding                                { get; set; }
        public XmlCharType                              XmlCharType                             { get; set; }
        public int                                      BufPos                                  { get; set; }
        public int                                      TextPos                                 { get; set; }
        public int                                      ContentPos                              { get; set; }
        public int                                      CdataPos                                { get; set; }
        public int                                      AttrEndPos                              { get; set; }
        public int                                      BufLen                                  { get; set; }
        public bool                                     WriteToNull                             { get; set; }
        public bool                                     HadDoubleBracket                        { get; set; }
        public bool                                     InAttributeValue                        { get; set; }
        public NewLineHandling                          NewLineHandling                         { get; set; }
        public bool                                     CloseOutput                             { get; set; }
        public bool                                     OmitXmlDeclaration                      { get; set; }
        public string                                   NewLineChars                            { get; set; }
        public bool                                     CheckCharacters                         { get; set; }
        public XmlStandalone                            Standalone                              { get; set; }
        public XmlOutputMethod                          OutputMethod                            { get; set; }
        public bool                                     AutoXmlDeclaration                      { get; set; }
        public bool                                     MergeCDataSections                      { get; set; }

        public static XmlUtf8RawTextWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlUtf8RawTextWriter() { Pointer= p0 };

            value.UseAsync                                  = GetBool(new IntPtr(p + 0x028)); // 0x28 UseAsync                    ( ModelPrimitiveType bool bool bool Bool )
            value.BufBytes                                  = GetSByteList(new IntPtr(p + 0x030)); // 0x30 BufBytes                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x038), ReversePrism.DataModels.Stream.FromPointer); // 0x38 Stream                      ( ModelClassType Stream Stream Stream Pointer )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x040), ReversePrism.DataModels.Encoding.FromPointer); // 0x40 Encoding                    ( ModelClassType Encoding Encoding Encoding Pointer )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x048)); // 0x48 XmlCharType                 ( ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.BufPos                                    = GetInt32(new IntPtr(p + 0x050)); // 0x50 BufPos                      ( ModelPrimitiveType int int int Int32 )
            value.TextPos                                   = GetInt32(new IntPtr(p + 0x054)); // 0x54 TextPos                     ( ModelPrimitiveType int int int Int32 )
            value.ContentPos                                = GetInt32(new IntPtr(p + 0x058)); // 0x58 ContentPos                  ( ModelPrimitiveType int int int Int32 )
            value.CdataPos                                  = GetInt32(new IntPtr(p + 0x05C)); // 0x5C CdataPos                    ( ModelPrimitiveType int int int Int32 )
            value.AttrEndPos                                = GetInt32(new IntPtr(p + 0x060)); // 0x60 AttrEndPos                  ( ModelPrimitiveType int int int Int32 )
            value.BufLen                                    = GetInt32(new IntPtr(p + 0x064)); // 0x64 BufLen                      ( ModelPrimitiveType int int int Int32 )
            value.WriteToNull                               = GetBool(new IntPtr(p + 0x068)); // 0x68 WriteToNull                 ( ModelPrimitiveType bool bool bool Bool )
            value.HadDoubleBracket                          = GetBool(new IntPtr(p + 0x069)); // 0x69 HadDoubleBracket            ( ModelPrimitiveType bool bool bool Bool )
            value.InAttributeValue                          = GetBool(new IntPtr(p + 0x06A)); // 0x6A InAttributeValue            ( ModelPrimitiveType bool bool bool Bool )
            value.NewLineHandling                           = (NewLineHandling)GetInt32(new IntPtr(p + 0x06C)); // 0x6C NewLineHandling             ( ModelEnumType NewLineHandling NewLineHandling NewLineHandling Int32 )
            value.CloseOutput                               = GetBool(new IntPtr(p + 0x070)); // 0x70 CloseOutput                 ( ModelPrimitiveType bool bool bool Bool )
            value.OmitXmlDeclaration                        = GetBool(new IntPtr(p + 0x071)); // 0x71 OmitXmlDeclaration          ( ModelPrimitiveType bool bool bool Bool )
            value.NewLineChars                              = GetString(new IntPtr(p + 0x078)); // 0x78 NewLineChars                ( ModelPrimitiveType string string string String )
            value.CheckCharacters                           = GetBool(new IntPtr(p + 0x080)); // 0x80 CheckCharacters             ( ModelPrimitiveType bool bool bool Bool )
            value.Standalone                                = (XmlStandalone)GetInt32(new IntPtr(p + 0x084)); // 0x84 Standalone                  ( ModelEnumType XmlStandalone XmlStandalone XmlStandalone Int32 )
            value.OutputMethod                              = (XmlOutputMethod)GetInt32(new IntPtr(p + 0x088)); // 0x88 OutputMethod                ( ModelEnumType XmlOutputMethod XmlOutputMethod XmlOutputMethod Int32 )
            value.AutoXmlDeclaration                        = GetBool(new IntPtr(p + 0x08C)); // 0x8C AutoXmlDeclaration          ( ModelPrimitiveType bool bool bool Bool )
            value.MergeCDataSections                        = GetBool(new IntPtr(p + 0x08D)); // 0x8D MergeCDataSections          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

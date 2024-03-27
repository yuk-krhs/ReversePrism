using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 UseAsync                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 030 BufBytes                                 000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 Stream                                   000186670700 ModelClassType Stream Stream Stream Pointer
    // 040 Encoding                                 00018672DEE0 ModelClassType Encoding Encoding Encoding Pointer
    // 048 XmlCharType                              00018658F760 ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 050 BufPos                                   0001865F3220 ModelPrimitiveType int int int Int32
    // 054 TextPos                                  0001865F3220 ModelPrimitiveType int int int Int32
    // 058 ContentPos                               0001865F3220 ModelPrimitiveType int int int Int32
    // 05C CdataPos                                 0001865F3220 ModelPrimitiveType int int int Int32
    // 060 AttrEndPos                               0001865F3220 ModelPrimitiveType int int int Int32
    // 064 BufLen                                   0001865F3220 ModelPrimitiveType int int int Int32
    // 068 WriteToNull                              000186595480 ModelPrimitiveType bool bool bool Bool
    // 069 HadDoubleBracket                         000186595480 ModelPrimitiveType bool bool bool Bool
    // 06A InAttributeValue                         000186595480 ModelPrimitiveType bool bool bool Bool
    // 06C NewLineHandling                          00018669F850 ModelEnumType NewLineHandling NewLineHandling NewLineHandling Int32
    // 070 CloseOutput                              000186595480 ModelPrimitiveType bool bool bool Bool
    // 071 OmitXmlDeclaration                       000186595480 ModelPrimitiveType bool bool bool Bool
    // 078 NewLineChars                             000186671E00 ModelPrimitiveType string string string String
    // 080 CheckCharacters                          000186595480 ModelPrimitiveType bool bool bool Bool
    // 084 Standalone                               0001865CB2E0 ModelEnumType XmlStandalone XmlStandalone XmlStandalone Int32
    // 088 OutputMethod                             0001865A7940 ModelEnumType XmlOutputMethod XmlOutputMethod XmlOutputMethod Int32
    // 08C AutoXmlDeclaration                       000186595480 ModelPrimitiveType bool bool bool Bool
    // 08D MergeCDataSections                       000186595480 ModelPrimitiveType bool bool bool Bool
    public partial class XmlUtf8RawTextWriter
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
            var value   = new XmlUtf8RawTextWriter();

            value.UseAsync                                  = GetBool(new IntPtr(p + 0x028)); // 0270D736C188 0x28 UseAsync                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.BufBytes                                  = GetSByteList(new IntPtr(p + 0x030)); // 0270D736C1A8 0x30 BufBytes                    ( 000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x038), ReversePrism.DataModels.Stream.FromPointer); // 0270D736C1C8 0x38 Stream                      ( 000186670700 ModelClassType Stream Stream Stream Pointer )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x040), ReversePrism.DataModels.Encoding.FromPointer); // 0270D736C1E8 0x40 Encoding                    ( 00018672DEE0 ModelClassType Encoding Encoding Encoding Pointer )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x048)); // 0270D736C208 0x48 XmlCharType                 ( 00018658F760 ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.BufPos                                    = GetInt32(new IntPtr(p + 0x050)); // 0270D736C228 0x50 BufPos                      ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.TextPos                                   = GetInt32(new IntPtr(p + 0x054)); // 0270D736C248 0x54 TextPos                     ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.ContentPos                                = GetInt32(new IntPtr(p + 0x058)); // 0270D736C268 0x58 ContentPos                  ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.CdataPos                                  = GetInt32(new IntPtr(p + 0x05C)); // 0270D736C288 0x5C CdataPos                    ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.AttrEndPos                                = GetInt32(new IntPtr(p + 0x060)); // 0270D736C2A8 0x60 AttrEndPos                  ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.BufLen                                    = GetInt32(new IntPtr(p + 0x064)); // 0270D736C2C8 0x64 BufLen                      ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.WriteToNull                               = GetBool(new IntPtr(p + 0x068)); // 0270D736C2E8 0x68 WriteToNull                 ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.HadDoubleBracket                          = GetBool(new IntPtr(p + 0x069)); // 0270D736C308 0x69 HadDoubleBracket            ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.InAttributeValue                          = GetBool(new IntPtr(p + 0x06A)); // 0270D736C328 0x6A InAttributeValue            ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.NewLineHandling                           = (NewLineHandling)GetInt32(new IntPtr(p + 0x06C)); // 0270D736C348 0x6C NewLineHandling             ( 00018669F850 ModelEnumType NewLineHandling NewLineHandling NewLineHandling Int32 )
            value.CloseOutput                               = GetBool(new IntPtr(p + 0x070)); // 0270D736C368 0x70 CloseOutput                 ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.OmitXmlDeclaration                        = GetBool(new IntPtr(p + 0x071)); // 0270D736C388 0x71 OmitXmlDeclaration          ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.NewLineChars                              = GetString(new IntPtr(p + 0x078)); // 0270D736C3A8 0x78 NewLineChars                ( 000186671E00 ModelPrimitiveType string string string String )
            value.CheckCharacters                           = GetBool(new IntPtr(p + 0x080)); // 0270D736C3C8 0x80 CheckCharacters             ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.Standalone                                = (XmlStandalone)GetInt32(new IntPtr(p + 0x084)); // 0270D736C3E8 0x84 Standalone                  ( 0001865CB2E0 ModelEnumType XmlStandalone XmlStandalone XmlStandalone Int32 )
            value.OutputMethod                              = (XmlOutputMethod)GetInt32(new IntPtr(p + 0x088)); // 0270D736C408 0x88 OutputMethod                ( 0001865A7940 ModelEnumType XmlOutputMethod XmlOutputMethod XmlOutputMethod Int32 )
            value.AutoXmlDeclaration                        = GetBool(new IntPtr(p + 0x08C)); // 0270D736C428 0x8C AutoXmlDeclaration          ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.MergeCDataSections                        = GetBool(new IntPtr(p + 0x08D)); // 0270D736C448 0x8D MergeCDataSections          ( 000186595480 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

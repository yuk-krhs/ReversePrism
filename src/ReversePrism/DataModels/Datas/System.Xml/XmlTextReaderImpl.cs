using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAsync                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 018 LaterInitParam                           000186744520 ModelClassType LaterInitParam LaterInitParam LaterInitParam Pointer
    // 020 XmlCharType                              00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 028 Ps                                       000186745E50 ModelEnumType ParsingState ParsingState ParsingState Int32
    // 0A0 ParsingFunction                          0001867450F0 ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32
    // 0A4 NextParsingFunction                      0001867450F0 ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32
    // 0A8 NextNextParsingFunction                  0001867450F0 ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32
    // 0B0 Nodes                                    000185CC8288 ModelClassListType NodeData[] NodeData[] List<NodeData> Pointer
    // 0B8 CurNode                                  000186721FA0 ModelClassType NodeData NodeData NodeData Pointer
    // 0C0 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0C4 CurAttrIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0C8 AttrCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0CC AttrHashtable                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0D0 AttrDuplWalkCount                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0D4 AttrNeedNamespaceLookup                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D5 FullAttrCleanup                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D8 AttrDuplSortingArray                     000185CC8288 ModelClassListType NodeData[] NodeData[] List<NodeData> Pointer
    // 0E0 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 0E8 NameTableFromSettings                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0F0 XmlResolver                              0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 0F8 Url                                      000186671910 ModelPrimitiveType string string string String
    // 100 Normalize                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 101 SupportNamespaces                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 104 WhitespaceHandling                       000186559210 ModelEnumType WhitespaceHandling WhitespaceHandling WhitespaceHandling Int32
    // 108 DtdProcessing                            000186708FB0 ModelEnumType DtdProcessing DtdProcessing DtdProcessing Int32
    // 10C EntityHandling                           000186737C00 ModelEnumType EntityHandling EntityHandling EntityHandling Int32
    // 110 IgnorePIs                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 111 IgnoreComments                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 112 CheckCharacters                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 114 LineNumberOffset                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 118 LinePositionOffset                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 11C CloseInput                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 120 MaxCharactersInDocument                  0001865F7700 ModelPrimitiveType long long long Int64
    // 128 MaxCharactersFromEntities                0001865F7700 ModelPrimitiveType long long long Int64
    // 130 V1Compat                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 138 NamespaceManager                         0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 140 LastPrefix                               000186671910 ModelPrimitiveType string string string String
    // 148 XmlContext                               000186746310 ModelClassType XmlContext XmlContext XmlContext Pointer
    // 150 ParsingStatesStack                       000185CC8348 ModelEnumListType ParsingState[] ParsingState[] List<ParsingState> Pointer
    // 158 ParsingStatesStackTop                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 160 ReportedBaseUri                          000186671910 ModelPrimitiveType string string string String
    // 168 ReportedEncoding                         00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 170 DtdInfo                                  00018675AD20 ModelClassType IDtdInfo IDtdInfo IDtdInfo Pointer
    // 178 FragmentType                             0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 180 FragmentParserContext                    0001865A80B0 ModelClassType XmlParserContext XmlParserContext XmlParserContext Pointer
    // 188 Fragment                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 190 IncReadDecoder                           0001866DF210 ModelClassType IncrementalReadDecoder IncrementalReadDecoder IncrementalReadDecoder Pointer
    // 198 IncReadState                             0001867436F0 ModelEnumType IncrementalReadState IncrementalReadState IncrementalReadState Int32
    // 19C IncReadLineInfo                          000186607510 ModelEnumType LineInfo LineInfo LineInfo Int32
    // 1A8 BinHexDecoder                            000186752F30 ModelClassType BinHexDecoder BinHexDecoder BinHexDecoder Pointer
    // 1B0 Base64Decoder                            00018673B9B0 ModelClassType Base64Decoder Base64Decoder Base64Decoder Pointer
    // 1B8 IncReadDepth                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 1BC IncReadLeftStartPos                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 1C0 IncReadLeftEndPos                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 1C4 AttributeValueBaseEntityId               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 1C8 EmptyEntityInAttributeResolved           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1D0 ValidationEventHandling                  000186691150 ModelClassType IValidationEventHandling IValidationEventHandling IValidationEventHandling Pointer
    // 1D8 OnDefaultAttributeUse                    000186744C40 ModelClassType OnDefaultAttributeUseDelegate OnDefaultAttributeUseDelegate OnDefaultAttributeUseDelegate Pointer
    // 1E0 ValidatingReaderCompatFlag               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1E1 AddDefaultAttributesAndNormalize         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1E8 StringBuilder                            000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 1F0 RootElementParsed                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1F1 Standalone                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1F4 NextEntityId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 1F8 ParsingMode                              000186745880 ModelEnumType ParsingMode ParsingMode ParsingMode Int32
    // 1FC ReadState                                00018661DEC0 ModelEnumType ReadState ReadState ReadState Int32
    // 200 LastEntity                               0001865E2120 ModelClassType IDtdEntityInfo IDtdEntityInfo IDtdEntityInfo Pointer
    // 208 AfterResetState                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 20C DocumentStartBytePos                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 210 ReadValueOffset                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 218 CharactersInDocument                     0001865F7700 ModelPrimitiveType long long long Int64
    // 220 CharactersFromEntities                   0001865F7700 ModelPrimitiveType long long long Int64
    // 228 currentEntities                          Dictionary`2<IDtdEntityInfo, IDtdEntityInfo> IL2CPP_TYPE_GENERICINST
    // 230 DisableUndeclaredEntityCheck             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 238 OuterReader                              0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 240 XmlResolverIsSet                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 248 Xml                                      000186671910 ModelPrimitiveType string string string String
    // 250 XmlNs                                    000186671910 ModelPrimitiveType string string string String
    // 258 parseText_dummyTask                      Task`1<Tuple`4<int, int, int, bool>> IL2CPP_TYPE_GENERICINST
    public partial class XmlTextReaderImpl
    {
        public bool                                     UseAsync                                { get; set; }
        public LaterInitParam?                          LaterInitParam                          { get; set; }
        public XmlCharType                              XmlCharType                             { get; set; }
        public ParsingState                             Ps                                      { get; set; }
        public ParsingFunction                          ParsingFunction                         { get; set; }
        public ParsingFunction                          NextParsingFunction                     { get; set; }
        public ParsingFunction                          NextNextParsingFunction                 { get; set; }
        public List<NodeData>?                          Nodes                                   { get; set; }
        public NodeData?                                CurNode                                 { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      CurAttrIndex                            { get; set; }
        public int                                      AttrCount                               { get; set; }
        public int                                      AttrHashtable                           { get; set; }
        public int                                      AttrDuplWalkCount                       { get; set; }
        public bool                                     AttrNeedNamespaceLookup                 { get; set; }
        public bool                                     FullAttrCleanup                         { get; set; }
        public List<NodeData>?                          AttrDuplSortingArray                    { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }
        public bool                                     NameTableFromSettings                   { get; set; }
        public XmlResolver?                             XmlResolver                             { get; set; }
        public string                                   Url                                     { get; set; }
        public bool                                     Normalize                               { get; set; }
        public bool                                     SupportNamespaces                       { get; set; }
        public WhitespaceHandling                       WhitespaceHandling                      { get; set; }
        public DtdProcessing                            DtdProcessing                           { get; set; }
        public EntityHandling                           EntityHandling                          { get; set; }
        public bool                                     IgnorePIs                               { get; set; }
        public bool                                     IgnoreComments                          { get; set; }
        public bool                                     CheckCharacters                         { get; set; }
        public int                                      LineNumberOffset                        { get; set; }
        public int                                      LinePositionOffset                      { get; set; }
        public bool                                     CloseInput                              { get; set; }
        public long                                     MaxCharactersInDocument                 { get; set; }
        public long                                     MaxCharactersFromEntities               { get; set; }
        public bool                                     V1Compat                                { get; set; }
        public XmlNamespaceManager?                     NamespaceManager                        { get; set; }
        public string                                   LastPrefix                              { get; set; }
        public XmlContext?                              XmlContext                              { get; set; }
        public List<ParsingState>?                      ParsingStatesStack                      { get; set; }
        public int                                      ParsingStatesStackTop                   { get; set; }
        public string                                   ReportedBaseUri                         { get; set; }
        public Encoding?                                ReportedEncoding                        { get; set; }
        public IDtdInfo?                                DtdInfo                                 { get; set; }
        public XmlNodeType                              FragmentType                            { get; set; }
        public XmlParserContext?                        FragmentParserContext                   { get; set; }
        public bool                                     Fragment                                { get; set; }
        public IncrementalReadDecoder?                  IncReadDecoder                          { get; set; }
        public IncrementalReadState                     IncReadState                            { get; set; }
        public LineInfo                                 IncReadLineInfo                         { get; set; }
        public BinHexDecoder?                           BinHexDecoder                           { get; set; }
        public Base64Decoder?                           Base64Decoder                           { get; set; }
        public int                                      IncReadDepth                            { get; set; }
        public int                                      IncReadLeftStartPos                     { get; set; }
        public int                                      IncReadLeftEndPos                       { get; set; }
        public int                                      AttributeValueBaseEntityId              { get; set; }
        public bool                                     EmptyEntityInAttributeResolved          { get; set; }
        public IValidationEventHandling?                ValidationEventHandling                 { get; set; }
        public OnDefaultAttributeUseDelegate?           OnDefaultAttributeUse                   { get; set; }
        public bool                                     ValidatingReaderCompatFlag              { get; set; }
        public bool                                     AddDefaultAttributesAndNormalize        { get; set; }
        public StringBuilder?                           StringBuilder                           { get; set; }
        public bool                                     RootElementParsed                       { get; set; }
        public bool                                     Standalone                              { get; set; }
        public int                                      NextEntityId                            { get; set; }
        public ParsingMode                              ParsingMode                             { get; set; }
        public ReadState                                ReadState                               { get; set; }
        public IDtdEntityInfo?                          LastEntity                              { get; set; }
        public bool                                     AfterResetState                         { get; set; }
        public int                                      DocumentStartBytePos                    { get; set; }
        public int                                      ReadValueOffset                         { get; set; }
        public long                                     CharactersInDocument                    { get; set; }
        public long                                     CharactersFromEntities                  { get; set; }
        public bool                                     DisableUndeclaredEntityCheck            { get; set; }
        public XmlReader?                               OuterReader                             { get; set; }
        public bool                                     XmlResolverIsSet                        { get; set; }
        public string                                   Xml                                     { get; set; }
        public string                                   XmlNs                                   { get; set; }

        public static XmlTextReaderImpl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTextReaderImpl();

            value.UseAsync                                  = GetBool(new IntPtr(p + 0x010)); // 0270D73C4598 0x10 UseAsync                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.LaterInitParam                            = GetObject<LaterInitParam>(new IntPtr(p + 0x018), ReversePrism.DataModels.LaterInitParam.FromPointer); // 0270D73C45B8 0x18 LaterInitParam              ( 000186744520 ModelClassType LaterInitParam LaterInitParam LaterInitParam Pointer )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x020)); // 0270D73C45D8 0x20 XmlCharType                 ( 00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.Ps                                        = (ParsingState)GetInt32(new IntPtr(p + 0x028)); // 0270D73C45F8 0x28 Ps                          ( 000186745E50 ModelEnumType ParsingState ParsingState ParsingState Int32 )
            value.ParsingFunction                           = (ParsingFunction)GetInt32(new IntPtr(p + 0x0A0)); // 0270D73C4618 0xA0 ParsingFunction             ( 0001867450F0 ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32 )
            value.NextParsingFunction                       = (ParsingFunction)GetInt32(new IntPtr(p + 0x0A4)); // 0270D73C4638 0xA4 NextParsingFunction         ( 0001867450F0 ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32 )
            value.NextNextParsingFunction                   = (ParsingFunction)GetInt32(new IntPtr(p + 0x0A8)); // 0270D73C4658 0xA8 NextNextParsingFunction     ( 0001867450F0 ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32 )
            value.Nodes                                     = GetObjectList<NodeData>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.NodeData.FromPointer); // 0270D73C4678 0xB0 Nodes                       ( 000185CC8288 ModelClassListType NodeData[] NodeData[] List<NodeData> Pointer )
            value.CurNode                                   = GetObject<NodeData>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.NodeData.FromPointer); // 0270D73C4698 0xB8 CurNode                     ( 000186721FA0 ModelClassType NodeData NodeData NodeData Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x0C0)); // 0270D73C46B8 0xC0 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurAttrIndex                              = GetInt32(new IntPtr(p + 0x0C4)); // 0270D73C46D8 0xC4 CurAttrIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttrCount                                 = GetInt32(new IntPtr(p + 0x0C8)); // 0270D73C46F8 0xC8 AttrCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttrHashtable                             = GetInt32(new IntPtr(p + 0x0CC)); // 0270D73C4718 0xCC AttrHashtable               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttrDuplWalkCount                         = GetInt32(new IntPtr(p + 0x0D0)); // 0270D73C4738 0xD0 AttrDuplWalkCount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttrNeedNamespaceLookup                   = GetBool(new IntPtr(p + 0x0D4)); // 0270D73C4758 0xD4 AttrNeedNamespaceLookup     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FullAttrCleanup                           = GetBool(new IntPtr(p + 0x0D5)); // 0270D73C4778 0xD5 FullAttrCleanup             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AttrDuplSortingArray                      = GetObjectList<NodeData>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.NodeData.FromPointer); // 0270D73C4798 0xD8 AttrDuplSortingArray        ( 000185CC8288 ModelClassListType NodeData[] NodeData[] List<NodeData> Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0270D73C47B8 0xE0 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.NameTableFromSettings                     = GetBool(new IntPtr(p + 0x0E8)); // 0270D73C47D8 0xE8 NameTableFromSettings       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.XmlResolver.FromPointer); // 0270D73C47F8 0xF0 XmlResolver                 ( 0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.Url                                       = GetString(new IntPtr(p + 0x0F8)); // 0270D73C4818 0xF8 Url                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Normalize                                 = GetBool(new IntPtr(p + 0x100)); // 0270D73C4838 0x100 Normalize                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SupportNamespaces                         = GetBool(new IntPtr(p + 0x101)); // 0270D73C4858 0x101 SupportNamespaces           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WhitespaceHandling                        = (WhitespaceHandling)GetInt32(new IntPtr(p + 0x104)); // 0270D73C4878 0x104 WhitespaceHandling          ( 000186559210 ModelEnumType WhitespaceHandling WhitespaceHandling WhitespaceHandling Int32 )
            value.DtdProcessing                             = (DtdProcessing)GetInt32(new IntPtr(p + 0x108)); // 0270D73C4898 0x108 DtdProcessing               ( 000186708FB0 ModelEnumType DtdProcessing DtdProcessing DtdProcessing Int32 )
            value.EntityHandling                            = (EntityHandling)GetInt32(new IntPtr(p + 0x10C)); // 0270D73C48B8 0x10C EntityHandling              ( 000186737C00 ModelEnumType EntityHandling EntityHandling EntityHandling Int32 )
            value.IgnorePIs                                 = GetBool(new IntPtr(p + 0x110)); // 0270D73C48D8 0x110 IgnorePIs                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreComments                            = GetBool(new IntPtr(p + 0x111)); // 0270D73C48F8 0x111 IgnoreComments              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CheckCharacters                           = GetBool(new IntPtr(p + 0x112)); // 0270D73C4918 0x112 CheckCharacters             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LineNumberOffset                          = GetInt32(new IntPtr(p + 0x114)); // 0270D73C4938 0x114 LineNumberOffset            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePositionOffset                        = GetInt32(new IntPtr(p + 0x118)); // 0270D73C4958 0x118 LinePositionOffset          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CloseInput                                = GetBool(new IntPtr(p + 0x11C)); // 0270D73C4978 0x11C CloseInput                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MaxCharactersInDocument                   = GetInt64(new IntPtr(p + 0x120)); // 0270D73C4998 0x120 MaxCharactersInDocument     ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.MaxCharactersFromEntities                 = GetInt64(new IntPtr(p + 0x128)); // 0270D73C49B8 0x128 MaxCharactersFromEntities   ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.V1Compat                                  = GetBool(new IntPtr(p + 0x130)); // 0270D73C49D8 0x130 V1Compat                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NamespaceManager                          = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x138), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0270D73C49F8 0x138 NamespaceManager            ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.LastPrefix                                = GetString(new IntPtr(p + 0x140)); // 0270D73C4A18 0x140 LastPrefix                  ( 000186671910 ModelPrimitiveType string string string String )
            value.XmlContext                                = GetObject<XmlContext>(new IntPtr(p + 0x148), ReversePrism.DataModels.XmlContext.FromPointer); // 0270D73C4A38 0x148 XmlContext                  ( 000186746310 ModelClassType XmlContext XmlContext XmlContext Pointer )
            value.ParsingStatesStack                        = GetEnumList<ParsingState>(new IntPtr(p + 0x150)); // 0270D73C4A58 0x150 ParsingStatesStack          ( 000185CC8348 ModelEnumListType ParsingState[] ParsingState[] List<ParsingState> Pointer )
            value.ParsingStatesStackTop                     = GetInt32(new IntPtr(p + 0x158)); // 0270D73C4A78 0x158 ParsingStatesStackTop       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReportedBaseUri                           = GetString(new IntPtr(p + 0x160)); // 0270D73C4A98 0x160 ReportedBaseUri             ( 000186671910 ModelPrimitiveType string string string String )
            value.ReportedEncoding                          = GetObject<Encoding>(new IntPtr(p + 0x168), ReversePrism.DataModels.Encoding.FromPointer); // 0270D73C4AB8 0x168 ReportedEncoding            ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.DtdInfo                                   = GetObject<IDtdInfo>(new IntPtr(p + 0x170), ReversePrism.DataModels.IDtdInfo.FromPointer); // 0270D73C4AD8 0x170 DtdInfo                     ( 00018675AD20 ModelClassType IDtdInfo IDtdInfo IDtdInfo Pointer )
            value.FragmentType                              = (XmlNodeType)GetInt32(new IntPtr(p + 0x178)); // 0270D73C4AF8 0x178 FragmentType                ( 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.FragmentParserContext                     = GetObject<XmlParserContext>(new IntPtr(p + 0x180), ReversePrism.DataModels.XmlParserContext.FromPointer); // 0270D73C4B18 0x180 FragmentParserContext       ( 0001865A80B0 ModelClassType XmlParserContext XmlParserContext XmlParserContext Pointer )
            value.Fragment                                  = GetBool(new IntPtr(p + 0x188)); // 0270D73C4B38 0x188 Fragment                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IncReadDecoder                            = GetObject<IncrementalReadDecoder>(new IntPtr(p + 0x190), ReversePrism.DataModels.IncrementalReadDecoder.FromPointer); // 0270D73C4B58 0x190 IncReadDecoder              ( 0001866DF210 ModelClassType IncrementalReadDecoder IncrementalReadDecoder IncrementalReadDecoder Pointer )
            value.IncReadState                              = (IncrementalReadState)GetInt32(new IntPtr(p + 0x198)); // 0270D73C4B78 0x198 IncReadState                ( 0001867436F0 ModelEnumType IncrementalReadState IncrementalReadState IncrementalReadState Int32 )
            value.IncReadLineInfo                           = (LineInfo)GetInt32(new IntPtr(p + 0x19C)); // 0270D73C4B98 0x19C IncReadLineInfo             ( 000186607510 ModelEnumType LineInfo LineInfo LineInfo Int32 )
            value.BinHexDecoder                             = GetObject<BinHexDecoder>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.BinHexDecoder.FromPointer); // 0270D73C4BB8 0x1A8 BinHexDecoder               ( 000186752F30 ModelClassType BinHexDecoder BinHexDecoder BinHexDecoder Pointer )
            value.Base64Decoder                             = GetObject<Base64Decoder>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.Base64Decoder.FromPointer); // 0270D73C4BD8 0x1B0 Base64Decoder               ( 00018673B9B0 ModelClassType Base64Decoder Base64Decoder Base64Decoder Pointer )
            value.IncReadDepth                              = GetInt32(new IntPtr(p + 0x1B8)); // 0270D73C4BF8 0x1B8 IncReadDepth                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IncReadLeftStartPos                       = GetInt32(new IntPtr(p + 0x1BC)); // 0270D73C4C18 0x1BC IncReadLeftStartPos         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IncReadLeftEndPos                         = GetInt32(new IntPtr(p + 0x1C0)); // 0270D73C4C38 0x1C0 IncReadLeftEndPos           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttributeValueBaseEntityId                = GetInt32(new IntPtr(p + 0x1C4)); // 0270D73C4C58 0x1C4 AttributeValueBaseEntityId  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EmptyEntityInAttributeResolved            = GetBool(new IntPtr(p + 0x1C8)); // 0270D73C4C78 0x1C8 EmptyEntityInAttributeResolved ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ValidationEventHandling                   = GetObject<IValidationEventHandling>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.IValidationEventHandling.FromPointer); // 0270D73C4C98 0x1D0 ValidationEventHandling     ( 000186691150 ModelClassType IValidationEventHandling IValidationEventHandling IValidationEventHandling Pointer )
            value.OnDefaultAttributeUse                     = GetObject<OnDefaultAttributeUseDelegate>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.OnDefaultAttributeUseDelegate.FromPointer); // 0270D73C4CB8 0x1D8 OnDefaultAttributeUse       ( 000186744C40 ModelClassType OnDefaultAttributeUseDelegate OnDefaultAttributeUseDelegate OnDefaultAttributeUseDelegate Pointer )
            value.ValidatingReaderCompatFlag                = GetBool(new IntPtr(p + 0x1E0)); // 0270D73C4CD8 0x1E0 ValidatingReaderCompatFlag  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AddDefaultAttributesAndNormalize          = GetBool(new IntPtr(p + 0x1E1)); // 0270D73C4CF8 0x1E1 AddDefaultAttributesAndNormalize ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.StringBuilder                             = GetObject<StringBuilder>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.StringBuilder.FromPointer); // 0270D73C4D18 0x1E8 StringBuilder               ( 000186676650 ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.RootElementParsed                         = GetBool(new IntPtr(p + 0x1F0)); // 0270D73C4D38 0x1F0 RootElementParsed           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Standalone                                = GetBool(new IntPtr(p + 0x1F1)); // 0270D73C4D58 0x1F1 Standalone                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NextEntityId                              = GetInt32(new IntPtr(p + 0x1F4)); // 0270D73C4D78 0x1F4 NextEntityId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ParsingMode                               = (ParsingMode)GetInt32(new IntPtr(p + 0x1F8)); // 0270D73C4D98 0x1F8 ParsingMode                 ( 000186745880 ModelEnumType ParsingMode ParsingMode ParsingMode Int32 )
            value.ReadState                                 = (ReadState)GetInt32(new IntPtr(p + 0x1FC)); // 0270D73C4DB8 0x1FC ReadState                   ( 00018661DEC0 ModelEnumType ReadState ReadState ReadState Int32 )
            value.LastEntity                                = GetObject<IDtdEntityInfo>(new IntPtr(p + 0x200), ReversePrism.DataModels.IDtdEntityInfo.FromPointer); // 0270D73C4DD8 0x200 LastEntity                  ( 0001865E2120 ModelClassType IDtdEntityInfo IDtdEntityInfo IDtdEntityInfo Pointer )
            value.AfterResetState                           = GetBool(new IntPtr(p + 0x208)); // 0270D73C4DF8 0x208 AfterResetState             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DocumentStartBytePos                      = GetInt32(new IntPtr(p + 0x20C)); // 0270D73C4E18 0x20C DocumentStartBytePos        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ReadValueOffset                           = GetInt32(new IntPtr(p + 0x210)); // 0270D73C4E38 0x210 ReadValueOffset             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CharactersInDocument                      = GetInt64(new IntPtr(p + 0x218)); // 0270D73C4E58 0x218 CharactersInDocument        ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.CharactersFromEntities                    = GetInt64(new IntPtr(p + 0x220)); // 0270D73C4E78 0x220 CharactersFromEntities      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.DisableUndeclaredEntityCheck              = GetBool(new IntPtr(p + 0x230)); // 0270D73C4EB8 0x230 DisableUndeclaredEntityCheck ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OuterReader                               = GetObject<XmlReader>(new IntPtr(p + 0x238), ReversePrism.DataModels.XmlReader.FromPointer); // 0270D73C4ED8 0x238 OuterReader                 ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.XmlResolverIsSet                          = GetBool(new IntPtr(p + 0x240)); // 0270D73C4EF8 0x240 XmlResolverIsSet            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Xml                                       = GetString(new IntPtr(p + 0x248)); // 0270D73C4F18 0x248 Xml                         ( 000186671910 ModelPrimitiveType string string string String )
            value.XmlNs                                     = GetString(new IntPtr(p + 0x250)); // 0270D73C4F38 0x250 XmlNs                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}

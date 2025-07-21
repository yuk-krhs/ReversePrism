using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAsync                                 ModelPrimitiveType bool bool bool Bool
    // 018 LaterInitParam                           ModelClassType LaterInitParam LaterInitParam LaterInitParam Pointer
    // 020 XmlCharType                              ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 028 Ps                                       ModelEnumType ParsingState ParsingState ParsingState Int32
    // 0A0 ParsingFunction                          ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32
    // 0A4 NextParsingFunction                      ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32
    // 0A8 NextNextParsingFunction                  ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32
    // 0B0 Nodes                                    ModelClassListType NodeData[] NodeData[] List<NodeData> Pointer
    // 0B8 CurNode                                  ModelClassType NodeData NodeData NodeData Pointer
    // 0C0 Index                                    ModelPrimitiveType int int int Int32
    // 0C4 CurAttrIndex                             ModelPrimitiveType int int int Int32
    // 0C8 AttrCount                                ModelPrimitiveType int int int Int32
    // 0CC AttrHashtable                            ModelPrimitiveType int int int Int32
    // 0D0 AttrDuplWalkCount                        ModelPrimitiveType int int int Int32
    // 0D4 AttrNeedNamespaceLookup                  ModelPrimitiveType bool bool bool Bool
    // 0D5 FullAttrCleanup                          ModelPrimitiveType bool bool bool Bool
    // 0D8 AttrDuplSortingArray                     ModelClassListType NodeData[] NodeData[] List<NodeData> Pointer
    // 0E0 NameTable                                ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 0E8 NameTableFromSettings                    ModelPrimitiveType bool bool bool Bool
    // 0F0 XmlResolver                              ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    // 0F8 Url                                      ModelPrimitiveType string string string String
    // 100 Normalize                                ModelPrimitiveType bool bool bool Bool
    // 101 SupportNamespaces                        ModelPrimitiveType bool bool bool Bool
    // 104 WhitespaceHandling                       ModelEnumType WhitespaceHandling WhitespaceHandling WhitespaceHandling Int32
    // 108 DtdProcessing                            ModelEnumType DtdProcessing DtdProcessing DtdProcessing Int32
    // 10C EntityHandling                           ModelEnumType EntityHandling EntityHandling EntityHandling Int32
    // 110 IgnorePIs                                ModelPrimitiveType bool bool bool Bool
    // 111 IgnoreComments                           ModelPrimitiveType bool bool bool Bool
    // 112 CheckCharacters                          ModelPrimitiveType bool bool bool Bool
    // 114 LineNumberOffset                         ModelPrimitiveType int int int Int32
    // 118 LinePositionOffset                       ModelPrimitiveType int int int Int32
    // 11C CloseInput                               ModelPrimitiveType bool bool bool Bool
    // 120 MaxCharactersInDocument                  ModelPrimitiveType long long long Int64
    // 128 MaxCharactersFromEntities                ModelPrimitiveType long long long Int64
    // 130 V1Compat                                 ModelPrimitiveType bool bool bool Bool
    // 138 NamespaceManager                         ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 140 LastPrefix                               ModelPrimitiveType string string string String
    // 148 XmlContext                               ModelClassType XmlContext XmlContext XmlContext Pointer
    // 150 ParsingStatesStack                       ModelEnumListType ParsingState[] ParsingState[] List<ParsingState> Pointer
    // 158 ParsingStatesStackTop                    ModelPrimitiveType int int int Int32
    // 160 ReportedBaseUri                          ModelPrimitiveType string string string String
    // 168 ReportedEncoding                         ModelClassType Encoding Encoding Encoding Pointer
    // 170 DtdInfo                                  ModelClassType IDtdInfo IDtdInfo IDtdInfo Pointer
    // 178 FragmentType                             ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 180 FragmentParserContext                    ModelClassType XmlParserContext XmlParserContext XmlParserContext Pointer
    // 188 Fragment                                 ModelPrimitiveType bool bool bool Bool
    // 190 IncReadDecoder                           ModelClassType IncrementalReadDecoder IncrementalReadDecoder IncrementalReadDecoder Pointer
    // 198 IncReadState                             ModelEnumType IncrementalReadState IncrementalReadState IncrementalReadState Int32
    // 19C IncReadLineInfo                          ModelEnumType LineInfo LineInfo LineInfo Int32
    // 1A8 BinHexDecoder                            ModelClassType BinHexDecoder BinHexDecoder BinHexDecoder Pointer
    // 1B0 Base64Decoder                            ModelClassType Base64Decoder Base64Decoder Base64Decoder Pointer
    // 1B8 IncReadDepth                             ModelPrimitiveType int int int Int32
    // 1BC IncReadLeftStartPos                      ModelPrimitiveType int int int Int32
    // 1C0 IncReadLeftEndPos                        ModelPrimitiveType int int int Int32
    // 1C4 AttributeValueBaseEntityId               ModelPrimitiveType int int int Int32
    // 1C8 EmptyEntityInAttributeResolved           ModelPrimitiveType bool bool bool Bool
    // 1D0 ValidationEventHandling                  ModelClassType IValidationEventHandling IValidationEventHandling IValidationEventHandling Pointer
    // 1D8 OnDefaultAttributeUse                    ModelClassType OnDefaultAttributeUseDelegate OnDefaultAttributeUseDelegate OnDefaultAttributeUseDelegate Pointer
    // 1E0 ValidatingReaderCompatFlag               ModelPrimitiveType bool bool bool Bool
    // 1E1 AddDefaultAttributesAndNormalize         ModelPrimitiveType bool bool bool Bool
    // 1E8 StringBuilder                            ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 1F0 RootElementParsed                        ModelPrimitiveType bool bool bool Bool
    // 1F1 Standalone                               ModelPrimitiveType bool bool bool Bool
    // 1F4 NextEntityId                             ModelPrimitiveType int int int Int32
    // 1F8 ParsingMode                              ModelEnumType ParsingMode ParsingMode ParsingMode Int32
    // 1FC ReadState                                ModelEnumType ReadState ReadState ReadState Int32
    // 200 LastEntity                               ModelClassType IDtdEntityInfo IDtdEntityInfo IDtdEntityInfo Pointer
    // 208 AfterResetState                          ModelPrimitiveType bool bool bool Bool
    // 20C DocumentStartBytePos                     ModelPrimitiveType int int int Int32
    // 210 ReadValueOffset                          ModelPrimitiveType int int int Int32
    // 218 CharactersInDocument                     ModelPrimitiveType long long long Int64
    // 220 CharactersFromEntities                   ModelPrimitiveType long long long Int64
    // 228 currentEntities                          Dictionary`2<IDtdEntityInfo, IDtdEntityInfo> IL2CPP_TYPE_GENERICINST
    // 230 DisableUndeclaredEntityCheck             ModelPrimitiveType bool bool bool Bool
    // 238 OuterReader                              ModelClassType XmlReader XmlReader XmlReader Pointer
    // 240 XmlResolverIsSet                         ModelPrimitiveType bool bool bool Bool
    // 248 Xml                                      ModelPrimitiveType string string string String
    // 250 XmlNs                                    ModelPrimitiveType string string string String
    // 258 parseText_dummyTask                      Task`1<Tuple`4<int, int, int, bool>> IL2CPP_TYPE_GENERICINST
    public partial class XmlTextReaderImpl : DataModel
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
            var value   = new XmlTextReaderImpl() { Pointer= p0 };

            value.UseAsync                                  = GetBool(new IntPtr(p + 0x010)); // 0x10 UseAsync                    ( ModelPrimitiveType bool bool bool Bool )
            value.LaterInitParam                            = GetObject<LaterInitParam>(new IntPtr(p + 0x018), ReversePrism.DataModels.LaterInitParam.FromPointer); // 0x18 LaterInitParam              ( ModelClassType LaterInitParam LaterInitParam LaterInitParam Pointer )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x020)); // 0x20 XmlCharType                 ( ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.Ps                                        = (ParsingState)GetInt32(new IntPtr(p + 0x028)); // 0x28 Ps                          ( ModelEnumType ParsingState ParsingState ParsingState Int32 )
            value.ParsingFunction                           = (ParsingFunction)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 ParsingFunction             ( ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32 )
            value.NextParsingFunction                       = (ParsingFunction)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 NextParsingFunction         ( ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32 )
            value.NextNextParsingFunction                   = (ParsingFunction)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 NextNextParsingFunction     ( ModelEnumType ParsingFunction ParsingFunction ParsingFunction Int32 )
            value.Nodes                                     = GetObjectList<NodeData>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.NodeData.FromPointer); // 0xB0 Nodes                       ( ModelClassListType NodeData[] NodeData[] List<NodeData> Pointer )
            value.CurNode                                   = GetObject<NodeData>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.NodeData.FromPointer); // 0xB8 CurNode                     ( ModelClassType NodeData NodeData NodeData Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 Index                       ( ModelPrimitiveType int int int Int32 )
            value.CurAttrIndex                              = GetInt32(new IntPtr(p + 0x0C4)); // 0xC4 CurAttrIndex                ( ModelPrimitiveType int int int Int32 )
            value.AttrCount                                 = GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 AttrCount                   ( ModelPrimitiveType int int int Int32 )
            value.AttrHashtable                             = GetInt32(new IntPtr(p + 0x0CC)); // 0xCC AttrHashtable               ( ModelPrimitiveType int int int Int32 )
            value.AttrDuplWalkCount                         = GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 AttrDuplWalkCount           ( ModelPrimitiveType int int int Int32 )
            value.AttrNeedNamespaceLookup                   = GetBool(new IntPtr(p + 0x0D4)); // 0xD4 AttrNeedNamespaceLookup     ( ModelPrimitiveType bool bool bool Bool )
            value.FullAttrCleanup                           = GetBool(new IntPtr(p + 0x0D5)); // 0xD5 FullAttrCleanup             ( ModelPrimitiveType bool bool bool Bool )
            value.AttrDuplSortingArray                      = GetObjectList<NodeData>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.NodeData.FromPointer); // 0xD8 AttrDuplSortingArray        ( ModelClassListType NodeData[] NodeData[] List<NodeData> Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0xE0 NameTable                   ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.NameTableFromSettings                     = GetBool(new IntPtr(p + 0x0E8)); // 0xE8 NameTableFromSettings       ( ModelPrimitiveType bool bool bool Bool )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.XmlResolver.FromPointer); // 0xF0 XmlResolver                 ( ModelClassType XmlResolver XmlResolver XmlResolver Pointer )
            value.Url                                       = GetString(new IntPtr(p + 0x0F8)); // 0xF8 Url                         ( ModelPrimitiveType string string string String )
            value.Normalize                                 = GetBool(new IntPtr(p + 0x100)); // 0x100 Normalize                   ( ModelPrimitiveType bool bool bool Bool )
            value.SupportNamespaces                         = GetBool(new IntPtr(p + 0x101)); // 0x101 SupportNamespaces           ( ModelPrimitiveType bool bool bool Bool )
            value.WhitespaceHandling                        = (WhitespaceHandling)GetInt32(new IntPtr(p + 0x104)); // 0x104 WhitespaceHandling          ( ModelEnumType WhitespaceHandling WhitespaceHandling WhitespaceHandling Int32 )
            value.DtdProcessing                             = (DtdProcessing)GetInt32(new IntPtr(p + 0x108)); // 0x108 DtdProcessing               ( ModelEnumType DtdProcessing DtdProcessing DtdProcessing Int32 )
            value.EntityHandling                            = (EntityHandling)GetInt32(new IntPtr(p + 0x10C)); // 0x10C EntityHandling              ( ModelEnumType EntityHandling EntityHandling EntityHandling Int32 )
            value.IgnorePIs                                 = GetBool(new IntPtr(p + 0x110)); // 0x110 IgnorePIs                   ( ModelPrimitiveType bool bool bool Bool )
            value.IgnoreComments                            = GetBool(new IntPtr(p + 0x111)); // 0x111 IgnoreComments              ( ModelPrimitiveType bool bool bool Bool )
            value.CheckCharacters                           = GetBool(new IntPtr(p + 0x112)); // 0x112 CheckCharacters             ( ModelPrimitiveType bool bool bool Bool )
            value.LineNumberOffset                          = GetInt32(new IntPtr(p + 0x114)); // 0x114 LineNumberOffset            ( ModelPrimitiveType int int int Int32 )
            value.LinePositionOffset                        = GetInt32(new IntPtr(p + 0x118)); // 0x118 LinePositionOffset          ( ModelPrimitiveType int int int Int32 )
            value.CloseInput                                = GetBool(new IntPtr(p + 0x11C)); // 0x11C CloseInput                  ( ModelPrimitiveType bool bool bool Bool )
            value.MaxCharactersInDocument                   = GetInt64(new IntPtr(p + 0x120)); // 0x120 MaxCharactersInDocument     ( ModelPrimitiveType long long long Int64 )
            value.MaxCharactersFromEntities                 = GetInt64(new IntPtr(p + 0x128)); // 0x128 MaxCharactersFromEntities   ( ModelPrimitiveType long long long Int64 )
            value.V1Compat                                  = GetBool(new IntPtr(p + 0x130)); // 0x130 V1Compat                    ( ModelPrimitiveType bool bool bool Bool )
            value.NamespaceManager                          = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x138), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0x138 NamespaceManager            ( ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.LastPrefix                                = GetString(new IntPtr(p + 0x140)); // 0x140 LastPrefix                  ( ModelPrimitiveType string string string String )
            value.XmlContext                                = GetObject<XmlContext>(new IntPtr(p + 0x148), ReversePrism.DataModels.XmlContext.FromPointer); // 0x148 XmlContext                  ( ModelClassType XmlContext XmlContext XmlContext Pointer )
            value.ParsingStatesStack                        = GetEnumList<ParsingState>(new IntPtr(p + 0x150)); // 0x150 ParsingStatesStack          ( ModelEnumListType ParsingState[] ParsingState[] List<ParsingState> Pointer )
            value.ParsingStatesStackTop                     = GetInt32(new IntPtr(p + 0x158)); // 0x158 ParsingStatesStackTop       ( ModelPrimitiveType int int int Int32 )
            value.ReportedBaseUri                           = GetString(new IntPtr(p + 0x160)); // 0x160 ReportedBaseUri             ( ModelPrimitiveType string string string String )
            value.ReportedEncoding                          = GetObject<Encoding>(new IntPtr(p + 0x168), ReversePrism.DataModels.Encoding.FromPointer); // 0x168 ReportedEncoding            ( ModelClassType Encoding Encoding Encoding Pointer )
            value.DtdInfo                                   = GetObject<IDtdInfo>(new IntPtr(p + 0x170), ReversePrism.DataModels.IDtdInfo.FromPointer); // 0x170 DtdInfo                     ( ModelClassType IDtdInfo IDtdInfo IDtdInfo Pointer )
            value.FragmentType                              = (XmlNodeType)GetInt32(new IntPtr(p + 0x178)); // 0x178 FragmentType                ( ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.FragmentParserContext                     = GetObject<XmlParserContext>(new IntPtr(p + 0x180), ReversePrism.DataModels.XmlParserContext.FromPointer); // 0x180 FragmentParserContext       ( ModelClassType XmlParserContext XmlParserContext XmlParserContext Pointer )
            value.Fragment                                  = GetBool(new IntPtr(p + 0x188)); // 0x188 Fragment                    ( ModelPrimitiveType bool bool bool Bool )
            value.IncReadDecoder                            = GetObject<IncrementalReadDecoder>(new IntPtr(p + 0x190), ReversePrism.DataModels.IncrementalReadDecoder.FromPointer); // 0x190 IncReadDecoder              ( ModelClassType IncrementalReadDecoder IncrementalReadDecoder IncrementalReadDecoder Pointer )
            value.IncReadState                              = (IncrementalReadState)GetInt32(new IntPtr(p + 0x198)); // 0x198 IncReadState                ( ModelEnumType IncrementalReadState IncrementalReadState IncrementalReadState Int32 )
            value.IncReadLineInfo                           = (LineInfo)GetInt32(new IntPtr(p + 0x19C)); // 0x19C IncReadLineInfo             ( ModelEnumType LineInfo LineInfo LineInfo Int32 )
            value.BinHexDecoder                             = GetObject<BinHexDecoder>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.BinHexDecoder.FromPointer); // 0x1A8 BinHexDecoder               ( ModelClassType BinHexDecoder BinHexDecoder BinHexDecoder Pointer )
            value.Base64Decoder                             = GetObject<Base64Decoder>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.Base64Decoder.FromPointer); // 0x1B0 Base64Decoder               ( ModelClassType Base64Decoder Base64Decoder Base64Decoder Pointer )
            value.IncReadDepth                              = GetInt32(new IntPtr(p + 0x1B8)); // 0x1B8 IncReadDepth                ( ModelPrimitiveType int int int Int32 )
            value.IncReadLeftStartPos                       = GetInt32(new IntPtr(p + 0x1BC)); // 0x1BC IncReadLeftStartPos         ( ModelPrimitiveType int int int Int32 )
            value.IncReadLeftEndPos                         = GetInt32(new IntPtr(p + 0x1C0)); // 0x1C0 IncReadLeftEndPos           ( ModelPrimitiveType int int int Int32 )
            value.AttributeValueBaseEntityId                = GetInt32(new IntPtr(p + 0x1C4)); // 0x1C4 AttributeValueBaseEntityId  ( ModelPrimitiveType int int int Int32 )
            value.EmptyEntityInAttributeResolved            = GetBool(new IntPtr(p + 0x1C8)); // 0x1C8 EmptyEntityInAttributeResolved ( ModelPrimitiveType bool bool bool Bool )
            value.ValidationEventHandling                   = GetObject<IValidationEventHandling>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.IValidationEventHandling.FromPointer); // 0x1D0 ValidationEventHandling     ( ModelClassType IValidationEventHandling IValidationEventHandling IValidationEventHandling Pointer )
            value.OnDefaultAttributeUse                     = GetObject<OnDefaultAttributeUseDelegate>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.OnDefaultAttributeUseDelegate.FromPointer); // 0x1D8 OnDefaultAttributeUse       ( ModelClassType OnDefaultAttributeUseDelegate OnDefaultAttributeUseDelegate OnDefaultAttributeUseDelegate Pointer )
            value.ValidatingReaderCompatFlag                = GetBool(new IntPtr(p + 0x1E0)); // 0x1E0 ValidatingReaderCompatFlag  ( ModelPrimitiveType bool bool bool Bool )
            value.AddDefaultAttributesAndNormalize          = GetBool(new IntPtr(p + 0x1E1)); // 0x1E1 AddDefaultAttributesAndNormalize ( ModelPrimitiveType bool bool bool Bool )
            value.StringBuilder                             = GetObject<StringBuilder>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x1E8 StringBuilder               ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.RootElementParsed                         = GetBool(new IntPtr(p + 0x1F0)); // 0x1F0 RootElementParsed           ( ModelPrimitiveType bool bool bool Bool )
            value.Standalone                                = GetBool(new IntPtr(p + 0x1F1)); // 0x1F1 Standalone                  ( ModelPrimitiveType bool bool bool Bool )
            value.NextEntityId                              = GetInt32(new IntPtr(p + 0x1F4)); // 0x1F4 NextEntityId                ( ModelPrimitiveType int int int Int32 )
            value.ParsingMode                               = (ParsingMode)GetInt32(new IntPtr(p + 0x1F8)); // 0x1F8 ParsingMode                 ( ModelEnumType ParsingMode ParsingMode ParsingMode Int32 )
            value.ReadState                                 = (ReadState)GetInt32(new IntPtr(p + 0x1FC)); // 0x1FC ReadState                   ( ModelEnumType ReadState ReadState ReadState Int32 )
            value.LastEntity                                = GetObject<IDtdEntityInfo>(new IntPtr(p + 0x200), ReversePrism.DataModels.IDtdEntityInfo.FromPointer); // 0x200 LastEntity                  ( ModelClassType IDtdEntityInfo IDtdEntityInfo IDtdEntityInfo Pointer )
            value.AfterResetState                           = GetBool(new IntPtr(p + 0x208)); // 0x208 AfterResetState             ( ModelPrimitiveType bool bool bool Bool )
            value.DocumentStartBytePos                      = GetInt32(new IntPtr(p + 0x20C)); // 0x20C DocumentStartBytePos        ( ModelPrimitiveType int int int Int32 )
            value.ReadValueOffset                           = GetInt32(new IntPtr(p + 0x210)); // 0x210 ReadValueOffset             ( ModelPrimitiveType int int int Int32 )
            value.CharactersInDocument                      = GetInt64(new IntPtr(p + 0x218)); // 0x218 CharactersInDocument        ( ModelPrimitiveType long long long Int64 )
            value.CharactersFromEntities                    = GetInt64(new IntPtr(p + 0x220)); // 0x220 CharactersFromEntities      ( ModelPrimitiveType long long long Int64 )
            value.DisableUndeclaredEntityCheck              = GetBool(new IntPtr(p + 0x230)); // 0x230 DisableUndeclaredEntityCheck ( ModelPrimitiveType bool bool bool Bool )
            value.OuterReader                               = GetObject<XmlReader>(new IntPtr(p + 0x238), ReversePrism.DataModels.XmlReader.FromPointer); // 0x238 OuterReader                 ( ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.XmlResolverIsSet                          = GetBool(new IntPtr(p + 0x240)); // 0x240 XmlResolverIsSet            ( ModelPrimitiveType bool bool bool Bool )
            value.Xml                                       = GetString(new IntPtr(p + 0x248)); // 0x248 Xml                         ( ModelPrimitiveType string string string String )
            value.XmlNs                                     = GetString(new IntPtr(p + 0x250)); // 0x250 XmlNs                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TypeOfObject                             Type IL2CPP_TYPE_CLASS
    // 008 TypeOfString                             Type IL2CPP_TYPE_CLASS
    // 010 TokenTypeMap                             ModelClassListType Type[] Type[] List<Type> Pointer
    // 018 XsdKatmaiTimeScaleToValueLengthMap       ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 ScanState2ReadState                      ModelEnumListType ReadState[] ReadState[] List<ReadState> Pointer
    // 010 InStrm                                   ModelClassType Stream Stream Stream Pointer
    // 018 Data                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Pos                                      ModelPrimitiveType int int int Int32
    // 024 Mark                                     ModelPrimitiveType int int int Int32
    // 028 End                                      ModelPrimitiveType int int int Int32
    // 030 Offset                                   ModelPrimitiveType long long long Int64
    // 038 Eof                                      ModelPrimitiveType bool bool bool Bool
    // 039 Sniffed                                  ModelPrimitiveType bool bool bool Bool
    // 03A IsEmpty                                  ModelPrimitiveType bool bool bool Bool
    // 03C DocState                                 ModelPrimitiveType int int int Int32
    // 040 SymbolTables                             ModelEnumType SymbolTables SymbolTables SymbolTables Int32
    // 060 Xnt                                      ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 068 XntFromSettings                          ModelPrimitiveType bool bool bool Bool
    // 070 Xml                                      ModelPrimitiveType string string string String
    // 078 Xmlns                                    ModelPrimitiveType string string string String
    // 080 Nsxmlns                                  ModelPrimitiveType string string string String
    // 088 BaseUri                                  ModelPrimitiveType string string string String
    // 090 State                                    ModelEnumType ScanState ScanState ScanState Int32
    // 094 Nodetype                                 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 098 Token                                    ModelEnumType BinXmlToken BinXmlToken BinXmlToken Int32
    // 09C AttrIndex                                ModelPrimitiveType int int int Int32
    // 0A0 QnameOther                               ModelEnumType QName QName QName Int32
    // 0B8 QnameElement                             ModelEnumType QName QName QName Int32
    // 0D0 ParentNodeType                           ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 0D8 ElementStack                             ModelEnumListType ElemInfo[] ElemInfo[] List<ElemInfo> Pointer
    // 0E0 ElemDepth                                ModelPrimitiveType int int int Int32
    // 0E8 Attributes                               ModelEnumListType AttrInfo[] AttrInfo[] List<AttrInfo> Pointer
    // 0F0 AttrHashTbl                              ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0F8 AttrCount                                ModelPrimitiveType int int int Int32
    // 0FC PosAfterAttrs                            ModelPrimitiveType int int int Int32
    // 100 XmlspacePreserve                         ModelPrimitiveType bool bool bool Bool
    // 104 TokLen                                   ModelPrimitiveType int int int Int32
    // 108 TokDataPos                               ModelPrimitiveType int int int Int32
    // 10C HasTypedValue                            ModelPrimitiveType bool bool bool Bool
    // 110 ValueType                                ModelClassType Type Type Type Pointer
    // 118 StringValue                              ModelPrimitiveType string string string String
    // 120 namespaces                               Dictionary`2<string, NamespaceDecl> IL2CPP_TYPE_GENERICINST
    // 128 PrevNameInfo                             ModelClassType NestedBinXml NestedBinXml NestedBinXml Pointer
    // 130 TextXmlReader                            ModelClassType XmlReader XmlReader XmlReader Pointer
    // 138 CloseInput                               ModelPrimitiveType bool bool bool Bool
    // 139 CheckCharacters                          ModelPrimitiveType bool bool bool Bool
    // 13A IgnoreWhitespace                         ModelPrimitiveType bool bool bool Bool
    // 13B IgnorePIs                                ModelPrimitiveType bool bool bool Bool
    // 13C IgnoreComments                           ModelPrimitiveType bool bool bool Bool
    // 140 DtdProcessing                            ModelEnumType DtdProcessing DtdProcessing DtdProcessing Int32
    // 148 Hasher                                   ModelClassType SecureStringHasher SecureStringHasher SecureStringHasher Pointer
    // 150 XmlCharType                              ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 158 Unicode                                  ModelClassType Encoding Encoding Encoding Pointer
    // 160 Version                                  ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class XmlSqlBinaryReader : DataModel
    {
        public List<Type>?                              TokenTypeMap                            { get; set; }
        public List<sbyte>?                             XsdKatmaiTimeScaleToValueLengthMap      { get; set; }
        public List<ReadState>?                         ScanState2ReadState                     { get; set; }
        public Stream?                                  InStrm                                  { get; set; }
        public List<sbyte>?                             Data                                    { get; set; }
        public int                                      Pos                                     { get; set; }
        public int                                      Mark                                    { get; set; }
        public int                                      End                                     { get; set; }
        public long                                     Offset                                  { get; set; }
        public bool                                     Eof                                     { get; set; }
        public bool                                     Sniffed                                 { get; set; }
        public bool                                     IsEmpty                                 { get; set; }
        public int                                      DocState                                { get; set; }
        public SymbolTables                             SymbolTables                            { get; set; }
        public XmlNameTable?                            Xnt                                     { get; set; }
        public bool                                     XntFromSettings                         { get; set; }
        public string                                   Xml                                     { get; set; }
        public string                                   Xmlns                                   { get; set; }
        public string                                   Nsxmlns                                 { get; set; }
        public string                                   BaseUri                                 { get; set; }
        public ScanState                                State                                   { get; set; }
        public XmlNodeType                              Nodetype                                { get; set; }
        public BinXmlToken                              Token                                   { get; set; }
        public int                                      AttrIndex                               { get; set; }
        public QName                                    QnameOther                              { get; set; }
        public QName                                    QnameElement                            { get; set; }
        public XmlNodeType                              ParentNodeType                          { get; set; }
        public List<ElemInfo>?                          ElementStack                            { get; set; }
        public int                                      ElemDepth                               { get; set; }
        public List<AttrInfo>?                          Attributes                              { get; set; }
        public List<int>?                               AttrHashTbl                             { get; set; }
        public int                                      AttrCount                               { get; set; }
        public int                                      PosAfterAttrs                           { get; set; }
        public bool                                     XmlspacePreserve                        { get; set; }
        public int                                      TokLen                                  { get; set; }
        public int                                      TokDataPos                              { get; set; }
        public bool                                     HasTypedValue                           { get; set; }
        public Type?                                    ValueType                               { get; set; }
        public string                                   StringValue                             { get; set; }
        public NestedBinXml?                            PrevNameInfo                            { get; set; }
        public XmlReader?                               TextXmlReader                           { get; set; }
        public bool                                     CloseInput                              { get; set; }
        public bool                                     CheckCharacters                         { get; set; }
        public bool                                     IgnoreWhitespace                        { get; set; }
        public bool                                     IgnorePIs                               { get; set; }
        public bool                                     IgnoreComments                          { get; set; }
        public DtdProcessing                            DtdProcessing                           { get; set; }
        public SecureStringHasher?                      Hasher                                  { get; set; }
        public XmlCharType                              XmlCharType                             { get; set; }
        public Encoding?                                Unicode                                 { get; set; }
        public sbyte                                    Version                                 { get; set; }

        public static XmlSqlBinaryReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSqlBinaryReader() { Pointer= p0 };

            value.TokenTypeMap                              = GetObjectList<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 TokenTypeMap                ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.XsdKatmaiTimeScaleToValueLengthMap        = GetSByteList(new IntPtr(p + 0x018)); // 0x18 XsdKatmaiTimeScaleToValueLengthMap ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ScanState2ReadState                       = GetEnumList<ReadState>(new IntPtr(p + 0x020)); // 0x20 ScanState2ReadState         ( ModelEnumListType ReadState[] ReadState[] List<ReadState> Pointer )
            value.InStrm                                    = GetObject<Stream>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stream.FromPointer); // 0x10 InStrm                      ( ModelClassType Stream Stream Stream Pointer )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Data                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Pos                                       = GetInt32(new IntPtr(p + 0x020)); // 0x20 Pos                         ( ModelPrimitiveType int int int Int32 )
            value.Mark                                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 Mark                        ( ModelPrimitiveType int int int Int32 )
            value.End                                       = GetInt32(new IntPtr(p + 0x028)); // 0x28 End                         ( ModelPrimitiveType int int int Int32 )
            value.Offset                                    = GetInt64(new IntPtr(p + 0x030)); // 0x30 Offset                      ( ModelPrimitiveType long long long Int64 )
            value.Eof                                       = GetBool(new IntPtr(p + 0x038)); // 0x38 Eof                         ( ModelPrimitiveType bool bool bool Bool )
            value.Sniffed                                   = GetBool(new IntPtr(p + 0x039)); // 0x39 Sniffed                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsEmpty                                   = GetBool(new IntPtr(p + 0x03A)); // 0x3A IsEmpty                     ( ModelPrimitiveType bool bool bool Bool )
            value.DocState                                  = GetInt32(new IntPtr(p + 0x03C)); // 0x3C DocState                    ( ModelPrimitiveType int int int Int32 )
            value.SymbolTables                              = (SymbolTables)GetInt32(new IntPtr(p + 0x040)); // 0x40 SymbolTables                ( ModelEnumType SymbolTables SymbolTables SymbolTables Int32 )
            value.Xnt                                       = GetObject<XmlNameTable>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0x60 Xnt                         ( ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.XntFromSettings                           = GetBool(new IntPtr(p + 0x068)); // 0x68 XntFromSettings             ( ModelPrimitiveType bool bool bool Bool )
            value.Xml                                       = GetString(new IntPtr(p + 0x070)); // 0x70 Xml                         ( ModelPrimitiveType string string string String )
            value.Xmlns                                     = GetString(new IntPtr(p + 0x078)); // 0x78 Xmlns                       ( ModelPrimitiveType string string string String )
            value.Nsxmlns                                   = GetString(new IntPtr(p + 0x080)); // 0x80 Nsxmlns                     ( ModelPrimitiveType string string string String )
            value.BaseUri                                   = GetString(new IntPtr(p + 0x088)); // 0x88 BaseUri                     ( ModelPrimitiveType string string string String )
            value.State                                     = (ScanState)GetInt32(new IntPtr(p + 0x090)); // 0x90 State                       ( ModelEnumType ScanState ScanState ScanState Int32 )
            value.Nodetype                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x094)); // 0x94 Nodetype                    ( ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.Token                                     = (BinXmlToken)GetInt32(new IntPtr(p + 0x098)); // 0x98 Token                       ( ModelEnumType BinXmlToken BinXmlToken BinXmlToken Int32 )
            value.AttrIndex                                 = GetInt32(new IntPtr(p + 0x09C)); // 0x9C AttrIndex                   ( ModelPrimitiveType int int int Int32 )
            value.QnameOther                                = (QName)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 QnameOther                  ( ModelEnumType QName QName QName Int32 )
            value.QnameElement                              = (QName)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 QnameElement                ( ModelEnumType QName QName QName Int32 )
            value.ParentNodeType                            = (XmlNodeType)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 ParentNodeType              ( ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.ElementStack                              = GetEnumList<ElemInfo>(new IntPtr(p + 0x0D8)); // 0xD8 ElementStack                ( ModelEnumListType ElemInfo[] ElemInfo[] List<ElemInfo> Pointer )
            value.ElemDepth                                 = GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 ElemDepth                   ( ModelPrimitiveType int int int Int32 )
            value.Attributes                                = GetEnumList<AttrInfo>(new IntPtr(p + 0x0E8)); // 0xE8 Attributes                  ( ModelEnumListType AttrInfo[] AttrInfo[] List<AttrInfo> Pointer )
            value.AttrHashTbl                               = GetInt32List(new IntPtr(p + 0x0F0)); // 0xF0 AttrHashTbl                 ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.AttrCount                                 = GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 AttrCount                   ( ModelPrimitiveType int int int Int32 )
            value.PosAfterAttrs                             = GetInt32(new IntPtr(p + 0x0FC)); // 0xFC PosAfterAttrs               ( ModelPrimitiveType int int int Int32 )
            value.XmlspacePreserve                          = GetBool(new IntPtr(p + 0x100)); // 0x100 XmlspacePreserve            ( ModelPrimitiveType bool bool bool Bool )
            value.TokLen                                    = GetInt32(new IntPtr(p + 0x104)); // 0x104 TokLen                      ( ModelPrimitiveType int int int Int32 )
            value.TokDataPos                                = GetInt32(new IntPtr(p + 0x108)); // 0x108 TokDataPos                  ( ModelPrimitiveType int int int Int32 )
            value.HasTypedValue                             = GetBool(new IntPtr(p + 0x10C)); // 0x10C HasTypedValue               ( ModelPrimitiveType bool bool bool Bool )
            value.ValueType                                 = GetObject<Type>(new IntPtr(p + 0x110), ReversePrism.DataModels.Type.FromPointer); // 0x110 ValueType                   ( ModelClassType Type Type Type Pointer )
            value.StringValue                               = GetString(new IntPtr(p + 0x118)); // 0x118 StringValue                 ( ModelPrimitiveType string string string String )
            value.PrevNameInfo                              = GetObject<NestedBinXml>(new IntPtr(p + 0x128), ReversePrism.DataModels.NestedBinXml.FromPointer); // 0x128 PrevNameInfo                ( ModelClassType NestedBinXml NestedBinXml NestedBinXml Pointer )
            value.TextXmlReader                             = GetObject<XmlReader>(new IntPtr(p + 0x130), ReversePrism.DataModels.XmlReader.FromPointer); // 0x130 TextXmlReader               ( ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.CloseInput                                = GetBool(new IntPtr(p + 0x138)); // 0x138 CloseInput                  ( ModelPrimitiveType bool bool bool Bool )
            value.CheckCharacters                           = GetBool(new IntPtr(p + 0x139)); // 0x139 CheckCharacters             ( ModelPrimitiveType bool bool bool Bool )
            value.IgnoreWhitespace                          = GetBool(new IntPtr(p + 0x13A)); // 0x13A IgnoreWhitespace            ( ModelPrimitiveType bool bool bool Bool )
            value.IgnorePIs                                 = GetBool(new IntPtr(p + 0x13B)); // 0x13B IgnorePIs                   ( ModelPrimitiveType bool bool bool Bool )
            value.IgnoreComments                            = GetBool(new IntPtr(p + 0x13C)); // 0x13C IgnoreComments              ( ModelPrimitiveType bool bool bool Bool )
            value.DtdProcessing                             = (DtdProcessing)GetInt32(new IntPtr(p + 0x140)); // 0x140 DtdProcessing               ( ModelEnumType DtdProcessing DtdProcessing DtdProcessing Int32 )
            value.Hasher                                    = GetObject<SecureStringHasher>(new IntPtr(p + 0x148), ReversePrism.DataModels.SecureStringHasher.FromPointer); // 0x148 Hasher                      ( ModelClassType SecureStringHasher SecureStringHasher SecureStringHasher Pointer )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x150)); // 0x150 XmlCharType                 ( ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.Unicode                                   = GetObject<Encoding>(new IntPtr(p + 0x158), ReversePrism.DataModels.Encoding.FromPointer); // 0x158 Unicode                     ( ModelClassType Encoding Encoding Encoding Pointer )
            value.Version                                   = GetSByte(new IntPtr(p + 0x160)); // 0x160 Version                     ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}

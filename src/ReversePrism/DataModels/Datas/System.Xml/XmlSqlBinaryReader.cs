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
    // 010 TokenTypeMap                             000185B82F20 ModelClassListType Type[] Type[] List<Type> Pointer
    // 018 XsdKatmaiTimeScaleToValueLengthMap       000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 ScanState2ReadState                      000185CA01A8 ModelEnumListType ReadState[] ReadState[] List<ReadState> Pointer
    // 010 InStrm                                   000186670270 ModelClassType Stream Stream Stream Pointer
    // 018 Data                                     000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Pos                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Mark                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 End                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Offset                                   0001865F7700 ModelPrimitiveType long long long Int64
    // 038 Eof                                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 Sniffed                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03A IsEmpty                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C DocState                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 SymbolTables                             000186741260 ModelEnumType SymbolTables SymbolTables SymbolTables Int32
    // 060 Xnt                                      0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 068 XntFromSettings                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 Xml                                      000186671910 ModelPrimitiveType string string string String
    // 078 Xmlns                                    000186671910 ModelPrimitiveType string string string String
    // 080 Nsxmlns                                  000186671910 ModelPrimitiveType string string string String
    // 088 BaseUri                                  000186671910 ModelPrimitiveType string string string String
    // 090 State                                    000186740B60 ModelEnumType ScanState ScanState ScanState Int32
    // 094 Nodetype                                 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 098 Token                                    000186754240 ModelEnumType BinXmlToken BinXmlToken BinXmlToken Int32
    // 09C AttrIndex                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A0 QnameOther                               0001867403C0 ModelEnumType QName QName QName Int32
    // 0B8 QnameElement                             0001867403C0 ModelEnumType QName QName QName Int32
    // 0D0 ParentNodeType                           0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 0D8 ElementStack                             000185CC7D78 ModelEnumListType ElemInfo[] ElemInfo[] List<ElemInfo> Pointer
    // 0E0 ElemDepth                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0E8 Attributes                               000185CC7B68 ModelEnumListType AttrInfo[] AttrInfo[] List<AttrInfo> Pointer
    // 0F0 AttrHashTbl                              000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 0F8 AttrCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0FC PosAfterAttrs                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 100 XmlspacePreserve                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 104 TokLen                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 108 TokDataPos                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 10C HasTypedValue                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 110 ValueType                                000186692850 ModelClassType Type Type Type Pointer
    // 118 StringValue                              000186671910 ModelPrimitiveType string string string String
    // 120 namespaces                               Dictionary`2<string, NamespaceDecl> IL2CPP_TYPE_GENERICINST
    // 128 PrevNameInfo                             00018673FE00 ModelClassType NestedBinXml NestedBinXml NestedBinXml Pointer
    // 130 TextXmlReader                            0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 138 CloseInput                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 139 CheckCharacters                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 13A IgnoreWhitespace                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 13B IgnorePIs                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 13C IgnoreComments                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 140 DtdProcessing                            000186708FB0 ModelEnumType DtdProcessing DtdProcessing DtdProcessing Int32
    // 148 Hasher                                   000186710590 ModelClassType SecureStringHasher SecureStringHasher SecureStringHasher Pointer
    // 150 XmlCharType                              00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 158 Unicode                                  00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 160 Version                                  00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
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

            value.TokenTypeMap                              = GetObjectList<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 02466739D6F0 0x10 TokenTypeMap                ( 000185B82F20 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.XsdKatmaiTimeScaleToValueLengthMap        = GetSByteList(new IntPtr(p + 0x018)); // 02466739D710 0x18 XsdKatmaiTimeScaleToValueLengthMap ( 000185B79D90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.ScanState2ReadState                       = GetEnumList<ReadState>(new IntPtr(p + 0x020)); // 02466739D730 0x20 ScanState2ReadState         ( 000185CA01A8 ModelEnumListType ReadState[] ReadState[] List<ReadState> Pointer )
            value.InStrm                                    = GetObject<Stream>(new IntPtr(p + 0x010), ReversePrism.DataModels.Stream.FromPointer); // 02466739D750 0x10 InStrm                      ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x018)); // 02466739D770 0x18 Data                        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Pos                                       = GetInt32(new IntPtr(p + 0x020)); // 02466739D790 0x20 Pos                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Mark                                      = GetInt32(new IntPtr(p + 0x024)); // 02466739D7B0 0x24 Mark                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.End                                       = GetInt32(new IntPtr(p + 0x028)); // 02466739D7D0 0x28 End                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Offset                                    = GetInt64(new IntPtr(p + 0x030)); // 02466739D7F0 0x30 Offset                      ( 0001865F7700 ModelPrimitiveType long long long Int64 )
            value.Eof                                       = GetBool(new IntPtr(p + 0x038)); // 02466739D810 0x38 Eof                         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Sniffed                                   = GetBool(new IntPtr(p + 0x039)); // 02466739D830 0x39 Sniffed                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsEmpty                                   = GetBool(new IntPtr(p + 0x03A)); // 02466739D850 0x3A IsEmpty                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DocState                                  = GetInt32(new IntPtr(p + 0x03C)); // 02466739D870 0x3C DocState                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SymbolTables                              = (SymbolTables)GetInt32(new IntPtr(p + 0x040)); // 02466739D890 0x40 SymbolTables                ( 000186741260 ModelEnumType SymbolTables SymbolTables SymbolTables Int32 )
            value.Xnt                                       = GetObject<XmlNameTable>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlNameTable.FromPointer); // 02466739D8B0 0x60 Xnt                         ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.XntFromSettings                           = GetBool(new IntPtr(p + 0x068)); // 02466739D8D0 0x68 XntFromSettings             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Xml                                       = GetString(new IntPtr(p + 0x070)); // 02466739D8F0 0x70 Xml                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Xmlns                                     = GetString(new IntPtr(p + 0x078)); // 02466739D910 0x78 Xmlns                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Nsxmlns                                   = GetString(new IntPtr(p + 0x080)); // 02466739D930 0x80 Nsxmlns                     ( 000186671910 ModelPrimitiveType string string string String )
            value.BaseUri                                   = GetString(new IntPtr(p + 0x088)); // 02466739D950 0x88 BaseUri                     ( 000186671910 ModelPrimitiveType string string string String )
            value.State                                     = (ScanState)GetInt32(new IntPtr(p + 0x090)); // 02466739D970 0x90 State                       ( 000186740B60 ModelEnumType ScanState ScanState ScanState Int32 )
            value.Nodetype                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x094)); // 02466739D990 0x94 Nodetype                    ( 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.Token                                     = (BinXmlToken)GetInt32(new IntPtr(p + 0x098)); // 02466739D9B0 0x98 Token                       ( 000186754240 ModelEnumType BinXmlToken BinXmlToken BinXmlToken Int32 )
            value.AttrIndex                                 = GetInt32(new IntPtr(p + 0x09C)); // 02466739D9D0 0x9C AttrIndex                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.QnameOther                                = (QName)GetInt32(new IntPtr(p + 0x0A0)); // 02466739D9F0 0xA0 QnameOther                  ( 0001867403C0 ModelEnumType QName QName QName Int32 )
            value.QnameElement                              = (QName)GetInt32(new IntPtr(p + 0x0B8)); // 02466739DA10 0xB8 QnameElement                ( 0001867403C0 ModelEnumType QName QName QName Int32 )
            value.ParentNodeType                            = (XmlNodeType)GetInt32(new IntPtr(p + 0x0D0)); // 02466739DA30 0xD0 ParentNodeType              ( 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.ElementStack                              = GetEnumList<ElemInfo>(new IntPtr(p + 0x0D8)); // 02466739DA50 0xD8 ElementStack                ( 000185CC7D78 ModelEnumListType ElemInfo[] ElemInfo[] List<ElemInfo> Pointer )
            value.ElemDepth                                 = GetInt32(new IntPtr(p + 0x0E0)); // 02466739DA70 0xE0 ElemDepth                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Attributes                                = GetEnumList<AttrInfo>(new IntPtr(p + 0x0E8)); // 02466739DA90 0xE8 Attributes                  ( 000185CC7B68 ModelEnumListType AttrInfo[] AttrInfo[] List<AttrInfo> Pointer )
            value.AttrHashTbl                               = GetInt32List(new IntPtr(p + 0x0F0)); // 02466739DAB0 0xF0 AttrHashTbl                 ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.AttrCount                                 = GetInt32(new IntPtr(p + 0x0F8)); // 02466739DAD0 0xF8 AttrCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PosAfterAttrs                             = GetInt32(new IntPtr(p + 0x0FC)); // 02466739DAF0 0xFC PosAfterAttrs               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.XmlspacePreserve                          = GetBool(new IntPtr(p + 0x100)); // 02466739DB10 0x100 XmlspacePreserve            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TokLen                                    = GetInt32(new IntPtr(p + 0x104)); // 02466739DB30 0x104 TokLen                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TokDataPos                                = GetInt32(new IntPtr(p + 0x108)); // 02466739DB50 0x108 TokDataPos                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HasTypedValue                             = GetBool(new IntPtr(p + 0x10C)); // 02466739DB70 0x10C HasTypedValue               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ValueType                                 = GetObject<Type>(new IntPtr(p + 0x110), ReversePrism.DataModels.Type.FromPointer); // 02466739DB90 0x110 ValueType                   ( 000186692850 ModelClassType Type Type Type Pointer )
            value.StringValue                               = GetString(new IntPtr(p + 0x118)); // 02466739DBB0 0x118 StringValue                 ( 000186671910 ModelPrimitiveType string string string String )
            value.PrevNameInfo                              = GetObject<NestedBinXml>(new IntPtr(p + 0x128), ReversePrism.DataModels.NestedBinXml.FromPointer); // 02466739DBF0 0x128 PrevNameInfo                ( 00018673FE00 ModelClassType NestedBinXml NestedBinXml NestedBinXml Pointer )
            value.TextXmlReader                             = GetObject<XmlReader>(new IntPtr(p + 0x130), ReversePrism.DataModels.XmlReader.FromPointer); // 02466739DC10 0x130 TextXmlReader               ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.CloseInput                                = GetBool(new IntPtr(p + 0x138)); // 02466739DC30 0x138 CloseInput                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CheckCharacters                           = GetBool(new IntPtr(p + 0x139)); // 02466739DC50 0x139 CheckCharacters             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreWhitespace                          = GetBool(new IntPtr(p + 0x13A)); // 02466739DC70 0x13A IgnoreWhitespace            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnorePIs                                 = GetBool(new IntPtr(p + 0x13B)); // 02466739DC90 0x13B IgnorePIs                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IgnoreComments                            = GetBool(new IntPtr(p + 0x13C)); // 02466739DCB0 0x13C IgnoreComments              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DtdProcessing                             = (DtdProcessing)GetInt32(new IntPtr(p + 0x140)); // 02466739DCD0 0x140 DtdProcessing               ( 000186708FB0 ModelEnumType DtdProcessing DtdProcessing DtdProcessing Int32 )
            value.Hasher                                    = GetObject<SecureStringHasher>(new IntPtr(p + 0x148), ReversePrism.DataModels.SecureStringHasher.FromPointer); // 02466739DCF0 0x148 Hasher                      ( 000186710590 ModelClassType SecureStringHasher SecureStringHasher SecureStringHasher Pointer )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x150)); // 02466739DD10 0x150 XmlCharType                 ( 00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.Unicode                                   = GetObject<Encoding>(new IntPtr(p + 0x158), ReversePrism.DataModels.Encoding.FromPointer); // 02466739DD30 0x158 Unicode                     ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.Version                                   = GetSByte(new IntPtr(p + 0x160)); // 02466739DD50 0x160 Version                     ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}

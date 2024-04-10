using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 S_XDR_Root_Element                       int[] IL2CPP_TYPE_SZARRAY
    // 008 S_XDR_Root_SubElements                   int[] IL2CPP_TYPE_SZARRAY
    // 010 S_XDR_ElementType_SubElements            000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 S_XDR_AttributeType_SubElements          000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 S_XDR_Group_SubElements                  000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 S_XDR_Root_Attributes                    000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer
    // 030 S_XDR_ElementType_Attributes             000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer
    // 038 S_XDR_AttributeType_Attributes           000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer
    // 040 S_XDR_Element_Attributes                 000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer
    // 048 S_XDR_Attribute_Attributes               000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer
    // 050 S_XDR_Group_Attributes                   000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer
    // 058 S_XDR_ElementDataType_Attributes         000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer
    // 060 S_XDR_AttributeDataType_Attributes       000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer
    // 068 S_SchemaEntries                          000185CC6588 ModelClassListType XdrEntry[] XdrEntry[] List<XdrEntry> Pointer
    // 010 SchemaInfo                               0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 018 TargetNamespace                          000186671910 ModelPrimitiveType string string string String
    // 020 Reader                                   0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer
    // 028 PositionInfo                             000186768940 ModelClassType PositionInfo PositionInfo PositionInfo Pointer
    // 030 ContentValidator                         000186723260 ModelClassType ParticleContentValidator ParticleContentValidator ParticleContentValidator Pointer
    // 038 CurState                                 000186727970 ModelClassType XdrEntry XdrEntry XdrEntry Pointer
    // 040 NextState                                000186727970 ModelClassType XdrEntry XdrEntry XdrEntry Pointer
    // 048 StateHistory                             0001866A4660 ModelClassType HWStack HWStack HWStack Pointer
    // 050 GroupStack                               0001866A4660 ModelClassType HWStack HWStack HWStack Pointer
    // 058 XdrName                                  000186671910 ModelPrimitiveType string string string String
    // 060 XdrPrefix                                000186671910 ModelPrimitiveType string string string String
    // 068 ElementDef                               000186726120 ModelClassType ElementContent ElementContent ElementContent Pointer
    // 070 GroupDef                                 000186726600 ModelClassType GroupContent GroupContent GroupContent Pointer
    // 078 AttributeDef                             0001867254D0 ModelClassType AttributeContent AttributeContent AttributeContent Pointer
    // 080 UndefinedAttributeTypes                  0001867259A0 ModelClassType DeclBaseInfo DeclBaseInfo DeclBaseInfo Pointer
    // 088 BaseDecl                                 0001867259A0 ModelClassType DeclBaseInfo DeclBaseInfo DeclBaseInfo Pointer
    // 090 NameTable                                0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer
    // 098 SchemaNames                              0001866EA5B0 ModelClassType SchemaNames SchemaNames SchemaNames Pointer
    // 0A0 CurNsMgr                                 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer
    // 0A8 Text                                     000186671910 ModelPrimitiveType string string string String
    // 0B0 ValidationEventHandler                   000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer
    // 0B8 UndeclaredElements                       0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 0C0 XmlResolver                              0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer
    public partial class XdrBuilder : DataModel
    {
        public List<int>?                               S_XDR_ElementType_SubElements           { get; set; }
        public List<int>?                               S_XDR_AttributeType_SubElements         { get; set; }
        public List<int>?                               S_XDR_Group_SubElements                 { get; set; }
        public List<XdrAttributeEntry>?                 S_XDR_Root_Attributes                   { get; set; }
        public List<XdrAttributeEntry>?                 S_XDR_ElementType_Attributes            { get; set; }
        public List<XdrAttributeEntry>?                 S_XDR_AttributeType_Attributes          { get; set; }
        public List<XdrAttributeEntry>?                 S_XDR_Element_Attributes                { get; set; }
        public List<XdrAttributeEntry>?                 S_XDR_Attribute_Attributes              { get; set; }
        public List<XdrAttributeEntry>?                 S_XDR_Group_Attributes                  { get; set; }
        public List<XdrAttributeEntry>?                 S_XDR_ElementDataType_Attributes        { get; set; }
        public List<XdrAttributeEntry>?                 S_XDR_AttributeDataType_Attributes      { get; set; }
        public List<XdrEntry>?                          S_SchemaEntries                         { get; set; }
        public SchemaInfo?                              SchemaInfo                              { get; set; }
        public string                                   TargetNamespace                         { get; set; }
        public XmlReader?                               Reader                                  { get; set; }
        public PositionInfo?                            PositionInfo                            { get; set; }
        public ParticleContentValidator?                ContentValidator                        { get; set; }
        public XdrEntry?                                CurState                                { get; set; }
        public XdrEntry?                                NextState                               { get; set; }
        public HWStack?                                 StateHistory                            { get; set; }
        public HWStack?                                 GroupStack                              { get; set; }
        public string                                   XdrName                                 { get; set; }
        public string                                   XdrPrefix                               { get; set; }
        public ElementContent?                          ElementDef                              { get; set; }
        public GroupContent?                            GroupDef                                { get; set; }
        public AttributeContent?                        AttributeDef                            { get; set; }
        public DeclBaseInfo?                            UndefinedAttributeTypes                 { get; set; }
        public DeclBaseInfo?                            BaseDecl                                { get; set; }
        public XmlNameTable?                            NameTable                               { get; set; }
        public SchemaNames?                             SchemaNames                             { get; set; }
        public XmlNamespaceManager?                     CurNsMgr                                { get; set; }
        public string                                   Text                                    { get; set; }
        public ValidationEventHandler?                  ValidationEventHandler                  { get; set; }
        public Hashtable?                               UndeclaredElements                      { get; set; }
        public XmlResolver?                             XmlResolver                             { get; set; }

        public static XdrBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XdrBuilder() { Pointer= p0 };

            value.S_XDR_ElementType_SubElements             = GetInt32List(new IntPtr(p + 0x010)); // 0246675FCB98 0x10 S_XDR_ElementType_SubElements ( 000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.S_XDR_AttributeType_SubElements           = GetInt32List(new IntPtr(p + 0x018)); // 0246675FCBB8 0x18 S_XDR_AttributeType_SubElements ( 000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.S_XDR_Group_SubElements                   = GetInt32List(new IntPtr(p + 0x020)); // 0246675FCBD8 0x20 S_XDR_Group_SubElements     ( 000185B7DCD0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.S_XDR_Root_Attributes                     = GetObjectList<XdrAttributeEntry>(new IntPtr(p + 0x028), ReversePrism.DataModels.XdrAttributeEntry.FromPointer); // 0246675FCBF8 0x28 S_XDR_Root_Attributes       ( 000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer )
            value.S_XDR_ElementType_Attributes              = GetObjectList<XdrAttributeEntry>(new IntPtr(p + 0x030), ReversePrism.DataModels.XdrAttributeEntry.FromPointer); // 0246675FCC18 0x30 S_XDR_ElementType_Attributes ( 000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer )
            value.S_XDR_AttributeType_Attributes            = GetObjectList<XdrAttributeEntry>(new IntPtr(p + 0x038), ReversePrism.DataModels.XdrAttributeEntry.FromPointer); // 0246675FCC38 0x38 S_XDR_AttributeType_Attributes ( 000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer )
            value.S_XDR_Element_Attributes                  = GetObjectList<XdrAttributeEntry>(new IntPtr(p + 0x040), ReversePrism.DataModels.XdrAttributeEntry.FromPointer); // 0246675FCC58 0x40 S_XDR_Element_Attributes    ( 000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer )
            value.S_XDR_Attribute_Attributes                = GetObjectList<XdrAttributeEntry>(new IntPtr(p + 0x048), ReversePrism.DataModels.XdrAttributeEntry.FromPointer); // 0246675FCC78 0x48 S_XDR_Attribute_Attributes  ( 000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer )
            value.S_XDR_Group_Attributes                    = GetObjectList<XdrAttributeEntry>(new IntPtr(p + 0x050), ReversePrism.DataModels.XdrAttributeEntry.FromPointer); // 0246675FCC98 0x50 S_XDR_Group_Attributes      ( 000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer )
            value.S_XDR_ElementDataType_Attributes          = GetObjectList<XdrAttributeEntry>(new IntPtr(p + 0x058), ReversePrism.DataModels.XdrAttributeEntry.FromPointer); // 0246675FCCB8 0x58 S_XDR_ElementDataType_Attributes ( 000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer )
            value.S_XDR_AttributeDataType_Attributes        = GetObjectList<XdrAttributeEntry>(new IntPtr(p + 0x060), ReversePrism.DataModels.XdrAttributeEntry.FromPointer); // 0246675FCCD8 0x60 S_XDR_AttributeDataType_Attributes ( 000185CC6488 ModelClassListType XdrAttributeEntry[] XdrAttributeEntry[] List<XdrAttributeEntry> Pointer )
            value.S_SchemaEntries                           = GetObjectList<XdrEntry>(new IntPtr(p + 0x068), ReversePrism.DataModels.XdrEntry.FromPointer); // 0246675FCCF8 0x68 S_SchemaEntries             ( 000185CC6588 ModelClassListType XdrEntry[] XdrEntry[] List<XdrEntry> Pointer )
            value.SchemaInfo                                = GetObject<SchemaInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.SchemaInfo.FromPointer); // 0246675FCD18 0x10 SchemaInfo                  ( 0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.TargetNamespace                           = GetString(new IntPtr(p + 0x018)); // 0246675FCD38 0x18 TargetNamespace             ( 000186671910 ModelPrimitiveType string string string String )
            value.Reader                                    = GetObject<XmlReader>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlReader.FromPointer); // 0246675FCD58 0x20 Reader                      ( 0001865A9BB0 ModelClassType XmlReader XmlReader XmlReader Pointer )
            value.PositionInfo                              = GetObject<PositionInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.PositionInfo.FromPointer); // 0246675FCD78 0x28 PositionInfo                ( 000186768940 ModelClassType PositionInfo PositionInfo PositionInfo Pointer )
            value.ContentValidator                          = GetObject<ParticleContentValidator>(new IntPtr(p + 0x030), ReversePrism.DataModels.ParticleContentValidator.FromPointer); // 0246675FCD98 0x30 ContentValidator            ( 000186723260 ModelClassType ParticleContentValidator ParticleContentValidator ParticleContentValidator Pointer )
            value.CurState                                  = GetObject<XdrEntry>(new IntPtr(p + 0x038), ReversePrism.DataModels.XdrEntry.FromPointer); // 0246675FCDB8 0x38 CurState                    ( 000186727970 ModelClassType XdrEntry XdrEntry XdrEntry Pointer )
            value.NextState                                 = GetObject<XdrEntry>(new IntPtr(p + 0x040), ReversePrism.DataModels.XdrEntry.FromPointer); // 0246675FCDD8 0x40 NextState                   ( 000186727970 ModelClassType XdrEntry XdrEntry XdrEntry Pointer )
            value.StateHistory                              = GetObject<HWStack>(new IntPtr(p + 0x048), ReversePrism.DataModels.HWStack.FromPointer); // 0246675FCDF8 0x48 StateHistory                ( 0001866A4660 ModelClassType HWStack HWStack HWStack Pointer )
            value.GroupStack                                = GetObject<HWStack>(new IntPtr(p + 0x050), ReversePrism.DataModels.HWStack.FromPointer); // 0246675FCE18 0x50 GroupStack                  ( 0001866A4660 ModelClassType HWStack HWStack HWStack Pointer )
            value.XdrName                                   = GetString(new IntPtr(p + 0x058)); // 0246675FCE38 0x58 XdrName                     ( 000186671910 ModelPrimitiveType string string string String )
            value.XdrPrefix                                 = GetString(new IntPtr(p + 0x060)); // 0246675FCE58 0x60 XdrPrefix                   ( 000186671910 ModelPrimitiveType string string string String )
            value.ElementDef                                = GetObject<ElementContent>(new IntPtr(p + 0x068), ReversePrism.DataModels.ElementContent.FromPointer); // 0246675FCE78 0x68 ElementDef                  ( 000186726120 ModelClassType ElementContent ElementContent ElementContent Pointer )
            value.GroupDef                                  = GetObject<GroupContent>(new IntPtr(p + 0x070), ReversePrism.DataModels.GroupContent.FromPointer); // 0246675FCE98 0x70 GroupDef                    ( 000186726600 ModelClassType GroupContent GroupContent GroupContent Pointer )
            value.AttributeDef                              = GetObject<AttributeContent>(new IntPtr(p + 0x078), ReversePrism.DataModels.AttributeContent.FromPointer); // 0246675FCEB8 0x78 AttributeDef                ( 0001867254D0 ModelClassType AttributeContent AttributeContent AttributeContent Pointer )
            value.UndefinedAttributeTypes                   = GetObject<DeclBaseInfo>(new IntPtr(p + 0x080), ReversePrism.DataModels.DeclBaseInfo.FromPointer); // 0246675FCED8 0x80 UndefinedAttributeTypes     ( 0001867259A0 ModelClassType DeclBaseInfo DeclBaseInfo DeclBaseInfo Pointer )
            value.BaseDecl                                  = GetObject<DeclBaseInfo>(new IntPtr(p + 0x088), ReversePrism.DataModels.DeclBaseInfo.FromPointer); // 0246675FCEF8 0x88 BaseDecl                    ( 0001867259A0 ModelClassType DeclBaseInfo DeclBaseInfo DeclBaseInfo Pointer )
            value.NameTable                                 = GetObject<XmlNameTable>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlNameTable.FromPointer); // 0246675FCF18 0x90 NameTable                   ( 0001865A0930 ModelClassType XmlNameTable XmlNameTable XmlNameTable Pointer )
            value.SchemaNames                               = GetObject<SchemaNames>(new IntPtr(p + 0x098), ReversePrism.DataModels.SchemaNames.FromPointer); // 0246675FCF38 0x98 SchemaNames                 ( 0001866EA5B0 ModelClassType SchemaNames SchemaNames SchemaNames Pointer )
            value.CurNsMgr                                  = GetObject<XmlNamespaceManager>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlNamespaceManager.FromPointer); // 0246675FCF58 0xA0 CurNsMgr                    ( 0001866BAB00 ModelClassType XmlNamespaceManager XmlNamespaceManager XmlNamespaceManager Pointer )
            value.Text                                      = GetString(new IntPtr(p + 0x0A8)); // 0246675FCF78 0xA8 Text                        ( 000186671910 ModelPrimitiveType string string string String )
            value.ValidationEventHandler                    = GetObject<ValidationEventHandler>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.ValidationEventHandler.FromPointer); // 0246675FCF98 0xB0 ValidationEventHandler      ( 000186765AD0 ModelClassType ValidationEventHandler ValidationEventHandler ValidationEventHandler Pointer )
            value.UndeclaredElements                        = GetObject<Hashtable>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Hashtable.FromPointer); // 0246675FCFB8 0xB8 UndeclaredElements          ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.XmlResolver                               = GetObject<XmlResolver>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.XmlResolver.FromPointer); // 0246675FCFD8 0xC0 XmlResolver                 ( 0001865ABBE0 ModelClassType XmlResolver XmlResolver XmlResolver Pointer )

            return value;
        }
    }
}

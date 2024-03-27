using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Writer                                   0001865D6BE0 ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 020 RawWriter                                0001865A8A90 ModelClassType XmlRawWriter XmlRawWriter XmlRawWriter Pointer
    // 028 PredefinedNamespaces                     0001866A07A0 ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    // 030 NsStack                                  000185CC9018 ModelEnumListType Namespace[] Namespace[] List<Namespace> Pointer
    // 038 NsTop                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 nsHashtable                              Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 048 UseNsHashtable                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 ElemScopeStack                           000185CC8E48 ModelEnumListType ElementScope[] ElementScope[] List<ElementScope> Pointer
    // 058 ElemTop                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 AttrStack                                000185CC8C68 ModelEnumListType AttrName[] AttrName[] List<AttrName> Pointer
    // 068 AttrCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 070 attrHashTable                            Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 078 SpecAttr                                 000186751F20 ModelEnumType SpecialAttribute SpecialAttribute SpecialAttribute Int32
    // 080 AttrValueCache                           000186750930 ModelClassType AttributeValueCache AttributeValueCache AttributeValueCache Pointer
    // 088 CurDeclPrefix                            000186671910 ModelPrimitiveType string string string String
    // 090 StateTable                               000185CC91F8 ModelEnumListType State[] State[] List<State> Pointer
    // 098 CurrentState                             0001867524F0 ModelEnumType State State State Int32
    // 09C CheckCharacters                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09D OmitDuplNamespaces                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09E WriteEndDocumentOnClose                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A0 ConformanceLevel                         000186600120 ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32
    // 0A4 DtdWritten                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A5 XmlDeclFollows                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A8 XmlCharType                              00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 0B0 Hasher                                   000186710590 ModelClassType SecureStringHasher SecureStringHasher SecureStringHasher Pointer
    // 000 stateName                                string[] IL2CPP_TYPE_SZARRAY
    // 008 tokenName                                string[] IL2CPP_TYPE_SZARRAY
    // 010 State2WriteState                         000185CB2A18 ModelEnumListType WriteState[] WriteState[] List<WriteState> Pointer
    // 018 StateTableDocument                       000185CC9348 ModelEnumListType State[] State[] List<State> Pointer
    // 020 StateTableAuto                           000185CC9348 ModelEnumListType State[] State[] List<State> Pointer
    public partial class XmlWellFormedWriter
    {
        public XmlWriter?                               Writer                                  { get; set; }
        public XmlRawWriter?                            RawWriter                               { get; set; }
        public IXmlNamespaceResolver?                   PredefinedNamespaces                    { get; set; }
        public List<Namespace>?                         NsStack                                 { get; set; }
        public int                                      NsTop                                   { get; set; }
        public bool                                     UseNsHashtable                          { get; set; }
        public List<ElementScope>?                      ElemScopeStack                          { get; set; }
        public int                                      ElemTop                                 { get; set; }
        public List<AttrName>?                          AttrStack                               { get; set; }
        public int                                      AttrCount                               { get; set; }
        public SpecialAttribute                         SpecAttr                                { get; set; }
        public AttributeValueCache?                     AttrValueCache                          { get; set; }
        public string                                   CurDeclPrefix                           { get; set; }
        public List<State>?                             StateTable                              { get; set; }
        public State                                    CurrentState                            { get; set; }
        public bool                                     CheckCharacters                         { get; set; }
        public bool                                     OmitDuplNamespaces                      { get; set; }
        public bool                                     WriteEndDocumentOnClose                 { get; set; }
        public ConformanceLevel                         ConformanceLevel                        { get; set; }
        public bool                                     DtdWritten                              { get; set; }
        public bool                                     XmlDeclFollows                          { get; set; }
        public XmlCharType                              XmlCharType                             { get; set; }
        public SecureStringHasher?                      Hasher                                  { get; set; }
        public List<WriteState>?                        State2WriteState                        { get; set; }
        public List<State>?                             StateTableDocument                      { get; set; }
        public List<State>?                             StateTableAuto                          { get; set; }

        public static XmlWellFormedWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlWellFormedWriter();

            value.Writer                                    = GetObject<XmlWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlWriter.FromPointer); // 0270D7407490 0x18 Writer                      ( 0001865D6BE0 ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.RawWriter                                 = GetObject<XmlRawWriter>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlRawWriter.FromPointer); // 0270D74074B0 0x20 RawWriter                   ( 0001865A8A90 ModelClassType XmlRawWriter XmlRawWriter XmlRawWriter Pointer )
            value.PredefinedNamespaces                      = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x028), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 0270D74074D0 0x28 PredefinedNamespaces        ( 0001866A07A0 ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )
            value.NsStack                                   = GetEnumList<Namespace>(new IntPtr(p + 0x030)); // 0270D74074F0 0x30 NsStack                     ( 000185CC9018 ModelEnumListType Namespace[] Namespace[] List<Namespace> Pointer )
            value.NsTop                                     = GetInt32(new IntPtr(p + 0x038)); // 0270D7407510 0x38 NsTop                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UseNsHashtable                            = GetBool(new IntPtr(p + 0x048)); // 0270D7407550 0x48 UseNsHashtable              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ElemScopeStack                            = GetEnumList<ElementScope>(new IntPtr(p + 0x050)); // 0270D7407570 0x50 ElemScopeStack              ( 000185CC8E48 ModelEnumListType ElementScope[] ElementScope[] List<ElementScope> Pointer )
            value.ElemTop                                   = GetInt32(new IntPtr(p + 0x058)); // 0270D7407590 0x58 ElemTop                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttrStack                                 = GetEnumList<AttrName>(new IntPtr(p + 0x060)); // 0270D74075B0 0x60 AttrStack                   ( 000185CC8C68 ModelEnumListType AttrName[] AttrName[] List<AttrName> Pointer )
            value.AttrCount                                 = GetInt32(new IntPtr(p + 0x068)); // 0270D74075D0 0x68 AttrCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SpecAttr                                  = (SpecialAttribute)GetInt32(new IntPtr(p + 0x078)); // 0270D7407610 0x78 SpecAttr                    ( 000186751F20 ModelEnumType SpecialAttribute SpecialAttribute SpecialAttribute Int32 )
            value.AttrValueCache                            = GetObject<AttributeValueCache>(new IntPtr(p + 0x080), ReversePrism.DataModels.AttributeValueCache.FromPointer); // 0270D7407630 0x80 AttrValueCache              ( 000186750930 ModelClassType AttributeValueCache AttributeValueCache AttributeValueCache Pointer )
            value.CurDeclPrefix                             = GetString(new IntPtr(p + 0x088)); // 0270D7407650 0x88 CurDeclPrefix               ( 000186671910 ModelPrimitiveType string string string String )
            value.StateTable                                = GetEnumList<State>(new IntPtr(p + 0x090)); // 0270D7407670 0x90 StateTable                  ( 000185CC91F8 ModelEnumListType State[] State[] List<State> Pointer )
            value.CurrentState                              = (State)GetInt32(new IntPtr(p + 0x098)); // 0270D7407690 0x98 CurrentState                ( 0001867524F0 ModelEnumType State State State Int32 )
            value.CheckCharacters                           = GetBool(new IntPtr(p + 0x09C)); // 0270D74076B0 0x9C CheckCharacters             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OmitDuplNamespaces                        = GetBool(new IntPtr(p + 0x09D)); // 0270D74076D0 0x9D OmitDuplNamespaces          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WriteEndDocumentOnClose                   = GetBool(new IntPtr(p + 0x09E)); // 0270D74076F0 0x9E WriteEndDocumentOnClose     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ConformanceLevel                          = (ConformanceLevel)GetInt32(new IntPtr(p + 0x0A0)); // 0270D7407710 0xA0 ConformanceLevel            ( 000186600120 ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32 )
            value.DtdWritten                                = GetBool(new IntPtr(p + 0x0A4)); // 0270D7407730 0xA4 DtdWritten                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.XmlDeclFollows                            = GetBool(new IntPtr(p + 0x0A5)); // 0270D7407750 0xA5 XmlDeclFollows              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x0A8)); // 0270D7407770 0xA8 XmlCharType                 ( 00018658F4B0 ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.Hasher                                    = GetObject<SecureStringHasher>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SecureStringHasher.FromPointer); // 0270D7407790 0xB0 Hasher                      ( 000186710590 ModelClassType SecureStringHasher SecureStringHasher SecureStringHasher Pointer )
            value.State2WriteState                          = GetEnumList<WriteState>(new IntPtr(p + 0x010)); // 0270D74077F0 0x10 State2WriteState            ( 000185CB2A18 ModelEnumListType WriteState[] WriteState[] List<WriteState> Pointer )
            value.StateTableDocument                        = GetEnumList<State>(new IntPtr(p + 0x018)); // 0270D7407810 0x18 StateTableDocument          ( 000185CC9348 ModelEnumListType State[] State[] List<State> Pointer )
            value.StateTableAuto                            = GetEnumList<State>(new IntPtr(p + 0x020)); // 0270D7407830 0x20 StateTableAuto              ( 000185CC9348 ModelEnumListType State[] State[] List<State> Pointer )

            return value;
        }
    }
}

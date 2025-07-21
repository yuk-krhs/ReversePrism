using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Writer                                   ModelClassType XmlWriter XmlWriter XmlWriter Pointer
    // 020 RawWriter                                ModelClassType XmlRawWriter XmlRawWriter XmlRawWriter Pointer
    // 028 PredefinedNamespaces                     ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer
    // 030 NsStack                                  ModelEnumListType Namespace[] Namespace[] List<Namespace> Pointer
    // 038 NsTop                                    ModelPrimitiveType int int int Int32
    // 040 nsHashtable                              Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 048 UseNsHashtable                           ModelPrimitiveType bool bool bool Bool
    // 050 ElemScopeStack                           ModelEnumListType ElementScope[] ElementScope[] List<ElementScope> Pointer
    // 058 ElemTop                                  ModelPrimitiveType int int int Int32
    // 060 AttrStack                                ModelEnumListType AttrName[] AttrName[] List<AttrName> Pointer
    // 068 AttrCount                                ModelPrimitiveType int int int Int32
    // 070 attrHashTable                            Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 078 SpecAttr                                 ModelEnumType SpecialAttribute SpecialAttribute SpecialAttribute Int32
    // 080 AttrValueCache                           ModelClassType AttributeValueCache AttributeValueCache AttributeValueCache Pointer
    // 088 CurDeclPrefix                            ModelPrimitiveType string string string String
    // 090 StateTable                               ModelEnumListType State[] State[] List<State> Pointer
    // 098 CurrentState                             ModelEnumType State State State Int32
    // 09C CheckCharacters                          ModelPrimitiveType bool bool bool Bool
    // 09D OmitDuplNamespaces                       ModelPrimitiveType bool bool bool Bool
    // 09E WriteEndDocumentOnClose                  ModelPrimitiveType bool bool bool Bool
    // 0A0 ConformanceLevel                         ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32
    // 0A4 DtdWritten                               ModelPrimitiveType bool bool bool Bool
    // 0A5 XmlDeclFollows                           ModelPrimitiveType bool bool bool Bool
    // 0A8 XmlCharType                              ModelEnumType XmlCharType XmlCharType XmlCharType Int32
    // 0B0 Hasher                                   ModelClassType SecureStringHasher SecureStringHasher SecureStringHasher Pointer
    // 000 stateName                                string[] IL2CPP_TYPE_SZARRAY
    // 008 tokenName                                string[] IL2CPP_TYPE_SZARRAY
    // 010 State2WriteState                         ModelEnumListType WriteState[] WriteState[] List<WriteState> Pointer
    // 018 StateTableDocument                       ModelEnumListType State[] State[] List<State> Pointer
    // 020 StateTableAuto                           ModelEnumListType State[] State[] List<State> Pointer
    public partial class XmlWellFormedWriter : DataModel
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
            var value   = new XmlWellFormedWriter() { Pointer= p0 };

            value.Writer                                    = GetObject<XmlWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlWriter.FromPointer); // 0x18 Writer                      ( ModelClassType XmlWriter XmlWriter XmlWriter Pointer )
            value.RawWriter                                 = GetObject<XmlRawWriter>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlRawWriter.FromPointer); // 0x20 RawWriter                   ( ModelClassType XmlRawWriter XmlRawWriter XmlRawWriter Pointer )
            value.PredefinedNamespaces                      = GetObject<IXmlNamespaceResolver>(new IntPtr(p + 0x028), ReversePrism.DataModels.IXmlNamespaceResolver.FromPointer); // 0x28 PredefinedNamespaces        ( ModelClassType IXmlNamespaceResolver IXmlNamespaceResolver IXmlNamespaceResolver Pointer )
            value.NsStack                                   = GetEnumList<Namespace>(new IntPtr(p + 0x030)); // 0x30 NsStack                     ( ModelEnumListType Namespace[] Namespace[] List<Namespace> Pointer )
            value.NsTop                                     = GetInt32(new IntPtr(p + 0x038)); // 0x38 NsTop                       ( ModelPrimitiveType int int int Int32 )
            value.UseNsHashtable                            = GetBool(new IntPtr(p + 0x048)); // 0x48 UseNsHashtable              ( ModelPrimitiveType bool bool bool Bool )
            value.ElemScopeStack                            = GetEnumList<ElementScope>(new IntPtr(p + 0x050)); // 0x50 ElemScopeStack              ( ModelEnumListType ElementScope[] ElementScope[] List<ElementScope> Pointer )
            value.ElemTop                                   = GetInt32(new IntPtr(p + 0x058)); // 0x58 ElemTop                     ( ModelPrimitiveType int int int Int32 )
            value.AttrStack                                 = GetEnumList<AttrName>(new IntPtr(p + 0x060)); // 0x60 AttrStack                   ( ModelEnumListType AttrName[] AttrName[] List<AttrName> Pointer )
            value.AttrCount                                 = GetInt32(new IntPtr(p + 0x068)); // 0x68 AttrCount                   ( ModelPrimitiveType int int int Int32 )
            value.SpecAttr                                  = (SpecialAttribute)GetInt32(new IntPtr(p + 0x078)); // 0x78 SpecAttr                    ( ModelEnumType SpecialAttribute SpecialAttribute SpecialAttribute Int32 )
            value.AttrValueCache                            = GetObject<AttributeValueCache>(new IntPtr(p + 0x080), ReversePrism.DataModels.AttributeValueCache.FromPointer); // 0x80 AttrValueCache              ( ModelClassType AttributeValueCache AttributeValueCache AttributeValueCache Pointer )
            value.CurDeclPrefix                             = GetString(new IntPtr(p + 0x088)); // 0x88 CurDeclPrefix               ( ModelPrimitiveType string string string String )
            value.StateTable                                = GetEnumList<State>(new IntPtr(p + 0x090)); // 0x90 StateTable                  ( ModelEnumListType State[] State[] List<State> Pointer )
            value.CurrentState                              = (State)GetInt32(new IntPtr(p + 0x098)); // 0x98 CurrentState                ( ModelEnumType State State State Int32 )
            value.CheckCharacters                           = GetBool(new IntPtr(p + 0x09C)); // 0x9C CheckCharacters             ( ModelPrimitiveType bool bool bool Bool )
            value.OmitDuplNamespaces                        = GetBool(new IntPtr(p + 0x09D)); // 0x9D OmitDuplNamespaces          ( ModelPrimitiveType bool bool bool Bool )
            value.WriteEndDocumentOnClose                   = GetBool(new IntPtr(p + 0x09E)); // 0x9E WriteEndDocumentOnClose     ( ModelPrimitiveType bool bool bool Bool )
            value.ConformanceLevel                          = (ConformanceLevel)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 ConformanceLevel            ( ModelEnumType ConformanceLevel ConformanceLevel ConformanceLevel Int32 )
            value.DtdWritten                                = GetBool(new IntPtr(p + 0x0A4)); // 0xA4 DtdWritten                  ( ModelPrimitiveType bool bool bool Bool )
            value.XmlDeclFollows                            = GetBool(new IntPtr(p + 0x0A5)); // 0xA5 XmlDeclFollows              ( ModelPrimitiveType bool bool bool Bool )
            value.XmlCharType                               = (XmlCharType)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 XmlCharType                 ( ModelEnumType XmlCharType XmlCharType XmlCharType Int32 )
            value.Hasher                                    = GetObject<SecureStringHasher>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SecureStringHasher.FromPointer); // 0xB0 Hasher                      ( ModelClassType SecureStringHasher SecureStringHasher SecureStringHasher Pointer )
            value.State2WriteState                          = GetEnumList<WriteState>(new IntPtr(p + 0x010)); // 0x10 State2WriteState            ( ModelEnumListType WriteState[] WriteState[] List<WriteState> Pointer )
            value.StateTableDocument                        = GetEnumList<State>(new IntPtr(p + 0x018)); // 0x18 StateTableDocument          ( ModelEnumListType State[] State[] List<State> Pointer )
            value.StateTableAuto                            = GetEnumList<State>(new IntPtr(p + 0x020)); // 0x20 StateTableAuto              ( ModelEnumListType State[] State[] List<State> Pointer )

            return value;
        }
    }
}

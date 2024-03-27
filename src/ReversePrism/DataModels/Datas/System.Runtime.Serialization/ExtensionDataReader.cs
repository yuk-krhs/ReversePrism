using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cache                                    0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 Elements                                 000185B7AF30 ModelClassListType ElementData[] ElementData[] List<ElementData> Pointer
    // 020 Element                                  000186722AB0 ModelClassType ElementData ElementData ElementData Pointer
    // 028 NextElement                              000186722AB0 ModelClassType ElementData ElementData ElementData Pointer
    // 030 ReadState                                00018661DEC0 ModelEnumType ReadState ReadState ReadState Int32
    // 034 InternalNodeType                         0001866705C0 ModelEnumType ExtensionDataNodeType ExtensionDataNodeType ExtensionDataNodeType Int32
    // 038 NodeType                                 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 03C Depth                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 LocalName                                000186671910 ModelPrimitiveType string string string String
    // 048 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 050 Prefix                                   000186671910 ModelPrimitiveType string string string String
    // 058 Value                                    000186671910 ModelPrimitiveType string string string String
    // 060 AttributeCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 AttributeIndex                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 XmlNodeReader                            0001865A3530 ModelClassType XmlNodeReader XmlNodeReader XmlNodeReader Pointer
    // 070 deserializedDataNodes                    Queue`1<IDataNode> IL2CPP_TYPE_GENERICINST
    // 078 Context                                  0001865A5E80 ModelClassType XmlObjectSerializerReadContext XmlObjectSerializerReadContext XmlObjectSerializerReadContext Pointer
    // 000 nsToPrefixTable                          Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 008 prefixToNsTable                          Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class ExtensionDataReader
    {
        public Hashtable?                               Cache                                   { get; set; }
        public List<ElementData>?                       Elements                                { get; set; }
        public ElementData?                             Element                                 { get; set; }
        public ElementData?                             NextElement                             { get; set; }
        public ReadState                                ReadState                               { get; set; }
        public ExtensionDataNodeType                    InternalNodeType                        { get; set; }
        public XmlNodeType                              NodeType                                { get; set; }
        public int                                      Depth                                   { get; set; }
        public string                                   LocalName                               { get; set; }
        public string                                   Ns                                      { get; set; }
        public string                                   Prefix                                  { get; set; }
        public string                                   Value                                   { get; set; }
        public int                                      AttributeCount                          { get; set; }
        public int                                      AttributeIndex                          { get; set; }
        public XmlNodeReader?                           XmlNodeReader                           { get; set; }
        public XmlObjectSerializerReadContext?          Context                                 { get; set; }

        public static ExtensionDataReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtensionDataReader();

            value.Cache                                     = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0270D7D3A568 0x10 Cache                       ( 0001865DE360 ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Elements                                  = GetObjectList<ElementData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ElementData.FromPointer); // 0270D7D3A588 0x18 Elements                    ( 000185B7AF30 ModelClassListType ElementData[] ElementData[] List<ElementData> Pointer )
            value.Element                                   = GetObject<ElementData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ElementData.FromPointer); // 0270D7D3A5A8 0x20 Element                     ( 000186722AB0 ModelClassType ElementData ElementData ElementData Pointer )
            value.NextElement                               = GetObject<ElementData>(new IntPtr(p + 0x028), ReversePrism.DataModels.ElementData.FromPointer); // 0270D7D3A5C8 0x28 NextElement                 ( 000186722AB0 ModelClassType ElementData ElementData ElementData Pointer )
            value.ReadState                                 = (ReadState)GetInt32(new IntPtr(p + 0x030)); // 0270D7D3A5E8 0x30 ReadState                   ( 00018661DEC0 ModelEnumType ReadState ReadState ReadState Int32 )
            value.InternalNodeType                          = (ExtensionDataNodeType)GetInt32(new IntPtr(p + 0x034)); // 0270D7D3A608 0x34 InternalNodeType            ( 0001866705C0 ModelEnumType ExtensionDataNodeType ExtensionDataNodeType ExtensionDataNodeType Int32 )
            value.NodeType                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x038)); // 0270D7D3A628 0x38 NodeType                    ( 0001866BBCE0 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x03C)); // 0270D7D3A648 0x3C Depth                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LocalName                                 = GetString(new IntPtr(p + 0x040)); // 0270D7D3A668 0x40 LocalName                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x048)); // 0270D7D3A688 0x48 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x050)); // 0270D7D3A6A8 0x50 Prefix                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x058)); // 0270D7D3A6C8 0x58 Value                       ( 000186671910 ModelPrimitiveType string string string String )
            value.AttributeCount                            = GetInt32(new IntPtr(p + 0x060)); // 0270D7D3A6E8 0x60 AttributeCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttributeIndex                            = GetInt32(new IntPtr(p + 0x064)); // 0270D7D3A708 0x64 AttributeIndex              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.XmlNodeReader                             = GetObject<XmlNodeReader>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlNodeReader.FromPointer); // 0270D7D3A728 0x68 XmlNodeReader               ( 0001865A3530 ModelClassType XmlNodeReader XmlNodeReader XmlNodeReader Pointer )
            value.Context                                   = GetObject<XmlObjectSerializerReadContext>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlObjectSerializerReadContext.FromPointer); // 0270D7D3A768 0x78 Context                     ( 0001865A5E80 ModelClassType XmlObjectSerializerReadContext XmlObjectSerializerReadContext XmlObjectSerializerReadContext Pointer )

            return value;
        }
    }
}

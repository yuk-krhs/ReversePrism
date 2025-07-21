using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Cache                                    ModelClassType Hashtable Hashtable Hashtable Pointer
    // 018 Elements                                 ModelClassListType ElementData[] ElementData[] List<ElementData> Pointer
    // 020 Element                                  ModelClassType ElementData ElementData ElementData Pointer
    // 028 NextElement                              ModelClassType ElementData ElementData ElementData Pointer
    // 030 ReadState                                ModelEnumType ReadState ReadState ReadState Int32
    // 034 InternalNodeType                         ModelEnumType ExtensionDataNodeType ExtensionDataNodeType ExtensionDataNodeType Int32
    // 038 NodeType                                 ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32
    // 03C Depth                                    ModelPrimitiveType int int int Int32
    // 040 LocalName                                ModelPrimitiveType string string string String
    // 048 Ns                                       ModelPrimitiveType string string string String
    // 050 Prefix                                   ModelPrimitiveType string string string String
    // 058 Value                                    ModelPrimitiveType string string string String
    // 060 AttributeCount                           ModelPrimitiveType int int int Int32
    // 064 AttributeIndex                           ModelPrimitiveType int int int Int32
    // 068 XmlNodeReader                            ModelClassType XmlNodeReader XmlNodeReader XmlNodeReader Pointer
    // 070 deserializedDataNodes                    Queue`1<IDataNode> IL2CPP_TYPE_GENERICINST
    // 078 Context                                  ModelClassType XmlObjectSerializerReadContext XmlObjectSerializerReadContext XmlObjectSerializerReadContext Pointer
    // 000 nsToPrefixTable                          Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 008 prefixToNsTable                          Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class ExtensionDataReader : DataModel
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
            var value   = new ExtensionDataReader() { Pointer= p0 };

            value.Cache                                     = GetObject<Hashtable>(new IntPtr(p + 0x010), ReversePrism.DataModels.Hashtable.FromPointer); // 0x10 Cache                       ( ModelClassType Hashtable Hashtable Hashtable Pointer )
            value.Elements                                  = GetObjectList<ElementData>(new IntPtr(p + 0x018), ReversePrism.DataModels.ElementData.FromPointer); // 0x18 Elements                    ( ModelClassListType ElementData[] ElementData[] List<ElementData> Pointer )
            value.Element                                   = GetObject<ElementData>(new IntPtr(p + 0x020), ReversePrism.DataModels.ElementData.FromPointer); // 0x20 Element                     ( ModelClassType ElementData ElementData ElementData Pointer )
            value.NextElement                               = GetObject<ElementData>(new IntPtr(p + 0x028), ReversePrism.DataModels.ElementData.FromPointer); // 0x28 NextElement                 ( ModelClassType ElementData ElementData ElementData Pointer )
            value.ReadState                                 = (ReadState)GetInt32(new IntPtr(p + 0x030)); // 0x30 ReadState                   ( ModelEnumType ReadState ReadState ReadState Int32 )
            value.InternalNodeType                          = (ExtensionDataNodeType)GetInt32(new IntPtr(p + 0x034)); // 0x34 InternalNodeType            ( ModelEnumType ExtensionDataNodeType ExtensionDataNodeType ExtensionDataNodeType Int32 )
            value.NodeType                                  = (XmlNodeType)GetInt32(new IntPtr(p + 0x038)); // 0x38 NodeType                    ( ModelEnumType XmlNodeType XmlNodeType XmlNodeType Int32 )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x03C)); // 0x3C Depth                       ( ModelPrimitiveType int int int Int32 )
            value.LocalName                                 = GetString(new IntPtr(p + 0x040)); // 0x40 LocalName                   ( ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x048)); // 0x48 Ns                          ( ModelPrimitiveType string string string String )
            value.Prefix                                    = GetString(new IntPtr(p + 0x050)); // 0x50 Prefix                      ( ModelPrimitiveType string string string String )
            value.Value                                     = GetString(new IntPtr(p + 0x058)); // 0x58 Value                       ( ModelPrimitiveType string string string String )
            value.AttributeCount                            = GetInt32(new IntPtr(p + 0x060)); // 0x60 AttributeCount              ( ModelPrimitiveType int int int Int32 )
            value.AttributeIndex                            = GetInt32(new IntPtr(p + 0x064)); // 0x64 AttributeIndex              ( ModelPrimitiveType int int int Int32 )
            value.XmlNodeReader                             = GetObject<XmlNodeReader>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlNodeReader.FromPointer); // 0x68 XmlNodeReader               ( ModelClassType XmlNodeReader XmlNodeReader XmlNodeReader Pointer )
            value.Context                                   = GetObject<XmlObjectSerializerReadContext>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlObjectSerializerReadContext.FromPointer); // 0x78 Context                     ( ModelClassType XmlObjectSerializerReadContext XmlObjectSerializerReadContext XmlObjectSerializerReadContext Pointer )

            return value;
        }
    }
}

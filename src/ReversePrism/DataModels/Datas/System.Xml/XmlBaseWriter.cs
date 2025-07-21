using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Writer                                   ModelClassType XmlNodeWriter XmlNodeWriter XmlNodeWriter Pointer
    // 020 NsMgr                                    ModelClassType NamespaceManager NamespaceManager NamespaceManager Pointer
    // 028 Elements                                 ModelClassListType Element[] Element[] List<Element> Pointer
    // 030 Depth                                    ModelPrimitiveType int int int Int32
    // 038 AttributeLocalName                       ModelPrimitiveType string string string String
    // 040 AttributeValue                           ModelPrimitiveType string string string String
    // 048 IsXmlAttribute                           ModelPrimitiveType bool bool bool Bool
    // 049 IsXmlnsAttribute                         ModelPrimitiveType bool bool bool Bool
    // 04C WriteState                               ModelEnumType WriteState WriteState WriteState Int32
    // 050 DocumentState                            ModelEnumType DocumentState DocumentState DocumentState Int32
    // 058 TrailBytes                               ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 060 TrailByteCount                           ModelPrimitiveType int int int Int32
    // 068 NodeWriter                               ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer
    // 070 SigningWriter                            ModelClassType XmlSigningNodeWriter XmlSigningNodeWriter XmlSigningNodeWriter Pointer
    // 078 TextFragmentWriter                       ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer
    // 080 OldWriter                                ModelClassType XmlNodeWriter XmlNodeWriter XmlNodeWriter Pointer
    // 088 OldStream                                ModelClassType Stream Stream Stream Pointer
    // 090 OldNamespaceBoundary                     ModelPrimitiveType int int int Int32
    // 094 InList                                   ModelPrimitiveType bool bool bool Bool
    // 000 xmlnsNamespace                           string IL2CPP_TYPE_STRING
    // 000 xmlNamespace                             string IL2CPP_TYPE_STRING
    // 000 binhexEncoding                           BinHexEncoding IL2CPP_TYPE_CLASS
    // 008 prefixes                                 string[] IL2CPP_TYPE_SZARRAY
    // 098 NodeWriterAsyncHelper                    ModelClassType XmlBaseWriterNodeWriterAsyncHelper XmlBaseWriterNodeWriterAsyncHelper XmlBaseWriterNodeWriterAsyncHelper Pointer
    public partial class XmlBaseWriter : DataModel
    {
        public XmlNodeWriter?                           Writer                                  { get; set; }
        public NamespaceManager?                        NsMgr                                   { get; set; }
        public List<Element>?                           Elements                                { get; set; }
        public int                                      Depth                                   { get; set; }
        public string                                   AttributeLocalName                      { get; set; }
        public string                                   AttributeValue                          { get; set; }
        public bool                                     IsXmlAttribute                          { get; set; }
        public bool                                     IsXmlnsAttribute                        { get; set; }
        public WriteState                               WriteState                              { get; set; }
        public DocumentState                            DocumentState                           { get; set; }
        public List<sbyte>?                             TrailBytes                              { get; set; }
        public int                                      TrailByteCount                          { get; set; }
        public XmlStreamNodeWriter?                     NodeWriter                              { get; set; }
        public XmlSigningNodeWriter?                    SigningWriter                           { get; set; }
        public XmlUTF8NodeWriter?                       TextFragmentWriter                      { get; set; }
        public XmlNodeWriter?                           OldWriter                               { get; set; }
        public Stream?                                  OldStream                               { get; set; }
        public int                                      OldNamespaceBoundary                    { get; set; }
        public bool                                     InList                                  { get; set; }
        public XmlBaseWriterNodeWriterAsyncHelper?      NodeWriterAsyncHelper                   { get; set; }

        public static XmlBaseWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlBaseWriter() { Pointer= p0 };

            value.Writer                                    = GetObject<XmlNodeWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNodeWriter.FromPointer); // 0x18 Writer                      ( ModelClassType XmlNodeWriter XmlNodeWriter XmlNodeWriter Pointer )
            value.NsMgr                                     = GetObject<NamespaceManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.NamespaceManager.FromPointer); // 0x20 NsMgr                       ( ModelClassType NamespaceManager NamespaceManager NamespaceManager Pointer )
            value.Elements                                  = GetObjectList<Element>(new IntPtr(p + 0x028), ReversePrism.DataModels.Element.FromPointer); // 0x28 Elements                    ( ModelClassListType Element[] Element[] List<Element> Pointer )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x030)); // 0x30 Depth                       ( ModelPrimitiveType int int int Int32 )
            value.AttributeLocalName                        = GetString(new IntPtr(p + 0x038)); // 0x38 AttributeLocalName          ( ModelPrimitiveType string string string String )
            value.AttributeValue                            = GetString(new IntPtr(p + 0x040)); // 0x40 AttributeValue              ( ModelPrimitiveType string string string String )
            value.IsXmlAttribute                            = GetBool(new IntPtr(p + 0x048)); // 0x48 IsXmlAttribute              ( ModelPrimitiveType bool bool bool Bool )
            value.IsXmlnsAttribute                          = GetBool(new IntPtr(p + 0x049)); // 0x49 IsXmlnsAttribute            ( ModelPrimitiveType bool bool bool Bool )
            value.WriteState                                = (WriteState)GetInt32(new IntPtr(p + 0x04C)); // 0x4C WriteState                  ( ModelEnumType WriteState WriteState WriteState Int32 )
            value.DocumentState                             = (DocumentState)GetInt32(new IntPtr(p + 0x050)); // 0x50 DocumentState               ( ModelEnumType DocumentState DocumentState DocumentState Int32 )
            value.TrailBytes                                = GetSByteList(new IntPtr(p + 0x058)); // 0x58 TrailBytes                  ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.TrailByteCount                            = GetInt32(new IntPtr(p + 0x060)); // 0x60 TrailByteCount              ( ModelPrimitiveType int int int Int32 )
            value.NodeWriter                                = GetObject<XmlStreamNodeWriter>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlStreamNodeWriter.FromPointer); // 0x68 NodeWriter                  ( ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer )
            value.SigningWriter                             = GetObject<XmlSigningNodeWriter>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSigningNodeWriter.FromPointer); // 0x70 SigningWriter               ( ModelClassType XmlSigningNodeWriter XmlSigningNodeWriter XmlSigningNodeWriter Pointer )
            value.TextFragmentWriter                        = GetObject<XmlUTF8NodeWriter>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlUTF8NodeWriter.FromPointer); // 0x78 TextFragmentWriter          ( ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer )
            value.OldWriter                                 = GetObject<XmlNodeWriter>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlNodeWriter.FromPointer); // 0x80 OldWriter                   ( ModelClassType XmlNodeWriter XmlNodeWriter XmlNodeWriter Pointer )
            value.OldStream                                 = GetObject<Stream>(new IntPtr(p + 0x088), ReversePrism.DataModels.Stream.FromPointer); // 0x88 OldStream                   ( ModelClassType Stream Stream Stream Pointer )
            value.OldNamespaceBoundary                      = GetInt32(new IntPtr(p + 0x090)); // 0x90 OldNamespaceBoundary        ( ModelPrimitiveType int int int Int32 )
            value.InList                                    = GetBool(new IntPtr(p + 0x094)); // 0x94 InList                      ( ModelPrimitiveType bool bool bool Bool )
            value.NodeWriterAsyncHelper                     = GetObject<XmlBaseWriterNodeWriterAsyncHelper>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlBaseWriterNodeWriterAsyncHelper.FromPointer); // 0x98 NodeWriterAsyncHelper       ( ModelClassType XmlBaseWriterNodeWriterAsyncHelper XmlBaseWriterNodeWriterAsyncHelper XmlBaseWriterNodeWriterAsyncHelper Pointer )

            return value;
        }
    }
}

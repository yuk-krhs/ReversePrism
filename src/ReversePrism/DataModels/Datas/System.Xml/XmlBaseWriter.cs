using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Writer                                   0001865A4120 ModelClassType XmlNodeWriter XmlNodeWriter XmlNodeWriter Pointer
    // 020 NsMgr                                    00018672EEE0 ModelClassType NamespaceManager NamespaceManager NamespaceManager Pointer
    // 028 Elements                                 000185CC6D48 ModelClassListType Element[] Element[] List<Element> Pointer
    // 030 Depth                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 AttributeLocalName                       000186671910 ModelPrimitiveType string string string String
    // 040 AttributeValue                           000186671910 ModelPrimitiveType string string string String
    // 048 IsXmlAttribute                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 IsXmlnsAttribute                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 04C WriteState                               0001865618F0 ModelEnumType WriteState WriteState WriteState Int32
    // 050 DocumentState                            00018672E6E0 ModelEnumType DocumentState DocumentState DocumentState Int32
    // 058 TrailBytes                               000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 060 TrailByteCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 NodeWriter                               0001865CBC80 ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer
    // 070 SigningWriter                            0001865C9D60 ModelClassType XmlSigningNodeWriter XmlSigningNodeWriter XmlSigningNodeWriter Pointer
    // 078 TextFragmentWriter                       0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer
    // 080 OldWriter                                0001865A4120 ModelClassType XmlNodeWriter XmlNodeWriter XmlNodeWriter Pointer
    // 088 OldStream                                000186670270 ModelClassType Stream Stream Stream Pointer
    // 090 OldNamespaceBoundary                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 094 InList                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 xmlnsNamespace                           string IL2CPP_TYPE_STRING
    // 000 xmlNamespace                             string IL2CPP_TYPE_STRING
    // 000 binhexEncoding                           BinHexEncoding IL2CPP_TYPE_CLASS
    // 008 prefixes                                 string[] IL2CPP_TYPE_SZARRAY
    // 098 NodeWriterAsyncHelper                    00018672F640 ModelClassType XmlBaseWriterNodeWriterAsyncHelper XmlBaseWriterNodeWriterAsyncHelper XmlBaseWriterNodeWriterAsyncHelper Pointer
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

            value.Writer                                    = GetObject<XmlNodeWriter>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlNodeWriter.FromPointer); // 024667C6AAB0 0x18 Writer                      ( 0001865A4120 ModelClassType XmlNodeWriter XmlNodeWriter XmlNodeWriter Pointer )
            value.NsMgr                                     = GetObject<NamespaceManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.NamespaceManager.FromPointer); // 024667C6AAD0 0x20 NsMgr                       ( 00018672EEE0 ModelClassType NamespaceManager NamespaceManager NamespaceManager Pointer )
            value.Elements                                  = GetObjectList<Element>(new IntPtr(p + 0x028), ReversePrism.DataModels.Element.FromPointer); // 024667C6AAF0 0x28 Elements                    ( 000185CC6D48 ModelClassListType Element[] Element[] List<Element> Pointer )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x030)); // 024667C6AB10 0x30 Depth                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AttributeLocalName                        = GetString(new IntPtr(p + 0x038)); // 024667C6AB30 0x38 AttributeLocalName          ( 000186671910 ModelPrimitiveType string string string String )
            value.AttributeValue                            = GetString(new IntPtr(p + 0x040)); // 024667C6AB50 0x40 AttributeValue              ( 000186671910 ModelPrimitiveType string string string String )
            value.IsXmlAttribute                            = GetBool(new IntPtr(p + 0x048)); // 024667C6AB70 0x48 IsXmlAttribute              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsXmlnsAttribute                          = GetBool(new IntPtr(p + 0x049)); // 024667C6AB90 0x49 IsXmlnsAttribute            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.WriteState                                = (WriteState)GetInt32(new IntPtr(p + 0x04C)); // 024667C6ABB0 0x4C WriteState                  ( 0001865618F0 ModelEnumType WriteState WriteState WriteState Int32 )
            value.DocumentState                             = (DocumentState)GetInt32(new IntPtr(p + 0x050)); // 024667C6ABD0 0x50 DocumentState               ( 00018672E6E0 ModelEnumType DocumentState DocumentState DocumentState Int32 )
            value.TrailBytes                                = GetSByteList(new IntPtr(p + 0x058)); // 024667C6ABF0 0x58 TrailBytes                  ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.TrailByteCount                            = GetInt32(new IntPtr(p + 0x060)); // 024667C6AC10 0x60 TrailByteCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NodeWriter                                = GetObject<XmlStreamNodeWriter>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlStreamNodeWriter.FromPointer); // 024667C6AC30 0x68 NodeWriter                  ( 0001865CBC80 ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer )
            value.SigningWriter                             = GetObject<XmlSigningNodeWriter>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSigningNodeWriter.FromPointer); // 024667C6AC50 0x70 SigningWriter               ( 0001865C9D60 ModelClassType XmlSigningNodeWriter XmlSigningNodeWriter XmlSigningNodeWriter Pointer )
            value.TextFragmentWriter                        = GetObject<XmlUTF8NodeWriter>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlUTF8NodeWriter.FromPointer); // 024667C6AC70 0x78 TextFragmentWriter          ( 0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer )
            value.OldWriter                                 = GetObject<XmlNodeWriter>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlNodeWriter.FromPointer); // 024667C6AC90 0x80 OldWriter                   ( 0001865A4120 ModelClassType XmlNodeWriter XmlNodeWriter XmlNodeWriter Pointer )
            value.OldStream                                 = GetObject<Stream>(new IntPtr(p + 0x088), ReversePrism.DataModels.Stream.FromPointer); // 024667C6ACB0 0x88 OldStream                   ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.OldNamespaceBoundary                      = GetInt32(new IntPtr(p + 0x090)); // 024667C6ACD0 0x90 OldNamespaceBoundary        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InList                                    = GetBool(new IntPtr(p + 0x094)); // 024667C6ACF0 0x94 InList                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.NodeWriterAsyncHelper                     = GetObject<XmlBaseWriterNodeWriterAsyncHelper>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlBaseWriterNodeWriterAsyncHelper.FromPointer); // 024667C6AD90 0x98 NodeWriterAsyncHelper       ( 00018672F640 ModelClassType XmlBaseWriterNodeWriterAsyncHelper XmlBaseWriterNodeWriterAsyncHelper XmlBaseWriterNodeWriterAsyncHelper Pointer )

            return value;
        }
    }
}

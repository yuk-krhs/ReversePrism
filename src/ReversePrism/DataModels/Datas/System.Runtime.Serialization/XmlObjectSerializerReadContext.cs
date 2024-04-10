using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 Attributes                               000186715220 ModelClassType Attributes Attributes Attributes Pointer
    // 088 DeserializedObjects                      0001866E92C0 ModelClassType HybridObjectCache HybridObjectCache HybridObjectCache Pointer
    // 090 XmlSerializableReader                    0001865C5070 ModelClassType XmlSerializableReader XmlSerializableReader XmlSerializableReader Pointer
    // 098 XmlDocument                              000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 0A0 AttributesInXmlData                      000186715010 ModelClassType Attributes Attributes Attributes Pointer
    // 0A8 ExtensionDataReader                      0001865AA5B0 ModelClassType XmlReaderDelegator XmlReaderDelegator XmlReaderDelegator Pointer
    // 0B0 getOnlyCollectionValue                   <object> IL2CPP_TYPE_OBJECT
    // 0B8 IsGetOnlyCollection                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XmlObjectSerializerReadContext : DataModel
    {
        public Attributes?                              Attributes                              { get; set; }
        public HybridObjectCache?                       DeserializedObjects                     { get; set; }
        public XmlSerializableReader?                   XmlSerializableReader                   { get; set; }
        public XmlDocument?                             XmlDocument                             { get; set; }
        public Attributes?                              AttributesInXmlData                     { get; set; }
        public XmlReaderDelegator?                      ExtensionDataReader                     { get; set; }
        public bool                                     IsGetOnlyCollection                     { get; set; }

        public static XmlObjectSerializerReadContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlObjectSerializerReadContext() { Pointer= p0 };

            value.Attributes                                = GetObject<Attributes>(new IntPtr(p + 0x080), ReversePrism.DataModels.Attributes.FromPointer); // 0245A4D26FC8 0x80 Attributes                  ( 000186715220 ModelClassType Attributes Attributes Attributes Pointer )
            value.DeserializedObjects                       = GetObject<HybridObjectCache>(new IntPtr(p + 0x088), ReversePrism.DataModels.HybridObjectCache.FromPointer); // 0245A4D26FE8 0x88 DeserializedObjects         ( 0001866E92C0 ModelClassType HybridObjectCache HybridObjectCache HybridObjectCache Pointer )
            value.XmlSerializableReader                     = GetObject<XmlSerializableReader>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlSerializableReader.FromPointer); // 0245A4D27008 0x90 XmlSerializableReader       ( 0001865C5070 ModelClassType XmlSerializableReader XmlSerializableReader XmlSerializableReader Pointer )
            value.XmlDocument                               = GetObject<XmlDocument>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlDocument.FromPointer); // 0245A4D27028 0x98 XmlDocument                 ( 000186595990 ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.AttributesInXmlData                       = GetObject<Attributes>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Attributes.FromPointer); // 0245A4D27048 0xA0 AttributesInXmlData         ( 000186715010 ModelClassType Attributes Attributes Attributes Pointer )
            value.ExtensionDataReader                       = GetObject<XmlReaderDelegator>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlReaderDelegator.FromPointer); // 0245A4D27068 0xA8 ExtensionDataReader         ( 0001865AA5B0 ModelClassType XmlReaderDelegator XmlReaderDelegator XmlReaderDelegator Pointer )
            value.IsGetOnlyCollection                       = GetBool(new IntPtr(p + 0x0B8)); // 0245A4D270A8 0xB8 IsGetOnlyCollection         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

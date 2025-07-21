using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 080 Attributes                               ModelClassType Attributes Attributes Attributes Pointer
    // 088 DeserializedObjects                      ModelClassType HybridObjectCache HybridObjectCache HybridObjectCache Pointer
    // 090 XmlSerializableReader                    ModelClassType XmlSerializableReader XmlSerializableReader XmlSerializableReader Pointer
    // 098 XmlDocument                              ModelClassType XmlDocument XmlDocument XmlDocument Pointer
    // 0A0 AttributesInXmlData                      ModelClassType Attributes Attributes Attributes Pointer
    // 0A8 ExtensionDataReader                      ModelClassType XmlReaderDelegator XmlReaderDelegator XmlReaderDelegator Pointer
    // 0B0 getOnlyCollectionValue                   <object> IL2CPP_TYPE_OBJECT
    // 0B8 IsGetOnlyCollection                      ModelPrimitiveType bool bool bool Bool
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

            value.Attributes                                = GetObject<Attributes>(new IntPtr(p + 0x080), ReversePrism.DataModels.Attributes.FromPointer); // 0x80 Attributes                  ( ModelClassType Attributes Attributes Attributes Pointer )
            value.DeserializedObjects                       = GetObject<HybridObjectCache>(new IntPtr(p + 0x088), ReversePrism.DataModels.HybridObjectCache.FromPointer); // 0x88 DeserializedObjects         ( ModelClassType HybridObjectCache HybridObjectCache HybridObjectCache Pointer )
            value.XmlSerializableReader                     = GetObject<XmlSerializableReader>(new IntPtr(p + 0x090), ReversePrism.DataModels.XmlSerializableReader.FromPointer); // 0x90 XmlSerializableReader       ( ModelClassType XmlSerializableReader XmlSerializableReader XmlSerializableReader Pointer )
            value.XmlDocument                               = GetObject<XmlDocument>(new IntPtr(p + 0x098), ReversePrism.DataModels.XmlDocument.FromPointer); // 0x98 XmlDocument                 ( ModelClassType XmlDocument XmlDocument XmlDocument Pointer )
            value.AttributesInXmlData                       = GetObject<Attributes>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Attributes.FromPointer); // 0xA0 AttributesInXmlData         ( ModelClassType Attributes Attributes Attributes Pointer )
            value.ExtensionDataReader                       = GetObject<XmlReaderDelegator>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.XmlReaderDelegator.FromPointer); // 0xA8 ExtensionDataReader         ( ModelClassType XmlReaderDelegator XmlReaderDelegator XmlReaderDelegator Pointer )
            value.IsGetOnlyCollection                       = GetBool(new IntPtr(p + 0x0B8)); // 0xB8 IsGetOnlyCollection         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

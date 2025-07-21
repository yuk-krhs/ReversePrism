using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 knownDataContracts                       Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 068 IsKnownTypeAttributeChecked              ModelPrimitiveType bool bool bool Bool
    // 070 TopLevelElementName                      ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 078 TopLevelElementNamespace                 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 080 IsTopLevelElementNullable                ModelPrimitiveType bool bool bool Bool
    // 081 IsTypeDefinedOnImport                    ModelPrimitiveType bool bool bool Bool
    // 088 XsdType                                  ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 090 HasRoot                                  ModelPrimitiveType bool bool bool Bool
    // 098 CreateXmlSerializable                    ModelClassType CreateXmlSerializableDelegate CreateXmlSerializableDelegate CreateXmlSerializableDelegate Pointer
    public partial class XmlDataContractCriticalHelper : DataModel
    {
        public bool                                     IsKnownTypeAttributeChecked             { get; set; }
        public XmlDictionaryString?                     TopLevelElementName                     { get; set; }
        public XmlDictionaryString?                     TopLevelElementNamespace                { get; set; }
        public bool                                     IsTopLevelElementNullable               { get; set; }
        public bool                                     IsTypeDefinedOnImport                   { get; set; }
        public XmlSchemaType?                           XsdType                                 { get; set; }
        public bool                                     HasRoot                                 { get; set; }
        public CreateXmlSerializableDelegate?           CreateXmlSerializable                   { get; set; }

        public static XmlDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDataContractCriticalHelper() { Pointer= p0 };

            value.IsKnownTypeAttributeChecked               = GetBool(new IntPtr(p + 0x068)); // 0x68 IsKnownTypeAttributeChecked ( ModelPrimitiveType bool bool bool Bool )
            value.TopLevelElementName                       = GetObject<XmlDictionaryString>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x70 TopLevelElementName         ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.TopLevelElementNamespace                  = GetObject<XmlDictionaryString>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 0x78 TopLevelElementNamespace    ( ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.IsTopLevelElementNullable                 = GetBool(new IntPtr(p + 0x080)); // 0x80 IsTopLevelElementNullable   ( ModelPrimitiveType bool bool bool Bool )
            value.IsTypeDefinedOnImport                     = GetBool(new IntPtr(p + 0x081)); // 0x81 IsTypeDefinedOnImport       ( ModelPrimitiveType bool bool bool Bool )
            value.XsdType                                   = GetObject<XmlSchemaType>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0x88 XsdType                     ( ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.HasRoot                                   = GetBool(new IntPtr(p + 0x090)); // 0x90 HasRoot                     ( ModelPrimitiveType bool bool bool Bool )
            value.CreateXmlSerializable                     = GetObject<CreateXmlSerializableDelegate>(new IntPtr(p + 0x098), ReversePrism.DataModels.CreateXmlSerializableDelegate.FromPointer); // 0x98 CreateXmlSerializable       ( ModelClassType CreateXmlSerializableDelegate CreateXmlSerializableDelegate CreateXmlSerializableDelegate Pointer )

            return value;
        }
    }
}

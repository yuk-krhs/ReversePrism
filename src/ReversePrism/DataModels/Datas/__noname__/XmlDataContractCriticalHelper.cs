using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 knownDataContracts                       Dictionary`2<XmlQualifiedName, DataContract> IL2CPP_TYPE_GENERICINST
    // 068 IsKnownTypeAttributeChecked              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 TopLevelElementName                      0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 078 TopLevelElementNamespace                 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer
    // 080 IsTopLevelElementNullable                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 081 IsTypeDefinedOnImport                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 088 XsdType                                  0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 090 HasRoot                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 098 CreateXmlSerializable                    00018663F660 ModelClassType CreateXmlSerializableDelegate CreateXmlSerializableDelegate CreateXmlSerializableDelegate Pointer
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

            value.IsKnownTypeAttributeChecked               = GetBool(new IntPtr(p + 0x068)); // 024667DD5708 0x68 IsKnownTypeAttributeChecked ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TopLevelElementName                       = GetObject<XmlDictionaryString>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 024667DD5728 0x70 TopLevelElementName         ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.TopLevelElementNamespace                  = GetObject<XmlDictionaryString>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlDictionaryString.FromPointer); // 024667DD5748 0x78 TopLevelElementNamespace    ( 0001866BA170 ModelClassType XmlDictionaryString XmlDictionaryString XmlDictionaryString Pointer )
            value.IsTopLevelElementNullable                 = GetBool(new IntPtr(p + 0x080)); // 024667DD5768 0x80 IsTopLevelElementNullable   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsTypeDefinedOnImport                     = GetBool(new IntPtr(p + 0x081)); // 024667DD5788 0x81 IsTypeDefinedOnImport       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.XsdType                                   = GetObject<XmlSchemaType>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 024667DD57A8 0x88 XsdType                     ( 0001866BFF90 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.HasRoot                                   = GetBool(new IntPtr(p + 0x090)); // 024667DD57C8 0x90 HasRoot                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CreateXmlSerializable                     = GetObject<CreateXmlSerializableDelegate>(new IntPtr(p + 0x098), ReversePrism.DataModels.CreateXmlSerializableDelegate.FromPointer); // 024667DD57E8 0x98 CreateXmlSerializable       ( 00018663F660 ModelClassType CreateXmlSerializableDelegate CreateXmlSerializableDelegate CreateXmlSerializableDelegate Pointer )

            return value;
        }
    }
}

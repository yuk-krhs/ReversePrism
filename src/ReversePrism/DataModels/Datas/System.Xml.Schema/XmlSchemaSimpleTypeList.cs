using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 ItemTypeName                             ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 058 ItemType                                 ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    // 060 BaseItemType                             ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer
    public partial class XmlSchemaSimpleTypeList : DataModel
    {
        public XmlQualifiedName?                        ItemTypeName                            { get; set; }
        public XmlSchemaSimpleType?                     ItemType                                { get; set; }
        public XmlSchemaSimpleType?                     BaseItemType                            { get; set; }

        public static XmlSchemaSimpleTypeList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaSimpleTypeList() { Pointer= p0 };

            value.ItemTypeName                              = GetObject<XmlQualifiedName>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x50 ItemTypeName                ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.ItemType                                  = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x058), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x58 ItemType                    ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )
            value.BaseItemType                              = GetObject<XmlSchemaSimpleType>(new IntPtr(p + 0x060), ReversePrism.DataModels.XmlSchemaSimpleType.FromPointer); // 0x60 BaseItemType                ( ModelClassType XmlSchemaSimpleType XmlSchemaSimpleType XmlSchemaSimpleType Pointer )

            return value;
        }
    }
}

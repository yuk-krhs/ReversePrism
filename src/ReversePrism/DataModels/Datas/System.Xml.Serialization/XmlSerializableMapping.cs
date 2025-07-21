using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 Schema                                   ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 080 SchemaType                               ModelClassType XmlSchemaComplexType XmlSchemaComplexType XmlSchemaComplexType Pointer
    // 088 SchemaTypeName                           ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    public partial class XmlSerializableMapping : DataModel
    {
        public XmlSchema?                               Schema                                  { get; set; }
        public XmlSchemaComplexType?                    SchemaType                              { get; set; }
        public XmlQualifiedName?                        SchemaTypeName                          { get; set; }

        public static XmlSerializableMapping? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSerializableMapping() { Pointer= p0 };

            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x78 Schema                      ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.SchemaType                                = GetObject<XmlSchemaComplexType>(new IntPtr(p + 0x080), ReversePrism.DataModels.XmlSchemaComplexType.FromPointer); // 0x80 SchemaType                  ( ModelClassType XmlSchemaComplexType XmlSchemaComplexType XmlSchemaComplexType Pointer )
            value.SchemaTypeName                            = GetObject<XmlQualifiedName>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x88 SchemaTypeName              ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )

            return value;
        }
    }
}

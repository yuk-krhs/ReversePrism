using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NamespaceUri                             ModelPrimitiveType string string string String
    // 018 SchemaInfo                               ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 020 Schema                                   ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    public partial class XmlSchemaCollectionNode : DataModel
    {
        public string                                   NamespaceUri                            { get; set; }
        public SchemaInfo?                              SchemaInfo                              { get; set; }
        public XmlSchema?                               Schema                                  { get; set; }

        public static XmlSchemaCollectionNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaCollectionNode() { Pointer= p0 };

            value.NamespaceUri                              = GetString(new IntPtr(p + 0x010)); // 0x10 NamespaceUri                ( ModelPrimitiveType string string string String )
            value.SchemaInfo                                = GetObject<SchemaInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.SchemaInfo.FromPointer); // 0x18 SchemaInfo                  ( ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x20 Schema                      ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )

            return value;
        }
    }
}

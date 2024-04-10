using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NamespaceUri                             000186671910 ModelPrimitiveType string string string String
    // 018 SchemaInfo                               0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    // 020 Schema                                   0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
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

            value.NamespaceUri                              = GetString(new IntPtr(p + 0x010)); // 024667620268 0x10 NamespaceUri                ( 000186671910 ModelPrimitiveType string string string String )
            value.SchemaInfo                                = GetObject<SchemaInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.SchemaInfo.FromPointer); // 024667620288 0x18 SchemaInfo                  ( 0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )
            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSchema.FromPointer); // 0246676202A8 0x20 Schema                      ( 0001866BE120 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )

            return value;
        }
    }
}

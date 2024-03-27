using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Node                                     0001865BB990 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    public partial class SchemaNamespaceManager
    {
        public XmlSchemaObject?                         Node                                    { get; set; }

        public static SchemaNamespaceManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaNamespaceManager();

            value.Node                                      = GetObject<XmlSchemaObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 0270D757BC80 0x50 Node                        ( 0001865BB990 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )

            return value;
        }
    }
}

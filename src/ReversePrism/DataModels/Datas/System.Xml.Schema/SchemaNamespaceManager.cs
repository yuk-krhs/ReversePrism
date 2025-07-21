using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Node                                     ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    public partial class SchemaNamespaceManager : DataModel
    {
        public XmlSchemaObject?                         Node                                    { get; set; }

        public static SchemaNamespaceManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaNamespaceManager() { Pointer= p0 };

            value.Node                                      = GetObject<XmlSchemaObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 0x50 Node                        ( ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )

            return value;
        }
    }
}

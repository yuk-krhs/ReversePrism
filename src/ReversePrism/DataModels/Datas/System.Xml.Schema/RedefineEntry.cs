using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Redefine                                 ModelClassType XmlSchemaRedefine XmlSchemaRedefine XmlSchemaRedefine Pointer
    // 018 SchemaToUpdate                           ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    public partial class RedefineEntry : DataModel
    {
        public XmlSchemaRedefine?                       Redefine                                { get; set; }
        public XmlSchema?                               SchemaToUpdate                          { get; set; }

        public static RedefineEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RedefineEntry() { Pointer= p0 };

            value.Redefine                                  = GetObject<XmlSchemaRedefine>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaRedefine.FromPointer); // 0x10 Redefine                    ( ModelClassType XmlSchemaRedefine XmlSchemaRedefine XmlSchemaRedefine Pointer )
            value.SchemaToUpdate                            = GetObject<XmlSchema>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x18 SchemaToUpdate              ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )

            return value;
        }
    }
}

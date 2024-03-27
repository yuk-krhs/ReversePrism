using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Redefine                                 0001865BE490 ModelClassType XmlSchemaRedefine XmlSchemaRedefine XmlSchemaRedefine Pointer
    // 018 SchemaToUpdate                           0001866BE3D0 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    public partial class RedefineEntry
    {
        public XmlSchemaRedefine?                       Redefine                                { get; set; }
        public XmlSchema?                               SchemaToUpdate                          { get; set; }

        public static RedefineEntry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RedefineEntry();

            value.Redefine                                  = GetObject<XmlSchemaRedefine>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaRedefine.FromPointer); // 0270D752B588 0x10 Redefine                    ( 0001865BE490 ModelClassType XmlSchemaRedefine XmlSchemaRedefine XmlSchemaRedefine Pointer )
            value.SchemaToUpdate                            = GetObject<XmlSchema>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchema.FromPointer); // 0270D752B5A8 0x18 SchemaToUpdate              ( 0001866BE3D0 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Parent                                   0001865BB990 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    public partial class XmlSchemaObjectCollection : DataModel
    {
        public XmlSchemaObject?                         Parent                                  { get; set; }

        public static XmlSchemaObjectCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaObjectCollection() { Pointer= p0 };

            value.Parent                                    = GetObject<XmlSchemaObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 024667563298 0x18 Parent                      ( 0001865BB990 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )

            return value;
        }
    }
}

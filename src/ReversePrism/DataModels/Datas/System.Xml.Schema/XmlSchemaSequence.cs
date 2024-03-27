using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 Items                                    0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    public partial class XmlSchemaSequence
    {
        public XmlSchemaObjectCollection?               Items                                   { get; set; }

        public static XmlSchemaSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaSequence();

            value.Items                                     = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0270D7553AA8 0x78 Items                       ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )

            return value;
        }
    }
}

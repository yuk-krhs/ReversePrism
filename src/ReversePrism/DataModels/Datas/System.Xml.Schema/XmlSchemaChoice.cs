using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 Items                                    ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    public partial class XmlSchemaChoice : DataModel
    {
        public XmlSchemaObjectCollection?               Items                                   { get; set; }

        public static XmlSchemaChoice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaChoice() { Pointer= p0 };

            value.Items                                     = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 0x78 Items                       ( ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )

            return value;
        }
    }
}

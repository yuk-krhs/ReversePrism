using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 Refer                                    0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    public partial class XmlSchemaKeyref
    {
        public XmlQualifiedName?                        Refer                                   { get; set; }

        public static XmlSchemaKeyref? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaKeyref();

            value.Refer                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x078), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0270D75B0ED0 0x78 Refer                       ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )

            return value;
        }
    }
}

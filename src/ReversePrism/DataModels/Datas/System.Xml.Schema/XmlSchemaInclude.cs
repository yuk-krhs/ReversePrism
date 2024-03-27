using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 Annotation                               0001865AD1E0 ModelClassType XmlSchemaAnnotation XmlSchemaAnnotation XmlSchemaAnnotation Pointer
    public partial class XmlSchemaInclude
    {
        public XmlSchemaAnnotation?                     Annotation                              { get; set; }

        public static XmlSchemaInclude? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaInclude();

            value.Annotation                                = GetObject<XmlSchemaAnnotation>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlSchemaAnnotation.FromPointer); // 0270D75B1238 0x68 Annotation                  ( 0001865AD1E0 ModelClassType XmlSchemaAnnotation XmlSchemaAnnotation XmlSchemaAnnotation Pointer )

            return value;
        }
    }
}

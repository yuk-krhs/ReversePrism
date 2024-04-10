using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 070 Annotation                               0001865AD1E0 ModelClassType XmlSchemaAnnotation XmlSchemaAnnotation XmlSchemaAnnotation Pointer
    public partial class XmlSchemaImport : DataModel
    {
        public string                                   Ns                                      { get; set; }
        public XmlSchemaAnnotation?                     Annotation                              { get; set; }

        public static XmlSchemaImport? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaImport() { Pointer= p0 };

            value.Ns                                        = GetString(new IntPtr(p + 0x068)); // 024667621040 0x68 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Annotation                                = GetObject<XmlSchemaAnnotation>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlSchemaAnnotation.FromPointer); // 024667621060 0x70 Annotation                  ( 0001865AD1E0 ModelClassType XmlSchemaAnnotation XmlSchemaAnnotation XmlSchemaAnnotation Pointer )

            return value;
        }
    }
}

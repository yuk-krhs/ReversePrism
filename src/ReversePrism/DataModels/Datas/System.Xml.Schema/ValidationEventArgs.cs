using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ex                                       0001865B5A80 ModelClassType XmlSchemaException XmlSchemaException XmlSchemaException Pointer
    // 018 Severity                                 0001865C93A0 ModelEnumType XmlSeverityType XmlSeverityType XmlSeverityType Int32
    public partial class ValidationEventArgs
    {
        public XmlSchemaException?                      Ex                                      { get; set; }
        public XmlSeverityType                          Severity                                { get; set; }

        public static ValidationEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValidationEventArgs();

            value.Ex                                        = GetObject<XmlSchemaException>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaException.FromPointer); // 0270D757DF98 0x10 Ex                          ( 0001865B5A80 ModelClassType XmlSchemaException XmlSchemaException XmlSchemaException Pointer )
            value.Severity                                  = (XmlSeverityType)GetInt32(new IntPtr(p + 0x018)); // 0270D757DFB8 0x18 Severity                    ( 0001865C93A0 ModelEnumType XmlSeverityType XmlSeverityType XmlSeverityType Int32 )

            return value;
        }
    }
}

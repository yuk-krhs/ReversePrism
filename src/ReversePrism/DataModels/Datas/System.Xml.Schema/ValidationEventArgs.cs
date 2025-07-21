using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Ex                                       ModelClassType XmlSchemaException XmlSchemaException XmlSchemaException Pointer
    // 018 Severity                                 ModelEnumType XmlSeverityType XmlSeverityType XmlSeverityType Int32
    public partial class ValidationEventArgs : DataModel
    {
        public XmlSchemaException?                      Ex                                      { get; set; }
        public XmlSeverityType                          Severity                                { get; set; }

        public static ValidationEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValidationEventArgs() { Pointer= p0 };

            value.Ex                                        = GetObject<XmlSchemaException>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaException.FromPointer); // 0x10 Ex                          ( ModelClassType XmlSchemaException XmlSchemaException XmlSchemaException Pointer )
            value.Severity                                  = (XmlSeverityType)GetInt32(new IntPtr(p + 0x018)); // 0x18 Severity                    ( ModelEnumType XmlSeverityType XmlSeverityType XmlSeverityType Int32 )

            return value;
        }
    }
}

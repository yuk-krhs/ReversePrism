using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Id                                       000186671910 ModelPrimitiveType string string string String
    // 040 Annotation                               0001865AD1E0 ModelClassType XmlSchemaAnnotation XmlSchemaAnnotation XmlSchemaAnnotation Pointer
    // 048 MoreAttributes                           000185CB3608 ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer
    public partial class XmlSchemaAnnotated
    {
        public string                                   Id                                      { get; set; }
        public XmlSchemaAnnotation?                     Annotation                              { get; set; }
        public List<XmlAttribute>?                      MoreAttributes                          { get; set; }

        public static XmlSchemaAnnotated? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaAnnotated();

            value.Id                                        = GetString(new IntPtr(p + 0x038)); // 0270D73858F0 0x38 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Annotation                                = GetObject<XmlSchemaAnnotation>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlSchemaAnnotation.FromPointer); // 0270D7385910 0x40 Annotation                  ( 0001865AD1E0 ModelClassType XmlSchemaAnnotation XmlSchemaAnnotation XmlSchemaAnnotation Pointer )
            value.MoreAttributes                            = GetObjectList<XmlAttribute>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlAttribute.FromPointer); // 0270D7385930 0x48 MoreAttributes              ( 000185CB3608 ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer )

            return value;
        }
    }
}

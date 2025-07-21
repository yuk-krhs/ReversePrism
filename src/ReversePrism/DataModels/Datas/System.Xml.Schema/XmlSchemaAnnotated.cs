using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Id                                       ModelPrimitiveType string string string String
    // 040 Annotation                               ModelClassType XmlSchemaAnnotation XmlSchemaAnnotation XmlSchemaAnnotation Pointer
    // 048 MoreAttributes                           ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer
    public partial class XmlSchemaAnnotated : DataModel
    {
        public string                                   Id                                      { get; set; }
        public XmlSchemaAnnotation?                     Annotation                              { get; set; }
        public List<XmlAttribute>?                      MoreAttributes                          { get; set; }

        public static XmlSchemaAnnotated? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaAnnotated() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x038)); // 0x38 Id                          ( ModelPrimitiveType string string string String )
            value.Annotation                                = GetObject<XmlSchemaAnnotation>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlSchemaAnnotation.FromPointer); // 0x40 Annotation                  ( ModelClassType XmlSchemaAnnotation XmlSchemaAnnotation XmlSchemaAnnotation Pointer )
            value.MoreAttributes                            = GetObjectList<XmlAttribute>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlAttribute.FromPointer); // 0x48 MoreAttributes              ( ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer )

            return value;
        }
    }
}

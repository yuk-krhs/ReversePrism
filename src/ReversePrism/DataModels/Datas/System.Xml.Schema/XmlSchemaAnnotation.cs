using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Id                                       000186671910 ModelPrimitiveType string string string String
    // 040 Items                                    0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer
    // 048 MoreAttributes                           000185CB3608 ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer
    public partial class XmlSchemaAnnotation : DataModel
    {
        public string                                   Id                                      { get; set; }
        public XmlSchemaObjectCollection?               Items                                   { get; set; }
        public List<XmlAttribute>?                      MoreAttributes                          { get; set; }

        public static XmlSchemaAnnotation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaAnnotation() { Pointer= p0 };

            value.Id                                        = GetString(new IntPtr(p + 0x038)); // 0246675979F0 0x38 Id                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Items                                     = GetObject<XmlSchemaObjectCollection>(new IntPtr(p + 0x040), ReversePrism.DataModels.XmlSchemaObjectCollection.FromPointer); // 024667597A10 0x40 Items                       ( 0001865BC5D0 ModelClassType XmlSchemaObjectCollection XmlSchemaObjectCollection XmlSchemaObjectCollection Pointer )
            value.MoreAttributes                            = GetObjectList<XmlAttribute>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlAttribute.FromPointer); // 024667597A30 0x48 MoreAttributes              ( 000185CB3608 ModelClassListType XmlAttribute[] XmlAttribute[] List<XmlAttribute> Pointer )

            return value;
        }
    }
}

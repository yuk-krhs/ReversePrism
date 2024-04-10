using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001866C0220 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 018 Element                                  0001866BEFB0 ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer
    // 020 Schema                                   0001866BE3D0 ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 028 KnownTypes                               000185D1E008 ModelClassListType List`1<XmlSchemaType> List`1<XmlSchemaType> List<XmlSchemaType> Pointer
    public partial class SchemaObjectInfo : DataModel
    {
        public XmlSchemaType?                           Type                                    { get; set; }
        public XmlSchemaElement?                        Element                                 { get; set; }
        public XmlSchema?                               Schema                                  { get; set; }
        public List<XmlSchemaType>?                     KnownTypes                              { get; set; }

        public static SchemaObjectInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaObjectInfo() { Pointer= p0 };

            value.Type                                      = GetObject<XmlSchemaType>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 024667DAAAB0 0x10 Type                        ( 0001866C0220 ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.Element                                   = GetObject<XmlSchemaElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaElement.FromPointer); // 024667DAAAD0 0x18 Element                     ( 0001866BEFB0 ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer )
            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSchema.FromPointer); // 024667DAAAF0 0x20 Schema                      ( 0001866BE3D0 ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.KnownTypes                                = GetObjectList<XmlSchemaType>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 024667DAAB10 0x28 KnownTypes                  ( 000185D1E008 ModelClassListType List`1<XmlSchemaType> List`1<XmlSchemaType> List<XmlSchemaType> Pointer )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer
    // 018 Element                                  ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer
    // 020 Schema                                   ModelClassType XmlSchema XmlSchema XmlSchema Pointer
    // 028 KnownTypes                               ModelClassListType List`1<XmlSchemaType> List`1<XmlSchemaType> List<XmlSchemaType> Pointer
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

            value.Type                                      = GetObject<XmlSchemaType>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0x10 Type                        ( ModelClassType XmlSchemaType XmlSchemaType XmlSchemaType Pointer )
            value.Element                                   = GetObject<XmlSchemaElement>(new IntPtr(p + 0x018), ReversePrism.DataModels.XmlSchemaElement.FromPointer); // 0x18 Element                     ( ModelClassType XmlSchemaElement XmlSchemaElement XmlSchemaElement Pointer )
            value.Schema                                    = GetObject<XmlSchema>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSchema.FromPointer); // 0x20 Schema                      ( ModelClassType XmlSchema XmlSchema XmlSchema Pointer )
            value.KnownTypes                                = GetObjectList<XmlSchemaType>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaType.FromPointer); // 0x28 KnownTypes                  ( ModelClassListType List`1<XmlSchemaType> List`1<XmlSchemaType> List<XmlSchemaType> Pointer )

            return value;
        }
    }
}

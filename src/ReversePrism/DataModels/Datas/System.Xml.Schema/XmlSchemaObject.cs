using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LineNum                                  ModelPrimitiveType int int int Int32
    // 014 LinePos                                  ModelPrimitiveType int int int Int32
    // 018 SourceUri                                ModelPrimitiveType string string string String
    // 020 Namespaces                               ModelClassType XmlSerializerNamespaces XmlSerializerNamespaces XmlSerializerNamespaces Pointer
    // 028 Parent                                   ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    // 030 IsProcessing                             ModelPrimitiveType bool bool bool Bool
    public partial class XmlSchemaObject : DataModel
    {
        public int                                      LineNum                                 { get; set; }
        public int                                      LinePos                                 { get; set; }
        public string                                   SourceUri                               { get; set; }
        public XmlSerializerNamespaces?                 Namespaces                              { get; set; }
        public XmlSchemaObject?                         Parent                                  { get; set; }
        public bool                                     IsProcessing                            { get; set; }

        public static XmlSchemaObject? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaObject() { Pointer= p0 };

            value.LineNum                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 LineNum                     ( ModelPrimitiveType int int int Int32 )
            value.LinePos                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 LinePos                     ( ModelPrimitiveType int int int Int32 )
            value.SourceUri                                 = GetString(new IntPtr(p + 0x018)); // 0x18 SourceUri                   ( ModelPrimitiveType string string string String )
            value.Namespaces                                = GetObject<XmlSerializerNamespaces>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSerializerNamespaces.FromPointer); // 0x20 Namespaces                  ( ModelClassType XmlSerializerNamespaces XmlSerializerNamespaces XmlSerializerNamespaces Pointer )
            value.Parent                                    = GetObject<XmlSchemaObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 0x28 Parent                      ( ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )
            value.IsProcessing                              = GetBool(new IntPtr(p + 0x030)); // 0x30 IsProcessing                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

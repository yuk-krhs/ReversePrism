using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LineNum                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 LinePos                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 SourceUri                                000186671910 ModelPrimitiveType string string string String
    // 020 Namespaces                               0001865C8ED0 ModelClassType XmlSerializerNamespaces XmlSerializerNamespaces XmlSerializerNamespaces Pointer
    // 028 Parent                                   0001865BB990 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer
    // 030 IsProcessing                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XmlSchemaObject
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
            var value   = new XmlSchemaObject();

            value.LineNum                                   = GetInt32(new IntPtr(p + 0x010)); // 0270D73852A0 0x10 LineNum                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LinePos                                   = GetInt32(new IntPtr(p + 0x014)); // 0270D73852C0 0x14 LinePos                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SourceUri                                 = GetString(new IntPtr(p + 0x018)); // 0270D73852E0 0x18 SourceUri                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Namespaces                                = GetObject<XmlSerializerNamespaces>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlSerializerNamespaces.FromPointer); // 0270D7385300 0x20 Namespaces                  ( 0001865C8ED0 ModelClassType XmlSerializerNamespaces XmlSerializerNamespaces XmlSerializerNamespaces Pointer )
            value.Parent                                    = GetObject<XmlSchemaObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlSchemaObject.FromPointer); // 0270D7385320 0x28 Parent                      ( 0001865BB990 ModelClassType XmlSchemaObject XmlSchemaObject XmlSchemaObject Pointer )
            value.IsProcessing                              = GetBool(new IntPtr(p + 0x030)); // 0270D7385340 0x30 IsProcessing                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Name                                     ModelPrimitiveType string string string String
    // 028 PublicId                                 ModelPrimitiveType string string string String
    // 030 SystemId                                 ModelPrimitiveType string string string String
    // 038 InternalSubset                           ModelPrimitiveType string string string String
    // 040 Namespaces                               ModelPrimitiveType bool bool bool Bool
    // 048 Entities                                 ModelClassType XmlNamedNodeMap XmlNamedNodeMap XmlNamedNodeMap Pointer
    // 050 Notations                                ModelClassType XmlNamedNodeMap XmlNamedNodeMap XmlNamedNodeMap Pointer
    // 058 SchemaInfo                               ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    public partial class XmlDocumentType : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   PublicId                                { get; set; }
        public string                                   SystemId                                { get; set; }
        public string                                   InternalSubset                          { get; set; }
        public bool                                     Namespaces                              { get; set; }
        public XmlNamedNodeMap?                         Entities                                { get; set; }
        public XmlNamedNodeMap?                         Notations                               { get; set; }
        public SchemaInfo?                              SchemaInfo                              { get; set; }

        public static XmlDocumentType? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDocumentType() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.PublicId                                  = GetString(new IntPtr(p + 0x028)); // 0x28 PublicId                    ( ModelPrimitiveType string string string String )
            value.SystemId                                  = GetString(new IntPtr(p + 0x030)); // 0x30 SystemId                    ( ModelPrimitiveType string string string String )
            value.InternalSubset                            = GetString(new IntPtr(p + 0x038)); // 0x38 InternalSubset              ( ModelPrimitiveType string string string String )
            value.Namespaces                                = GetBool(new IntPtr(p + 0x040)); // 0x40 Namespaces                  ( ModelPrimitiveType bool bool bool Bool )
            value.Entities                                  = GetObject<XmlNamedNodeMap>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlNamedNodeMap.FromPointer); // 0x48 Entities                    ( ModelClassType XmlNamedNodeMap XmlNamedNodeMap XmlNamedNodeMap Pointer )
            value.Notations                                 = GetObject<XmlNamedNodeMap>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlNamedNodeMap.FromPointer); // 0x50 Notations                   ( ModelClassType XmlNamedNodeMap XmlNamedNodeMap XmlNamedNodeMap Pointer )
            value.SchemaInfo                                = GetObject<SchemaInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.SchemaInfo.FromPointer); // 0x58 SchemaInfo                  ( ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )

            return value;
        }
    }
}

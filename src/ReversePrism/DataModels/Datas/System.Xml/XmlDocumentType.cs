using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 028 PublicId                                 000186671910 ModelPrimitiveType string string string String
    // 030 SystemId                                 000186671910 ModelPrimitiveType string string string String
    // 038 InternalSubset                           000186671910 ModelPrimitiveType string string string String
    // 040 Namespaces                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 Entities                                 0001865A0E30 ModelClassType XmlNamedNodeMap XmlNamedNodeMap XmlNamedNodeMap Pointer
    // 050 Notations                                0001865A0E30 ModelClassType XmlNamedNodeMap XmlNamedNodeMap XmlNamedNodeMap Pointer
    // 058 SchemaInfo                               0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer
    public partial class XmlDocumentType
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
            var value   = new XmlDocumentType();

            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0270D744E560 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.PublicId                                  = GetString(new IntPtr(p + 0x028)); // 0270D744E580 0x28 PublicId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.SystemId                                  = GetString(new IntPtr(p + 0x030)); // 0270D744E5A0 0x30 SystemId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.InternalSubset                            = GetString(new IntPtr(p + 0x038)); // 0270D744E5C0 0x38 InternalSubset              ( 000186671910 ModelPrimitiveType string string string String )
            value.Namespaces                                = GetBool(new IntPtr(p + 0x040)); // 0270D744E5E0 0x40 Namespaces                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Entities                                  = GetObject<XmlNamedNodeMap>(new IntPtr(p + 0x048), ReversePrism.DataModels.XmlNamedNodeMap.FromPointer); // 0270D744E600 0x48 Entities                    ( 0001865A0E30 ModelClassType XmlNamedNodeMap XmlNamedNodeMap XmlNamedNodeMap Pointer )
            value.Notations                                 = GetObject<XmlNamedNodeMap>(new IntPtr(p + 0x050), ReversePrism.DataModels.XmlNamedNodeMap.FromPointer); // 0270D744E620 0x50 Notations                   ( 0001865A0E30 ModelClassType XmlNamedNodeMap XmlNamedNodeMap XmlNamedNodeMap Pointer )
            value.SchemaInfo                                = GetObject<SchemaInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.SchemaInfo.FromPointer); // 0270D744E640 0x58 SchemaInfo                  ( 0001866E9EB0 ModelClassType SchemaInfo SchemaInfo SchemaInfo Pointer )

            return value;
        }
    }
}

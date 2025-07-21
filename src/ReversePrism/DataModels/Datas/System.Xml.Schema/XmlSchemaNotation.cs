using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Name                                     ModelPrimitiveType string string string String
    // 058 PublicId                                 ModelPrimitiveType string string string String
    // 060 SystemId                                 ModelPrimitiveType string string string String
    // 068 Qname                                    ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    public partial class XmlSchemaNotation : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   PublicId                                { get; set; }
        public string                                   SystemId                                { get; set; }
        public XmlQualifiedName?                        Qname                                   { get; set; }

        public static XmlSchemaNotation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaNotation() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x050)); // 0x50 Name                        ( ModelPrimitiveType string string string String )
            value.PublicId                                  = GetString(new IntPtr(p + 0x058)); // 0x58 PublicId                    ( ModelPrimitiveType string string string String )
            value.SystemId                                  = GetString(new IntPtr(p + 0x060)); // 0x60 SystemId                    ( ModelPrimitiveType string string string String )
            value.Qname                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x68 Qname                       ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )

            return value;
        }
    }
}

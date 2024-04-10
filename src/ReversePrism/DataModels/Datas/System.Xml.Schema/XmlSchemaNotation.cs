using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Name                                     000186671910 ModelPrimitiveType string string string String
    // 058 PublicId                                 000186671910 ModelPrimitiveType string string string String
    // 060 SystemId                                 000186671910 ModelPrimitiveType string string string String
    // 068 Qname                                    0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
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

            value.Name                                      = GetString(new IntPtr(p + 0x050)); // 024667597008 0x50 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.PublicId                                  = GetString(new IntPtr(p + 0x058)); // 024667597028 0x58 PublicId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.SystemId                                  = GetString(new IntPtr(p + 0x060)); // 024667597048 0x60 SystemId                    ( 000186671910 ModelPrimitiveType string string string String )
            value.Qname                                     = GetObject<XmlQualifiedName>(new IntPtr(p + 0x068), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 024667597068 0x68 Qname                       ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )

            return value;
        }
    }
}

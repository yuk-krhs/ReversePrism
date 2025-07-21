using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 SystemLiteral                            ModelPrimitiveType string string string String
    // 020 Pubid                                    ModelPrimitiveType string string string String
    public partial class SchemaNotation : DataModel
    {
        public XmlQualifiedName?                        Name                                    { get; set; }
        public string                                   SystemLiteral                           { get; set; }
        public string                                   Pubid                                   { get; set; }

        public static SchemaNotation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SchemaNotation() { Pointer= p0 };

            value.Name                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0x10 Name                        ( ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.SystemLiteral                             = GetString(new IntPtr(p + 0x018)); // 0x18 SystemLiteral               ( ModelPrimitiveType string string string String )
            value.Pubid                                     = GetString(new IntPtr(p + 0x020)); // 0x20 Pubid                       ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}

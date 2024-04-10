using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer
    // 018 SystemLiteral                            000186671910 ModelPrimitiveType string string string String
    // 020 Pubid                                    000186671910 ModelPrimitiveType string string string String
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

            value.Name                                      = GetObject<XmlQualifiedName>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlQualifiedName.FromPointer); // 0246675F0788 0x10 Name                        ( 0001866BC7E0 ModelClassType XmlQualifiedName XmlQualifiedName XmlQualifiedName Pointer )
            value.SystemLiteral                             = GetString(new IntPtr(p + 0x018)); // 0246675F07A8 0x18 SystemLiteral               ( 000186671910 ModelPrimitiveType string string string String )
            value.Pubid                                     = GetString(new IntPtr(p + 0x020)); // 0246675F07C8 0x20 Pubid                       ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}

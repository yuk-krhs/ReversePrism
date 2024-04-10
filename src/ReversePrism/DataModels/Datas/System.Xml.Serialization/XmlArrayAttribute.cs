using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementName                              000186671910 ModelPrimitiveType string string string String
    // 018 Form                                     0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 01C IsNullable                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 028 Order                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class XmlArrayAttribute : DataModel
    {
        public string                                   ElementName                             { get; set; }
        public XmlSchemaForm                            Form                                    { get; set; }
        public bool                                     IsNullable                              { get; set; }
        public string                                   Ns                                      { get; set; }
        public int                                      Order                                   { get; set; }

        public static XmlArrayAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlArrayAttribute() { Pointer= p0 };

            value.ElementName                               = GetString(new IntPtr(p + 0x010)); // 024667515EA8 0x10 ElementName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x018)); // 024667515EC8 0x18 Form                        ( 0001865B66F0 ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.IsNullable                                = GetBool(new IntPtr(p + 0x01C)); // 024667515EE8 0x1C IsNullable                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Ns                                        = GetString(new IntPtr(p + 0x020)); // 024667515F08 0x20 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Order                                     = GetInt32(new IntPtr(p + 0x028)); // 024667515F28 0x28 Order                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ElementName                              ModelPrimitiveType string string string String
    // 018 Form                                     ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32
    // 01C IsNullable                               ModelPrimitiveType bool bool bool Bool
    // 020 Ns                                       ModelPrimitiveType string string string String
    // 028 Order                                    ModelPrimitiveType int int int Int32
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

            value.ElementName                               = GetString(new IntPtr(p + 0x010)); // 0x10 ElementName                 ( ModelPrimitiveType string string string String )
            value.Form                                      = (XmlSchemaForm)GetInt32(new IntPtr(p + 0x018)); // 0x18 Form                        ( ModelEnumType XmlSchemaForm XmlSchemaForm XmlSchemaForm Int32 )
            value.IsNullable                                = GetBool(new IntPtr(p + 0x01C)); // 0x1C IsNullable                  ( ModelPrimitiveType bool bool bool Bool )
            value.Ns                                        = GetString(new IntPtr(p + 0x020)); // 0x20 Ns                          ( ModelPrimitiveType string string string String )
            value.Order                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Order                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 UseAttribute                             ModelPrimitiveType bool bool bool Bool
    // 030 XmlElementName                           ModelPrimitiveType string string string String
    // 038 XmlNamespace                             ModelPrimitiveType string string string String
    // 040 XmlTypeName                              ModelPrimitiveType string string string String
    // 048 XmlTypeNamespace                         ModelPrimitiveType string string string String
    // 050 IsType                                   ModelPrimitiveType bool bool bool Bool
    // 051 IsElement                                ModelPrimitiveType bool bool bool Bool
    public partial class SoapTypeAttribute : DataModel
    {
        public bool                                     UseAttribute                            { get; set; }
        public string                                   XmlElementName                          { get; set; }
        public string                                   XmlNamespace                            { get; set; }
        public string                                   XmlTypeName                             { get; set; }
        public string                                   XmlTypeNamespace                        { get; set; }
        public bool                                     IsType                                  { get; set; }
        public bool                                     IsElement                               { get; set; }

        public static SoapTypeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoapTypeAttribute() { Pointer= p0 };

            value.UseAttribute                              = GetBool(new IntPtr(p + 0x028)); // 0x28 UseAttribute                ( ModelPrimitiveType bool bool bool Bool )
            value.XmlElementName                            = GetString(new IntPtr(p + 0x030)); // 0x30 XmlElementName              ( ModelPrimitiveType string string string String )
            value.XmlNamespace                              = GetString(new IntPtr(p + 0x038)); // 0x38 XmlNamespace                ( ModelPrimitiveType string string string String )
            value.XmlTypeName                               = GetString(new IntPtr(p + 0x040)); // 0x40 XmlTypeName                 ( ModelPrimitiveType string string string String )
            value.XmlTypeNamespace                          = GetString(new IntPtr(p + 0x048)); // 0x48 XmlTypeNamespace            ( ModelPrimitiveType string string string String )
            value.IsType                                    = GetBool(new IntPtr(p + 0x050)); // 0x50 IsType                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsElement                                 = GetBool(new IntPtr(p + 0x051)); // 0x51 IsElement                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 UseAttribute                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 XmlElementName                           000186671910 ModelPrimitiveType string string string String
    // 038 XmlNamespace                             000186671910 ModelPrimitiveType string string string String
    // 040 XmlTypeName                              000186671910 ModelPrimitiveType string string string String
    // 048 XmlTypeNamespace                         000186671910 ModelPrimitiveType string string string String
    // 050 IsType                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 051 IsElement                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SoapTypeAttribute
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
            var value   = new SoapTypeAttribute();

            value.UseAttribute                              = GetBool(new IntPtr(p + 0x028)); // 0270D6BE7268 0x28 UseAttribute                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.XmlElementName                            = GetString(new IntPtr(p + 0x030)); // 0270D6BE7288 0x30 XmlElementName              ( 000186671910 ModelPrimitiveType string string string String )
            value.XmlNamespace                              = GetString(new IntPtr(p + 0x038)); // 0270D6BE72A8 0x38 XmlNamespace                ( 000186671910 ModelPrimitiveType string string string String )
            value.XmlTypeName                               = GetString(new IntPtr(p + 0x040)); // 0270D6BE72C8 0x40 XmlTypeName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.XmlTypeNamespace                          = GetString(new IntPtr(p + 0x048)); // 0270D6BE72E8 0x48 XmlTypeNamespace            ( 000186671910 ModelPrimitiveType string string string String )
            value.IsType                                    = GetBool(new IntPtr(p + 0x050)); // 0270D6BE7308 0x50 IsType                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsElement                                 = GetBool(new IntPtr(p + 0x051)); // 0270D6BE7328 0x51 IsElement                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}

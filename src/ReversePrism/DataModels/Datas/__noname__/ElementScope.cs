using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PrevNSTop                                0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Prefix                                   000186671BA0 ModelPrimitiveType string string string String
    // 020 LocalName                                000186671BA0 ModelPrimitiveType string string string String
    // 028 NamespaceUri                             000186671BA0 ModelPrimitiveType string string string String
    // 030 XmlSpace                                 0001865CA4B0 ModelEnumType XmlSpace XmlSpace XmlSpace Int32
    // 038 XmlLang                                  000186671BA0 ModelPrimitiveType string string string String
    public partial class ElementScope
    {
        public int                                      PrevNSTop                               { get; set; }
        public string                                   Prefix                                  { get; set; }
        public string                                   LocalName                               { get; set; }
        public string                                   NamespaceUri                            { get; set; }
        public XmlSpace                                 XmlSpace                                { get; set; }
        public string                                   XmlLang                                 { get; set; }

        public static ElementScope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ElementScope();

            value.PrevNSTop                                 = GetInt32(new IntPtr(p + 0x010)); // 0270D7407E50 0x10 PrevNSTop                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 0270D7407E70 0x18 Prefix                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.LocalName                                 = GetString(new IntPtr(p + 0x020)); // 0270D7407E90 0x20 LocalName                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x028)); // 0270D7407EB0 0x28 NamespaceUri                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.XmlSpace                                  = (XmlSpace)GetInt32(new IntPtr(p + 0x030)); // 0270D7407ED0 0x30 XmlSpace                    ( 0001865CA4B0 ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.XmlLang                                   = GetString(new IntPtr(p + 0x038)); // 0270D7407EF0 0x38 XmlLang                     ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}

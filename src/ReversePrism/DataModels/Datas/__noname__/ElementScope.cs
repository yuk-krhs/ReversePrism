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
    public partial class ElementScope : DataModel
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
            var value   = new ElementScope() { Pointer= p0 };

            value.PrevNSTop                                 = GetInt32(new IntPtr(p + 0x010)); // 024667467E50 0x10 PrevNSTop                   ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 024667467E70 0x18 Prefix                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.LocalName                                 = GetString(new IntPtr(p + 0x020)); // 024667467E90 0x20 LocalName                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x028)); // 024667467EB0 0x28 NamespaceUri                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.XmlSpace                                  = (XmlSpace)GetInt32(new IntPtr(p + 0x030)); // 024667467ED0 0x30 XmlSpace                    ( 0001865CA4B0 ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.XmlLang                                   = GetString(new IntPtr(p + 0x038)); // 024667467EF0 0x38 XmlLang                     ( 000186671BA0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}

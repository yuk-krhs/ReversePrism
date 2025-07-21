using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PrevNSTop                                ModelPrimitiveType int int int Int32
    // 018 Prefix                                   ModelPrimitiveType string string string String
    // 020 LocalName                                ModelPrimitiveType string string string String
    // 028 NamespaceUri                             ModelPrimitiveType string string string String
    // 030 XmlSpace                                 ModelEnumType XmlSpace XmlSpace XmlSpace Int32
    // 038 XmlLang                                  ModelPrimitiveType string string string String
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

            value.PrevNSTop                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 PrevNSTop                   ( ModelPrimitiveType int int int Int32 )
            value.Prefix                                    = GetString(new IntPtr(p + 0x018)); // 0x18 Prefix                      ( ModelPrimitiveType string string string String )
            value.LocalName                                 = GetString(new IntPtr(p + 0x020)); // 0x20 LocalName                   ( ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x028)); // 0x28 NamespaceUri                ( ModelPrimitiveType string string string String )
            value.XmlSpace                                  = (XmlSpace)GetInt32(new IntPtr(p + 0x030)); // 0x30 XmlSpace                    ( ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.XmlLang                                   = GetString(new IntPtr(p + 0x038)); // 0x38 XmlLang                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 XmlSpace                                 ModelEnumType XmlSpace XmlSpace XmlSpace Int32
    // 018 XmlLang                                  ModelPrimitiveType string string string String
    // 020 DefaultNamespace                         ModelPrimitiveType string string string String
    // 028 PreviousContext                          ModelClassType XmlContext XmlContext XmlContext Pointer
    public partial class XmlContext : DataModel
    {
        public XmlSpace                                 XmlSpace                                { get; set; }
        public string                                   XmlLang                                 { get; set; }
        public string                                   DefaultNamespace                        { get; set; }
        public XmlContext?                              PreviousContext                         { get; set; }

        public static XmlContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlContext() { Pointer= p0 };

            value.XmlSpace                                  = (XmlSpace)GetInt32(new IntPtr(p + 0x010)); // 0x10 XmlSpace                    ( ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.XmlLang                                   = GetString(new IntPtr(p + 0x018)); // 0x18 XmlLang                     ( ModelPrimitiveType string string string String )
            value.DefaultNamespace                          = GetString(new IntPtr(p + 0x020)); // 0x20 DefaultNamespace            ( ModelPrimitiveType string string string String )
            value.PreviousContext                           = GetObject<XmlContext>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlContext.FromPointer); // 0x28 PreviousContext             ( ModelClassType XmlContext XmlContext XmlContext Pointer )

            return value;
        }
    }
}

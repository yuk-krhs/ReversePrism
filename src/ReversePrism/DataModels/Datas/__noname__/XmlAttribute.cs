using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Space                                    ModelEnumType XmlSpace XmlSpace XmlSpace Int32
    // 018 Lang                                     ModelPrimitiveType string string string String
    // 020 Depth                                    ModelPrimitiveType int int int Int32
    public partial class XmlAttribute : DataModel
    {
        public XmlSpace                                 Space                                   { get; set; }
        public string                                   Lang                                    { get; set; }
        public int                                      Depth                                   { get; set; }

        public static XmlAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlAttribute() { Pointer= p0 };

            value.Space                                     = (XmlSpace)GetInt32(new IntPtr(p + 0x010)); // 0x10 Space                       ( ModelEnumType XmlSpace XmlSpace XmlSpace Int32 )
            value.Lang                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Lang                        ( ModelPrimitiveType string string string String )
            value.Depth                                     = GetInt32(new IntPtr(p + 0x020)); // 0x20 Depth                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

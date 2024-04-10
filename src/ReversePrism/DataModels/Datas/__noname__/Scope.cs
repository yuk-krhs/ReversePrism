using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 XmlnsAttributeCount                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 XmlnsOffset                              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Scope : DataModel
    {
        public int                                      XmlnsAttributeCount                     { get; set; }
        public int                                      XmlnsOffset                             { get; set; }

        public static Scope? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Scope() { Pointer= p0 };

            value.XmlnsAttributeCount                       = GetInt32(new IntPtr(p + 0x010)); // 024667CB9058 0x10 XmlnsAttributeCount         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.XmlnsOffset                               = GetInt32(new IntPtr(p + 0x014)); // 024667CB9078 0x14 XmlnsOffset                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

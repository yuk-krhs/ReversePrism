using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 hashCodeDelegate                         HashCodeOfStringDelegate IL2CPP_TYPE_CLASS
    // 010 Name                                     000186671910 ModelPrimitiveType string string string String
    // 018 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 020 Hash                                     0001865F5290 ModelPrimitiveType int int int Int32
    // 008 Empty                                    XmlQualifiedName IL2CPP_TYPE_CLASS
    public partial class XmlQualifiedName
    {
        public string                                   Name                                    { get; set; }
        public string                                   Ns                                      { get; set; }
        public int                                      Hash                                    { get; set; }

        public static XmlQualifiedName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlQualifiedName();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 027004CBAE58 0x10 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 027004CBAE78 0x18 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.Hash                                      = GetInt32(new IntPtr(p + 0x020)); // 027004CBAE98 0x20 Hash                        ( 0001865F5290 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

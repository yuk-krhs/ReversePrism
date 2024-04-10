using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 XmlName                                  000186672F10 ModelPrimitiveType string string string String
    // 018 EnumName                                 000186672F10 ModelPrimitiveType string string string String
    // 020 Value                                    0001865F8300 ModelPrimitiveType long long long Int64
    public partial class EnumMapMember : DataModel
    {
        public string                                   XmlName                                 { get; set; }
        public string                                   EnumName                                { get; set; }
        public long                                     Value                                   { get; set; }

        public static EnumMapMember? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnumMapMember() { Pointer= p0 };

            value.XmlName                                   = GetString(new IntPtr(p + 0x010)); // 02466753B748 0x10 XmlName                     ( 000186672F10 ModelPrimitiveType string string string String )
            value.EnumName                                  = GetString(new IntPtr(p + 0x018)); // 02466753B768 0x18 EnumName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.Value                                     = GetInt64(new IntPtr(p + 0x020)); // 02466753B788 0x20 Value                       ( 0001865F8300 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}

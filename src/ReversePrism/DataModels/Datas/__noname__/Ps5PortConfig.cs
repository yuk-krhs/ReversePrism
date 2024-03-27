using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxChannelPorts                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 MaxObjectPorts                           0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Ps5PortConfig
    {
        public int                                      MaxChannelPorts                         { get; set; }
        public int                                      MaxObjectPorts                          { get; set; }

        public static Ps5PortConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Ps5PortConfig();

            value.MaxChannelPorts                           = GetInt32(new IntPtr(p + 0x010)); // 0270D1178778 0x10 MaxChannelPorts             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxObjectPorts                            = GetInt32(new IntPtr(p + 0x014)); // 0270D1178798 0x14 MaxObjectPorts              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

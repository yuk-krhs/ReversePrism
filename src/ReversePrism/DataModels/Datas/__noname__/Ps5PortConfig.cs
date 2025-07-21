using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxChannelPorts                          ModelPrimitiveType int int int Int32
    // 014 MaxObjectPorts                           ModelPrimitiveType int int int Int32
    public partial class Ps5PortConfig : DataModel
    {
        public int                                      MaxChannelPorts                         { get; set; }
        public int                                      MaxObjectPorts                          { get; set; }

        public static Ps5PortConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Ps5PortConfig() { Pointer= p0 };

            value.MaxChannelPorts                           = GetInt32(new IntPtr(p + 0x010)); // 0x10 MaxChannelPorts             ( ModelPrimitiveType int int int Int32 )
            value.MaxObjectPorts                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 MaxObjectPorts              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}

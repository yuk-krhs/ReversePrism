using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Next                                     <int> IL2CPP_TYPE_I
    // 018 IpAddress                                ModelPrimitiveType string string string String
    // 020 IpMask                                   ModelPrimitiveType string string string String
    // 028 Context                                  ModelPrimitiveType uint uint uint UInt32
    public partial class Win32_IP_ADDR_STRING : DataModel
    {
        public string                                   IpAddress                               { get; set; }
        public string                                   IpMask                                  { get; set; }
        public uint                                     Context                                 { get; set; }

        public static Win32_IP_ADDR_STRING? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Win32_IP_ADDR_STRING() { Pointer= p0 };

            value.IpAddress                                 = GetString(new IntPtr(p + 0x018)); // 0x18 IpAddress                   ( ModelPrimitiveType string string string String )
            value.IpMask                                    = GetString(new IntPtr(p + 0x020)); // 0x20 IpMask                      ( ModelPrimitiveType string string string String )
            value.Context                                   = GetUInt32(new IntPtr(p + 0x028)); // 0x28 Context                     ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}

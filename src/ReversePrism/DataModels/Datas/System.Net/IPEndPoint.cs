using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Address                                  0001865E3820 ModelClassType IPAddress IPAddress IPAddress Pointer
    // 018 Port                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 Any                                      IPEndPoint IL2CPP_TYPE_CLASS
    // 008 IPv6Any                                  IPEndPoint IL2CPP_TYPE_CLASS
    public partial class IPEndPoint
    {
        public IPAddress?                               Address                                 { get; set; }
        public int                                      Port                                    { get; set; }

        public static IPEndPoint? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IPEndPoint();

            value.Address                                   = GetObject<IPAddress>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPAddress.FromPointer); // 0270D7A0B5F8 0x10 Address                     ( 0001865E3820 ModelClassType IPAddress IPAddress IPAddress Pointer )
            value.Port                                      = GetInt32(new IntPtr(p + 0x018)); // 0270D7A0B618 0x18 Port                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
